import { Component } from '@angular/core';
import { Repository } from "../models/repository";

@Component({
    selector: "searchTerm-filter",
    templateUrl: "searchFilter.component.html"
})
export class SearchtermFilterComponent {

    constructor(private repo: Repository) { }

    getSearchTerm() {
        var userInput: string
    
        userInput = (document.getElementById("searchTerm") as HTMLInputElement).value;
        this.setSearchTerm(userInput);
    }
    setSearchTerm(searchTerm: string) {
        this.repo.filter.search = searchTerm;
        this.repo.getPeople();
    }
}