import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AllBooksComponent } from './all-books/all-books.component';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,AllBooksComponent,HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'LoginAPIWebApp';
}
