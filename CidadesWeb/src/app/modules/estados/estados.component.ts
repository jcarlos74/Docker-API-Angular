import { Component, OnInit } from '@angular/core';
import { Estado } from 'src/app/models/Estado';
import { cidadeService } from 'src/app/services/cidade.service';

@Component({
  selector: 'app-estados',
  templateUrl: './estados.component.html',
  styleUrls: ['./estados.component.css']
})
export class EstadosComponent implements OnInit
{

  ItemsArray: Estado[] = [];

  constructor(private service: cidadeService) { }

  ngOnInit()
  {
      this.service.listaEstados().subscribe((res: Estado[]) => {
      this.ItemsArray = res;
    });
  }

}
