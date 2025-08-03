import { Component, Input } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';
import { Contact } from '../../models/contact.interface';

@Component({
  selector: 'app-contact-card',
  standalone: true,
  imports: [CommonModule, MatCardModule, MatIconModule],
  templateUrl: './contact-card.html',
  styleUrl: './contact-card.scss'
})
export class ContactCardComponent {
  @Input() contact!: Contact;
  
  getLocation(): string {
    if (this.contact.city && this.contact.province) {
      return `${this.contact.city}, ${this.contact.province}`;
    }
    return this.contact.city || this.contact.province || '';
  }
}