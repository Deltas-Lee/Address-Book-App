import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, delay, mergeMap, Observable, of, retry, retryWhen, throwError } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { Contact, ContactResponse } from '../../models/contact.interface';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  private readonly apiUrl = `${environment.apiUrl}/contacts`;

  constructor(private http: HttpClient) { }

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this.apiUrl).pipe(
      retry({
        count: 2,
        delay: 1000
      }),
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {
    let errorMessage = 'An unknown error occurred!';

    if (error.error instanceof ErrorEvent) {
      errorMessage = `Client Error: ${error.error.message}`;
    }
    else {
      if (error.status === 0) {
        errorMessage = `Unable to connect to the server. Please ensure the server is running on ${environment.apiUrl}.`;
      } else if (error.status === 404) {
        errorMessage = `Contacts endpoint not found. Please check the API configuration.`;
      } else if (error.status >= 500) {
        errorMessage = `Server error (${error.status}). Please try again later.`;
      } else {
        errorMessage = `Error: ${error.status}\nMessage: ${error.message}`;
      }
    }
    return throwError(() => new Error(errorMessage));
  }
}
