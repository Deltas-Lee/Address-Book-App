import { Component, Input, signal } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';
import { Contact } from '../../models/contact.interface';

@Component({
  selector: 'app-contact-card',
  standalone: true,
  imports: [CommonModule, MatCardModule, MatIconModule, MatButtonModule],
  templateUrl: './contact-card.html',
  styleUrl: './contact-card.scss'
})
export class ContactCardComponent {
  @Input() contact!: Contact;
  expanded = signal(false);

  getLocation(): string {
    if (this.contact.city && this.contact.province) {
      return `${this.contact.city}, ${this.contact.province}`;
    }
    return this.contact.city || this.contact.province || '';
  }

  toggleExpanded(event: Event) {
    event.stopPropagation(); // Prevent opening modal when clicking expand
    this.expanded.update(value => !value);
  }

  hasAdditionalInfo(): boolean {
    return !!(this.contact.address || this.contact.zipCode);
  }
}
