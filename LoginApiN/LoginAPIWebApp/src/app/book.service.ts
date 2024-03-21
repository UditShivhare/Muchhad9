import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private basepath ='http://localhost:5064/api/Book';
  constructor(private http:HttpClient) { }

  public getBooks():Observable<any>{
    return this.http.get(this.basepath);
  }
}
