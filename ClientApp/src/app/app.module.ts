import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModelModule } from "./models/model.module";
import { PersonTableComponent } from "./structure/personTable.component"
import { SearchtermFilterComponent } from "./structure/searchFilter.component"

@NgModule({
  declarations: [
    AppComponent,PersonTableComponent,SearchtermFilterComponent
  ],
  imports: [
    BrowserModule,
      AppRoutingModule,
      ModelModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
