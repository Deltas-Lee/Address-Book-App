import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [
    CommonModule,
    MatCardModule,
    MatIconModule
  ],
  template: `
    <div class="about-container">
      <div class="about-header">
        <h1>About Address Book</h1>
        <p class="about-subtitle">A modern contact management application</p>
      </div>

      <div class="about-content">
        <mat-card class="tech-card">
          <mat-card-header>
            <mat-icon mat-card-avatar>web</mat-icon>
            <mat-card-title>Frontend Technologies</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <ul>
              <li><strong>Angular 20</strong> - Latest stable version</li>
              <li><strong>TypeScript</strong> - Type-safe development</li>
              <li><strong>Angular Material</strong> - UI component library</li>
              <li><strong>SCSS</strong> - Enhanced styling</li>
              <li><strong>Signals</strong> - Reactive state management</li>
            </ul>
          </mat-card-content>
        </mat-card>

        <mat-card class="tech-card">
          <mat-card-header>
            <mat-icon mat-card-avatar>storage</mat-icon>
            <mat-card-title>Backend Technologies</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <ul>
              <li><strong>.NET 9</strong> - Web API framework</li>
              <li><strong>Entity Framework Core</strong> - ORM</li>
              <li><strong>SQLite</strong> - Lightweight database</li>
              <li><strong>Swagger</strong> - API documentation</li>
              <li><strong>CORS</strong> - Cross-origin support</li>
            </ul>
          </mat-card-content>
        </mat-card>

        <mat-card class="feature-card">
          <mat-card-header>
            <mat-icon mat-card-avatar>star</mat-icon>
            <mat-card-title>Key Features</mat-card-title>
          </mat-card-header>
          <mat-card-content>
            <ul>
              <li>Responsive grid layout (4-2-1 columns)</li>
              <li>Real-time search and filtering</li>
              <li>Modal contact details view</li>
              <li>Pagination for large datasets</li>
              <li>Mobile-friendly design</li>
              <li>RESTful API architecture</li>
            </ul>
          </mat-card-content>
        </mat-card>
      </div>
    </div>
  `,
  styles: [`
    .about-container {
      max-width: 1200px;
      margin: 0 auto;
      padding: 40px 20px;
    }

    .about-header {
      text-align: center;
      margin-bottom: 40px;
    }

    .about-header h1 {
      font-size: 2.5rem;
      color: #1e3a8a;
      margin-bottom: 16px;
    }

    .about-subtitle {
      font-size: 1.125rem;
      color: #616161;
    }

    .about-content {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
      gap: 24px;
    }

    .tech-card,
    .feature-card {
      height: fit-content;
    }

    .tech-card mat-icon[mat-card-avatar],
    .feature-card mat-icon[mat-card-avatar] {
      background-color: #1e3a8a;
      color: white;
      text-align: center;
      padding-top: 8px;
    }

    ul {
      margin: 0;
      padding-left: 20px;
    }

    li {
      margin-bottom: 8px;
      line-height: 1.5;
    }

    strong {
      color: #1e3a8a;
    }

    @media (max-width: 768px) {
      .about-header h1 {
        font-size: 2rem;
      }

      .about-content {
        grid-template-columns: 1fr;
      }
    }
  `]
})
export class AboutComponent { }
