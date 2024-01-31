import { Component, OnInit } from '@angular/core';
import { Cidade } from 'src/app/models/cidade';
import { cidadeService } from 'src/app/services/cidade.service';

@Component({
  selector: 'app-cidades',
  templateUrl: './cidades.component.html',
  styleUrls: ['./cidades.component.css']
})
export class CidadesComponent implements OnInit {

   ItemsArray: Cidade[] = [];

  constructor(private service: cidadeService) { }

  ngOnInit()
  {
      this.service.listaCidades().subscribe((res: Cidade[]) => {
      this.ItemsArray = res;
    });
  }

}
