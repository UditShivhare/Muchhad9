import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllBooksComponent } from './all-books/all-books.component';
import { AddBooksComponent } from './add-books/add-books.component';

@NgModule({
  declarations: [
    AppComponent,
    AllBooksComponent,
    AddBooksComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
