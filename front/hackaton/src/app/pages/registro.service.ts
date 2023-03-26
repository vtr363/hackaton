import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cliente } from '../Cliente';
import { Fornecedor } from '../Fornecedor';
import { Negociacao } from '../Negociacao';
import { Produto } from '../Produto';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {

  apiUrl = "http://localhost:5094/"
  constructor(private http: HttpClient) { }

  addFornecedor(fornecedor: Fornecedor) {
    return this.http.post(this.apiUrl+"Fornecedor", fornecedor)
  }

  addCliente(cliente: Cliente) {
    return this.http.post(this.apiUrl+"cliente", cliente)
  }

  addNegociacao(negociacao: Negociacao) {
    return this.http.post(this.apiUrl+"Negociacao", negociacao)
  }

  addProduto(produto: Produto) {
    return this.http.post(this.apiUrl+"Produto", produto)
  }

  getProdutos(produtos: Array<Produto>) {

  }
}
