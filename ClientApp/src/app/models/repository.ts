import { Person } from "./person.model";
import { Injectable } from "@angular/core"
import { HttpClient } from '@angular/common/http';
import { Filter } from "./configClasses.repository";

const peopleUrl = "/api/people"

@Injectable()
export class Repository {
    person: Person;
    people: Person[]
    filter: Filter = new Filter();

    constructor(private http: HttpClient) {
        this.filter.search = "";
        this.getPeople() 
      //this.person = JSON.parse(document.getElementById("data").textContent);
    }

    getProduct(id: number) {
        this.http.get<Person>(`${peopleUrl}/${id}`)
            .subscribe(p => this.person = p);
    }

    getPeople() {
        let url = `${peopleUrl}`;

        if (this.filter.search) {
            url += `?search=${this.filter.search}`;
        }

        this.http.get<Person[]>(url)
            .subscribe(peps => this.people = peps);
    }
    
}