import { Component, OnInit } from '@angular/core';
import { KlientService} from '../app.generated'

@Component({
  selector: 'app-klient-insert',
  templateUrl: './klient-insert.component.html',
  styleUrls: ['./klient-insert.component.css']
})
export class KlientInsertComponent implements OnInit {
  model: any = {};

  constructor(private klientService : KlientService) { }

  ngOnInit() {
  }
  insert() {
    this.klientService.createKlient(this.model).subscribe(next => {
      console.log('Utworzono klienta');
    }, error => {
      console.log(error);
      console.log('Błąd w czasie tworzenia');
    });
  }
  refresh(): void {
    window.location.reload();
}

}
