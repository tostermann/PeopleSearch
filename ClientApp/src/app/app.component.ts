import { Component } from '@angular/core';
import { Repository } from "./models/repository";
import { Person } from "./models/person.model";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

    constructor(private repro: Repository) { }

    get person(): Person {
        return this.repro.person;
    }

    get people(): Person[] {
        return this.repro.people;
    }
    
 
}
