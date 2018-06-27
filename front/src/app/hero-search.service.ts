
import {throwError as observableThrowError,  Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';




import { Hero } from './hero';
import { map, catchError } from 'rxjs/operators';

@Injectable()
export class HeroSearchService {
  constructor(private http: Http) { }

  search(term: string): Observable<Hero[]> {
    const headers = new Headers();
    headers.append('token', 'ASuperSecuredToken');
    const opts = new RequestOptions();
    opts.headers = headers;
    return this.http
      .get(`api/search?name=${term}`, opts).pipe(

        map((r: Response) => r.json() as Hero[]),
        catchError((error: any) => {
          console.error('An friendly error occurred', error);
          return observableThrowError(error.message || error);
        }));
  }
}
