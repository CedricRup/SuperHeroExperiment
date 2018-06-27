import { Injectable } from '@angular/core';
import { Headers, Http, Response, RequestOptions } from '@angular/http';



import { Hero } from './hero';

@Injectable()
export class HeroService {
  private heroesUrl = 'api/hero';  // URL to web api

  constructor(private http: Http) { }

  getHero(name: String): Promise<Hero> {
    const headers = new Headers();
    headers.append('token', 'ASuperSecuredToken');
    const opts = new RequestOptions();
    opts.headers = headers;
    return this.http
      .get(this.heroesUrl + '?name=' + name, opts)
      .toPromise()
      .then((response) => {
        return response.json() as Hero;
      })
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error);
    return Promise.reject(error.message || error);
  }
}
