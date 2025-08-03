import { Component, computed, OnInit, signal } from '@angular/core';
import { Contact } from '../../models/contact.interface';
import { ContactService } from '../../core/services/contact.service';
import { MatPaginatorModule, PageEvent } from '@angular/material/paginator';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { ContactCardComponent } from '../contact-card/contact-card';
import { MatDialog } from '@angular/material/dialog';
import { ContactDetailsDialogComponent } from '../contact-details-dialog/contact-details-dialog';
import { SearchFilterComponent, SearchFilterEvent } from '../search-filter/search-filter';

@Component({
  selector: 'app-contact-list',
  imports: [
    CommonModule,
    ContactCardComponent,
    MatPaginatorModule,
    MatIconModule,
    MatProgressSpinnerModule,
    SearchFilterComponent
  ],
  templateUrl: './contact-list.html',
  styleUrl: './contact-list.scss'
})
export class ContactListComponent implements OnInit {
  contacts = signal<Contact[]>([]);
  loading = signal(true);
  errorMessage = signal<string | null>(null);
  currentPage = signal(0);
  pageSize = signal(8);
  pageSizeOptions = [8, 16, 24];

  searchTerm = signal('');
  selectedProvince = signal('');

  constructor(
    private contactService: ContactService,
    private dialog: MatDialog
  ) { }

  ngOnInit() {
    this.loadContacts();
  }

 // computed for unique provinces
  provinces = computed(() => {
    const allProvinces = this.contacts()
      .map(contact => contact.province)
      .filter(Boolean) // Remove null or undefined
      .filter((province, index, array) => array.indexOf(province) === index) // Remove duplicates
      .sort();

    return allProvinces as string[];
  });

  filteredContacts = computed(() => {
    let filtered = this.contacts();

    // Apply search filter
    const search = this.searchTerm().toLowerCase().trim();
    if (search) {
      filtered = filtered.filter(contact =>
        contact.fullName.toLowerCase().includes(search) ||
        contact.email.toLowerCase().includes(search) ||
        (contact.phoneNumber && contact.phoneNumber.toLowerCase().includes(search)) ||
        (contact.city && contact.city.toLowerCase().includes(search))
      );
    }

    // Apply province filter
    const province = this.selectedProvince();
    if (province) {
      filtered = filtered.filter(contact => contact.province === province);
    }

    return filtered;
  });

  paginatedContacts = computed(() => {
    const start = this.currentPage() * this.pageSize();
    const end = start + this.pageSize();
    return this.filteredContacts().slice(start, end);
  });

  onFilterChange(event: SearchFilterEvent) {
    this.searchTerm.set(event.searchTerm);
    this.selectedProvince.set(event.selectedProvince);
    this.currentPage.set(0); // Reset to first page when filtering
  }

  loadContacts() {
    this.loading.set(true);
    this.errorMessage.set(null);
    this.contactService.getContacts().subscribe({
      next: (contacts) => {
        this.contacts.set(contacts);
        this.loading.set(false);
      },
      error: (error) => {
        this.loading.set(false);
        this.errorMessage.set('Failed to load contacts. Please try again later.');
      }
    });
  }

  openContactDetails(contact: Contact) {
    this.dialog.open(ContactDetailsDialogComponent, {
      data: contact,
      width: '500px',
      maxWidth: '90vw',
      maxHeight: '80vh',
      panelClass: 'contact-dialog-panel'
    });
  }

  onPageChange(event: PageEvent) {
    this.currentPage.set(event.pageIndex);
    this.pageSize.set(event.pageSize);
  }
}
