import { Routes } from '@angular/router';
import { ContactListComponent } from './components/contact-list/contact-list';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'contacts', component: ContactListComponent },
  { path: 'about', component: AboutComponent },
  { path: '**', redirectTo: '' }
];
