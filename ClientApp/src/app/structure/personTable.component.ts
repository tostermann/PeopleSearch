import { Component } from '@angular/core';
import { Repository } from "../models/repository";
import { Person} from "../models/person.model";


@Component({
    selector: "person-table",
    templateUrl: "personTable.component.html"
})
export class PersonTableComponent {

    constructor(private repo: Repository) { }

    get people(): Person[] {
        return this.repo.people;
    }
}