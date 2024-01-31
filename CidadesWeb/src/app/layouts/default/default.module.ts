import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultComponent } from './default.component';
import { HomeComponent } from 'src/app/modules/home/home.component';
import { CidadesComponent } from 'src/app/modules/cidades/cidades.component';
import { EstadosComponent } from 'src/app/modules/estados/estados.component';
import { RouterModule } from '@angular/router';
//import { FlexLayoutModule, FlexModule } from '@angular/flex-layout';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    //FlexLayoutModule,
    SharedModule
  ],
  declarations: [
    DefaultComponent,
    HomeComponent,
    CidadesComponent,
    EstadosComponent
  ]
})
export class DefaultModule { }
