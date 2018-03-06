import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Hero } from './hero';

@Injectable()
export class HeroSearchService {
  constructor(private http: Http) { }

  search(term: string): Observable<Hero[]> {
    const headers = new Headers();
    headers.append('token', 'ASuperSecuredToken');
    const opts = new RequestOptions();
    opts.headers = headers;
    return this.http
      .get(`api/search?name=${term}`, opts)
      .map((r: Response) => r.json() as Hero[])
      .catch((error: any) => {
          console.error('An friendly error occurred', error);
          return Observable.throw(error.message || error);
      });
  }
}
