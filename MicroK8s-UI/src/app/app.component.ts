import { Component, Inject } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

interface DataModel {
  id: number;
  name: string;
  code: string;
}
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'MicroK8s-UI';
  countryUrl: string;
  countryList: DataModel[];

  portUrl: string;
  portList: DataModel[];

  showErrorMessage = false;
  errorMessage: string;
  constructor(@Inject('BACKEND_API_URL') private baseUrl: string, private http: HttpClient) {
    this.countryUrl = 'countries';
    this.loadCountryList(this.countryUrl)
      .subscribe(data => this.countryList = data,
        err => { this.showErrorMessage = true; this.errorMessage = err; });
    this.portUrl = 'ports';
    this.loadCountryList(this.portUrl)
      .subscribe(data => this.portList = data,
        err => { this.showErrorMessage = true; this.errorMessage = err; });
  }
  private handleError(error: HttpErrorResponse) {
    let errorMessage = 'Something bad happened; please try again later.';
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      errorMessage = 'An error occurred:' + error.error.message;
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      errorMessage =
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`;
    }
    // Return an observable with a user-facing error message.
    return throwError(errorMessage);
  }
  loadCountryList(apiController: string): Observable<DataModel[]> {
    const fullUrl = `${this.baseUrl}/${apiController}`;
    return this.http.get<DataModel[]>(fullUrl)
      .pipe(
        catchError(this.handleError)
      );
  }

}
