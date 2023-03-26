import { Fornecedor } from "./Fornecedor"
import { Negociacao } from "./Negociacao"
export interface Produto {
  produtoId: number,
  nomeProduto: string,
  valorUnitario: number,
  quantidadeProduto: number,
  descricaoProduto: string,
  fornecedor: Fornecedor,
  negociacao: Negociacao
}
