import { Person } from "./person.model";
import { Injectable } from "@angular/core"
import { HttpClient } from '@angular/common/http';

const peopleUrl = "/api/people"

@Injectable()
export class Repository {
    person: Person;
    people: Person[]
    constructor(private http: HttpClient) {
        this.getPeople() 
      //this.person = JSON.parse(document.getElementById("data").textContent);
    }

    getProduct(id: number) {
        this.http.get<Person>(`${peopleUrl}/${id}`)
            .subscribe(p => this.person = p);
    }

    getPeople() {
        this.http.get<Person[]>(`${peopleUrl}`)
            .subscribe(peps => this.people = peps);
    }
    
}