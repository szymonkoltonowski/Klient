import { Component, OnInit, Input } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import {KlientDTO, KlientService, AdresDTO, AdresService} from '../app.generated';
import { Location } from '@angular/common';
import {SelectItem} from 'primeng/api';

@Component({
  selector: 'app-klient-edit',
  templateUrl: './klient-edit.component.html',
  styleUrls: ['./klient-edit.component.css']
})
export class KlientEditComponent implements OnInit {
  model: KlientDTO;
  adres: SelectItem[];
  id: any;
  constructor(private service: KlientService, private route: ActivatedRoute,
              private adresService: AdresService, private location: Location) { }


  ngOnInit() {
    this.getKlient();
    this.getAdres();
  }
  getKlient(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.service.getKlient(this.id)
      .subscribe(model => {
        this.model = model;
      });

  }
  getAdres(): void {
    this.adresService.getAdreses()
      .subscribe(adres => {
        this.adres = adres.map(a => {
          const selectItem = {
            value: a.id,
            label: a.pelnyAdres
          };
          return selectItem;
        });
      });
  }
  goBack(): void {
     this.location.back();
   }

  onChange(event) {
    console.log(event);
    this.model.adresId = event.value.id;
  }
  handleClick() {
    this.service.updateKlient(this.model, this.id)
      .subscribe(() => this.goBack());
  }
}
