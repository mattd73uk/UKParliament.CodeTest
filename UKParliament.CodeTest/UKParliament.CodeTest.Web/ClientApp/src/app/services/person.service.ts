import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Person } from './../models/person';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

  constructor(private http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
  }

  getPeople(): Observable<Person[]> {
    return this.http.get<Person[]>(this.baseUrl + 'api/person');
  }

  delete(id: number): Observable<number> {
    return this.http.get<number>(this.baseUrl + 'api/person/delete/' + id);
  }

  update(person: Person): Observable<Person> {
    return this.http.post<Person>(this.baseUrl + 'api/person/update', person);
  }


  add(person: Person): Observable<Person> {
    return this.http.post<Person>(this.baseUrl + 'api/person/add', person);
  }

}
