import { Component, OnInit } from '@angular/core';
import { AdresService, AdresDTO } from '../app.generated';
import { Router } from '@angular/router';
import { FormBuilder, FormControl, Validators, FormGroup } from '@angular/forms';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-adres',
  templateUrl: './adres.component.html',
  styleUrls: ['./adres.component.css'],
  providers: [MessageService]
})
export class AdresComponent implements OnInit {
  public adress: AdresDTO[] = [];
  router: any;
  model: any = {};
  id: any;
  adresform: FormGroup;


  constructor(private adres: AdresService, router: Router, private fb: FormBuilder, private messageService: MessageService) {}

  ngOnInit() {
    this.adresform = this.fb.group({
      miasto: new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
      ulica: new FormControl('', Validators.compose([Validators.required, Validators.minLength(3)])),
      nrMieszkania: new FormControl(''),
      nrDomu: new FormControl('', Validators.required),

  });

    this.adres.getAdreses().subscribe(result => {
      this.adress = result;
    }, error => console.error(error));
  }
  delete(userId: string): void {
    this.adres.delete(userId).subscribe(d => {
      this.adress = this.adress.filter(del => del.id !== userId);
    });
  }
  edit(userId: string) {
    this.router.navigateByUrl(['/edit', userId]);

  }
  getAdreses(): void {
    this.adres.getAdreses()
      .subscribe(adres => this.adress = adres);
  }
  submit() {
    this.adres.createAdres(this.model).subscribe(next => {
      console.log('Utworzono adres');
      this.getAdreses();
      }, error => {
      console.log(error);
      console.log('Błąd w czasie tworzenia');
    });
  }
}
