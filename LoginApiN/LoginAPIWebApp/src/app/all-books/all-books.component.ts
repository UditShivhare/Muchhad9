import { Component, OnInit } from '@angular/core';
import { BookService } from '../book.service';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-all-books',
  standalone: true,
  imports: [HttpClientModule],
  templateUrl: './all-books.component.html',
  styleUrl: './all-books.component.css'
})
export class AllBooksComponent implements OnInit {
public books:any;
  constructor(private service :BookService){

  }
  ngOnInit(): void {
   this.getBooks();
  }
  private getBooks():void{
    this.service.getBooks().subscribe(result=>{
         this.books = result;
    });
 }
}
