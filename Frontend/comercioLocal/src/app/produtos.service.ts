import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cliente } from './Cliente';
import { Fornecedor } from './Fornecedor';
import { Negociacao } from './Negociacao';
import { Produto } from './Produto';

@Injectable({
  providedIn: 'root'
})
export class ProdutosService {

  apiUrl = "/api/Produto"
  constructor(private http: HttpClient) { }



  addProduto(produto: Produto) {
    return this.http.post(this.apiUrl, produto)
  }

  getProdutos() {
    console.log("foi")
    return this.http.get(this.apiUrl)
  }
}
