import { Component, computed, OnInit, signal } from '@angular/core';
import { Contact } from '../../models/contact.interface';
import { ContactService } from '../../core/services/contact.service';
import { MatPaginatorModule, PageEvent } from '@angular/material/paginator';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { ContactCardComponent } from '../contact-card/contact-card';

@Component({
  selector: 'app-contact-list',
  imports: [
    CommonModule,
    ContactCardComponent,
    MatPaginatorModule,
    MatIconModule,
    MatProgressSpinnerModule,
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

  constructor(private contactService: ContactService) { }

  ngOnInit() {
    this.loadContacts();
  }

  paginatedContacts = computed(() => {
    const start = this.currentPage() * this.pageSize();
    const end = start + this.pageSize();
    return this.contacts().slice(start, end);
  });

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

  onPageChange(event: PageEvent) {
    this.currentPage.set(event.pageIndex);
    this.pageSize.set(event.pageSize);
  }
}
