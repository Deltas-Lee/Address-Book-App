import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ContactListComponent } from "./components/contact-list/contact-list";
import { AppToolbar } from './shared/components/app-toolbar/app-toolbar';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ContactListComponent, AppToolbar],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('address-book');
}
