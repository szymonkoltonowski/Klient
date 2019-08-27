import { Component, OnInit } from '@angular/core';
import {KlientDTO, KlientService, AdresService} from '../app.generated';
import { FormBuilder, FormControl, Validators, FormGroup } from '@angular/forms';
import { MessageService, SelectItem } from 'primeng/api';


@Component({
  selector: 'app-klient',
  templateUrl: './klient.component.html',
  styleUrls: ['./klient.component.css'],
  providers: [MessageService]

})
export class KlientComponent implements OnInit {
  public klients: KlientDTO[] = [];
  router: any;
  model: any = {};
  adres: SelectItem[];
  userform: FormGroup;

  constructor(private klient: KlientService, private adresService: AdresService, private fb: FormBuilder) { }

  ngOnInit() {
    this.userform = this.fb.group({
      firstname: new FormControl('', Validators.required),
      lastname: new FormControl('', Validators.required),
      pesel: new FormControl('', Validators.compose([Validators.required, Validators.minLength(6), Validators.maxLength(11)])),
      adres: new FormControl(''),
    });

    this.klient.getKlienci().subscribe(result => {
      this.klients = result;
    }, error => console.error(error));
    this.getAdreses();

  }
  delete(userId: string): void {
    this.klient.delete(userId).subscribe(() => {
      this.klients = this.klients.filter(del => del.id !== userId);
    });
  }
  edit(userId: string) {
    this.router.navigateByUrl(['/edit', userId]);
    }
  onChange(event) {
    console.log(event);
    this.model.adresId = event.value.id;
  }
  insert() {
    this.klient.createKlient(this.model).subscribe(() => {
      console.log('Utworzono klienta');
      this.getKlienci();
      }, error => {
      console.log(error);
      console.log('Błąd w czasie tworzenia');
    });
  }
  getAdreses(): void {
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
  getKlienci(): void {
    this.klient.getKlienci()
      .subscribe(klient => this.klients = klient);
    }
}
