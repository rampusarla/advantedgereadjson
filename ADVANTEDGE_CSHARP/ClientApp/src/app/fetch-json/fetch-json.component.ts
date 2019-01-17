import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-json',
  templateUrl: './fetch-json.component.html',
  styleUrls: ['./fetch-json.component.css']
})
export class FetchJsonComponent {
  result: any;
  error: any;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get(baseUrl + 'api/SampleData/GetJsonData').subscribe(
      result => {
        this.result = result;
      },
      error => {
        this.error = error.error;
      }
    );
  }
}
