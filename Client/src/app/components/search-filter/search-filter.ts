import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';

export interface SearchFilterEvent {
  searchTerm: string;
  selectedProvince: string;
}
@Component({
  selector: 'app-search-filter',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatIconModule,
    MatButtonModule
  ],
  templateUrl: './search-filter.html',
  styleUrl: './search-filter.scss'
})
export class SearchFilterComponent {
  @Input() provinces: string[] = [];
  @Output() filterChange = new EventEmitter<SearchFilterEvent>();

  searchTerm = '';
  selectedProvince = '';

  emitFilterChange() {
    this.filterChange.emit({
      searchTerm: this.searchTerm,
      selectedProvince: this.selectedProvince
    });
  }

  onSearchChange() {
    this.emitFilterChange();
  }

  onFilterChange() {
    this.emitFilterChange();
  }

  clearFilters() {
    this.searchTerm = '';
    this.selectedProvince = '';
    this.filterChange.emit({
      searchTerm: '',
      selectedProvince: ''
    });
  }
}
