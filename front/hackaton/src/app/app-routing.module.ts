import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { RegistroComponent } from './pages/registro/registro.component';
import { FornecedorFormComponent } from './Fornecedor/fornecedor-form/fornecedor-form.component';
import { ClienteFormComponent } from './Cliente/cliente-form/cliente-form.component';
import { ClientePerfilComponent } from './Cliente/cliente-perfil/cliente-perfil.component';

const routes: Routes = [
  {path:'',component:LoginComponent},
  {path:'registro',component:RegistroComponent},
  {path: 'cadastrarFornecedor',component:FornecedorFormComponent},
  {path:'cadastrarCliente',component: ClienteFormComponent},
  {path: 'perfilCliente', component: ClientePerfilComponent}
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
