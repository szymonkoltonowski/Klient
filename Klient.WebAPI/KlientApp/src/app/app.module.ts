import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { KlientService, AdresService } from './app.generated';
import { HttpClientModule } from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { KlientComponent } from './klient/klient.component';
import { KlientEditComponent } from './klient-edit/klient-edit.component';
import { AdresComponent } from './adres/adres.component';
import { AdresEditComponent } from './adres/adres-edit/adres-edit.component';
import { InputTextModule } from 'primeng/inputtext';
import {ButtonModule} from 'primeng/button';
import {DropdownModule} from 'primeng/dropdown';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {TableModule} from 'primeng/table';
import {MessagesModule} from 'primeng/messages';
import {MessageModule} from 'primeng/message';
import {ToastModule} from 'primeng/toast';



@NgModule({
  declarations: [
    AppComponent,
    KlientComponent,
    KlientEditComponent,
    AdresComponent,
    AdresEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    InputTextModule,
    ButtonModule,
    DropdownModule,
    BrowserAnimationsModule,
    TableModule,
    ReactiveFormsModule,
    MessagesModule,
    MessageModule,
    ToastModule
    ],
  providers: [AdresService, KlientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
