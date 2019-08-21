import { Component, OnInit } from '@angular/core';
import {KlientDTO, KlientService} from '../app.generated'
import {Router} from '@angular/router';


@Component({
  selector: 'app-klient',
  templateUrl: './klient.component.html',
  styleUrls: ['./klient.component.css']

})
export class KlientComponent implements OnInit {
  public klients: KlientDTO[] = [];
  router: any;

  constructor(private klient: KlientService, router: Router) { }

  ngOnInit() {
    this.klient.getKlienci().subscribe(result => {
      this.klients = result;
    }, error => console.error(error));
  }
  delete(userId:string):void{
    this.klient.delete(userId).subscribe(d=>{
      this.klients=this.klients.filter(del=>del.id!==userId)      
    })
  }
  Edit(userId:string){
    this.router.navigateByUrl(['/edit', userId]);

    }
}
