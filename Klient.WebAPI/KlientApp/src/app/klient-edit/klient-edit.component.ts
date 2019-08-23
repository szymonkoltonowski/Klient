import { Component, OnInit, Input } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import {KlientDTO, KlientService, AdresDTO, AdresService} from '../app.generated';
import { Location } from '@angular/common';

@Component({
  selector: 'app-klient-edit',
  templateUrl: './klient-edit.component.html',
  styleUrls: ['./klient-edit.component.css']
})
export class KlientEditComponent implements OnInit {
  @Input() model: KlientDTO;
  adres: AdresDTO[];
  //public klients: KlientDTO[] = [];
  id: any;
constructor (private service: KlientService, private route: ActivatedRoute, private adresService: AdresService, private location: Location
  ) {}


  ngOnInit() {
  this.getKlient();
  this.getAdres();
  }
  getKlient(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.service.getKlient(this.id)
      .subscribe(model => this.model = model);
  }
  getAdres(): void {
    this.adresService.getAdreses()
      .subscribe(adres => this.adres = adres);
  }
  goBack(): void {
     this.location.back();
   }
  save(): void {
    this.service.updateKlient(this.model, this.id)
      .subscribe(() => this.goBack());
  }
  

}
