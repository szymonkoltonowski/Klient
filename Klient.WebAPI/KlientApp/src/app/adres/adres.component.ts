import { Component, OnInit } from '@angular/core';
import { AdresService, AdresDTO } from '../app.generated';

@Component({
  selector: 'app-adres',
  templateUrl: './adres.component.html',
  styleUrls: ['./adres.component.css']
})
export class AdresComponent implements OnInit {
  public adress: AdresDTO[] = [];
  
  constructor(private adres: AdresService) {}

  ngOnInit() {
    this.adres.getAdreses().subscribe(result => {
      this.adress = result;
    }, error => console.error(error));
  }


}
