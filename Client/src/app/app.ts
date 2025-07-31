import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AddressBook } from "./components/address-book/address-book";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, AddressBook],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('address-book');
}
