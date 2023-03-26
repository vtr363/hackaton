import { Component } from '@angular/core';
import { ProdutosService } from '../produtos.service';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent {
  produtos: any
  constructor(private produtosService: ProdutosService){}

  getProdutos(): void {
    this.produtosService.getProdutos()
        .subscribe(produtos => this.produtos = produtos);
  }

  ngOnInit(): void {
    this.getProdutos();
  }

}
