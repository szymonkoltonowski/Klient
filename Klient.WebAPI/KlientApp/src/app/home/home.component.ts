import { Component, OnInit } from '@angular/core';
import {AdresDTO, AdresService} from '../app.generated'
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: []
})


export class HomeComponent implements OnInit{  
  public adress: AdresDTO[] = [];
  
  constructor(private adres: AdresService) {}

  ngOnInit() {
    this.adres.getAdreses().subscribe(result => {
      this.adress = result;
    }, error => console.error(error));
  }

}
