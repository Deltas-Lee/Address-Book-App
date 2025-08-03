import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef, MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';
import { Contact } from '../../models/contact.interface';

@Component({
  selector: 'app-contact-details-dialog',
  standalone: true,
  imports: [
    CommonModule,
    MatDialogModule,
    MatButtonModule,
    MatIconModule
  ],
  templateUrl: './contact-details-dialog.html',
  styleUrl: './contact-details-dialog.scss'
})
export class ContactDetailsDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<ContactDetailsDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Contact
  ) {}

  getLocation(): string {
    const parts = [this.data.city, this.data.province];
    return parts.filter(Boolean).join(', ');
  }

  close() {
    this.dialogRef.close();
  }
}




