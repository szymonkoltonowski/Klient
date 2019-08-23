import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { KlientService, AdresService } from './app.generated';
import { HttpClientModule } from '@angular/common/http'; 
import { FormsModule } from '@angular/forms';
import { KlientComponent } from './klient/klient.component';
import { KlientInsertComponent } from './klient-insert/klient-insert.component';
import { KlientEditComponent } from './klient-edit/klient-edit.component';
import { AdresComponent } from './adres/adres.component';
import { AdresInsertComponent } from './adres/adres-insert/adres-insert.component';
import { AdresEditComponent } from './adres/adres-edit/adres-edit.component';


@NgModule({
  declarations: [
    AppComponent,
    KlientComponent,
    KlientInsertComponent,
    KlientEditComponent,
    AdresComponent,
    AdresInsertComponent,
    AdresEditComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [AdresService, KlientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
