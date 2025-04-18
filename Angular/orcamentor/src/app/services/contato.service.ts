import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { ContatoComponent } from '../components/contato/contato.component';
import { Observable } from 'rxjs';


export interface ContatoRequest {
  id: string;
  nome: string;
  email: string;
  numero: string;
}

export interface ContatoResponse {
  id: number;
}

@Injectable({
  providedIn: 'root'
})
export class ContatoService {

  private apiUrl = `${environment.apiUrl}/contatos`;
  constructor(private http: HttpClient ) { }

 obterContatos(): Observable<ContatoComponent[]> {
    return this.http.get<ContatoComponent[]>(this.apiUrl);
  }


  salvar(contato: ContatoRequest): Observable<ContatoResponse> {
    return this.http.post<ContatoResponse>(this.apiUrl, contato);
  }




}
