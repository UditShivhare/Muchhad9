import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { BookService } from '../book.service';

@Component({
  selector: 'app-add-books',
  templateUrl: './add-books.component.html',
  styleUrl: './add-books.component.css'
})
export class AddBooksComponent implements OnInit {

  public bookForm:FormGroup;
  constructor(private formBuilder : FormBuilder,private service:BookService ){
    this.bookForm =this.formBuilder.group({
      title:[],
      description:[],
      author:[],
      brand:[]
    });
  }

  public saveBook():void{
this.service.addBook(this.bookForm.value).subscribe(result=>
  {
    alert(`New Book added with Id =${result}`);
  });
  }
  
  ngOnInit(): void {
   //this.init();
  }

  // private init():void{
  // this.bookForm =this.formBuilder.group({
  //   title:[],
  //   description:[],
  //   author:[],
  //   brand:[]
  // });
  //}

}
