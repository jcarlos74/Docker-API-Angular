import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DefaultComponent } from './layouts/default/default.component';
import { HomeComponent } from './modules/home/home.component';
import { CidadesComponent } from './modules/cidades/cidades.component';
import { EstadosComponent } from './modules/estados/estados.component';
import { FullwidthComponent } from './layouts/fullwidth/fullwidth.component';
import { LoginComponent } from './modules/login/login.component';

const routes: Routes = [{
  path: '',
  component: DefaultComponent,
  children: [
    { path: '', component: HomeComponent },
    { path: 'cidades', component: CidadesComponent },
    { path: 'estados', component: EstadosComponent }
  ]
},
{
  path: '', component: FullwidthComponent,
  children: [
    { path: 'login', component: LoginComponent }
  ]
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
