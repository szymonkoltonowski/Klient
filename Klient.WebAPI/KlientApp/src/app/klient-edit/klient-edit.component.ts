import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import {KlientDTO, KlientService} from '../app.generated'


@Component({
  selector: 'app-klient-edit',
  templateUrl: './klient-edit.component.html',
  styleUrls: ['./klient-edit.component.css']
})
export class KlientEditComponent implements OnInit {
  public klients: KlientDTO[] = [];
  id: any;
  constructor(private router: Router, private route: ActivatedRoute, private api: KlientService) { }
  // editKlient(userId){
  //   this.route.params.subscribe(params=>{
  //     this.klients=this.klients.filter(del=>del.id!==userId)    
  //   })
  // }


  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');

  }
  

}
