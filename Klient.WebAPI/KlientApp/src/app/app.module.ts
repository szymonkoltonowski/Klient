import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { KlientService, AdresService } from './app.generated';
import { HttpClientModule } from '@angular/common/http'; 
import { FormsModule } from '@angular/forms';
import { KlientComponent } from './klient/klient.component';
import { KlientInsertComponent } from './klient-insert/klient-insert.component';
import { KlientEditComponent } from './klient-edit/klient-edit.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    KlientComponent,
    KlientInsertComponent,
    KlientEditComponent
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
