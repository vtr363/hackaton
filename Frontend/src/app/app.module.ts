import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

//MODULO IMPORTADO
import {HttpClientModule} from '@angular/common/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FornecedorFormComponent } from './Fornecedor/fornecedor-form/fornecedor-form.component';
import { ClienteFormComponent } from './Cliente/cliente-form/cliente-form.component';
import { LoginComponent } from './pages/login/login.component';
import { RegistroComponent } from './pages/registro/registro.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';



@NgModule({
  declarations: [
    AppComponent,
    FornecedorFormComponent,
    ClienteFormComponent,
    LoginComponent,
    RegistroComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //é preciso tbm declarar as importações aqui
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
