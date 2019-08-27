import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { KlientEditComponent } from './klient-edit/klient-edit.component';
import { KlientComponent } from './klient/klient.component';
import { AdresComponent } from './adres/adres.component';
import { AdresEditComponent } from './adres/adres-edit/adres-edit.component';


const routes: Routes = [
  { path: '', redirectTo: '/klienci', pathMatch: 'full' },
  { path: 'klienci', component: KlientComponent },
  { path: 'adresy', component: AdresComponent },
  { path: 'klienci/edit/:id', component: KlientEditComponent },
  { path: 'adresy/edit/:id', component: AdresEditComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
