import { Injectable } from '@angular/core'
import { HttpClientModule, HttpClient } from '@angular/common/http'
import { Cidade } from './../models/cidade'
import { Estado } from '../models/Estado'
import { environment } from 'src/environments/environment'
import { Observable } from 'rxjs'

@Injectable({ providedIn: 'root' })
export class cidadeService
{
    _urlApi = environment.url_api;
    _httpClient: HttpClient;

    constructor(private client: HttpClient)
    {
        this._httpClient = client;
    }

   listaEstados(): Observable<any[]> {
    return this._httpClient.get<any[]>(this._urlApi+'States/GetAll');
  }


   listaCidades() : Observable<Cidade[]>
   {
      return this._httpClient.get<Cidade[]>(this._urlApi+'Cities/GetAll');
   }
}
