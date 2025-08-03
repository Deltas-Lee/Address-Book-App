import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    MatButtonModule,
    MatIconModule,
    MatCardModule
  ],
  template: `
    <div class="home-container">
      <div class="hero-section">
        <h1 class="hero-title">Address Book</h1>
        <p class="hero-subtitle">A modern contact management application</p>
        <button mat-raised-button color="primary" routerLink="/contacts" class="cta-button">
          <mat-icon>view_list</mat-icon>
          View All Contacts
        </button>
      </div>

      <div class="features-section">
        <mat-card class="feature-card">
          <mat-card-header>
            <mat-icon mat-card-avatar>search</mat-icon>
            <mat-card-title>Search & Filter</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <p>Quickly find contacts by name, email, or location</p>
          </mat-card-content>
        </mat-card>

        <mat-card class="feature-card">
          <mat-card-header>
            <mat-icon mat-card-avatar>view_module</mat-icon>
            <mat-card-title>Grid View</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <p>Responsive card layout that adapts to your screen</p>
          </mat-card-content>
        </mat-card>

        <mat-card class="feature-card">
          <mat-card-header>
            <mat-icon mat-card-avatar>info</mat-icon>
            <mat-card-title>Detailed View</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <p>View complete contact information in modal dialogs</p>
          </mat-card-content>
        </mat-card>
      </div>
    </div>
  `,
  styles: [`
    .home-container {
      max-width: 1200px;
      margin: 0 auto;
      padding: 40px 20px;
    }

    .hero-section {
      text-align: center;
      margin-bottom: 60px;
    }

    .hero-title {
      font-size: 3rem;
      font-weight: 300;
      color: #1e3a8a;
      margin-bottom: 16px;
    }

    .hero-subtitle {
      font-size: 1.25rem;
      color: #616161;
      margin-bottom: 32px;
    }

    .cta-button {
      font-size: 1.1rem;
      padding: 12px 32px;
      background-color: #1e3a8a !important;
    }

    .cta-button mat-icon {
      margin-right: 8px;
    }

    .features-section {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
      gap: 24px;
    }

    .feature-card {
      text-align: center;
    }

    .feature-card mat-icon[mat-card-avatar] {
      background-color: #1e3a8a;
      color: white;
      text-align: center;
      padding-top: 8px;
    }

    @media (max-width: 768px) {
      .hero-title {
        font-size: 2rem;
      }

      .hero-subtitle {
        font-size: 1rem;
      }
    }
  `]
})
export class HomeComponent { }
