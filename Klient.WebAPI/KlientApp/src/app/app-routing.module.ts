import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { KlientEditComponent } from './klient-edit/klient-edit.component';


const routes: Routes = [
  { path: 'edit/:id', component: KlientEditComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
