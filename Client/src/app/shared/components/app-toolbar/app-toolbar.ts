import { Component, Input } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';

@Component({
  selector: 'app-toolbar',
  standalone: true,
  imports: [MatToolbarModule, MatIconModule],
  templateUrl: './app-toolbar.html',
  styleUrl: './app-toolbar.scss'
})
export class AppToolbar {
  @Input() title: string = 'Address Book';
}
