import { Component, OnInit } from '@angular/core';
import { AdresDTO, AdresService } from 'src/app/app.generated';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

@Component({
  selector: 'app-adres-edit',
  templateUrl: './adres-edit.component.html',
  styleUrls: ['./adres-edit.component.css']
})
export class AdresEditComponent implements OnInit {
 model: AdresDTO;

  id: any;
constructor(private route: ActivatedRoute, private service: AdresService, private location: Location
  ) {}


  ngOnInit() {
  this.getAdres();
  }
  getAdres(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    this.service.getAdres(this.id)
      .subscribe(model => this.model = model);
  }
  goBack(): void {
     this.location.back();
   }
  handleClick() {
    this.service.updateAdres(this.model, this.id)
      .subscribe(() => this.goBack());
  }

}
