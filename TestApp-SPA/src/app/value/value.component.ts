import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  values: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getData();
  }


  getData() {
    this.http.get('http://localhost:5020/testing/Hello').subscribe(response => {
    this.values = response;
    }, error => {
      console.log(error);
    });
  }

}
