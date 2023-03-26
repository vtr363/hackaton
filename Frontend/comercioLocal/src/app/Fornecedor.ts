import { Negociacao } from "./Negociacao"
import { Produto } from "./Produto"
export interface Fornecedor {
  fornecedorId?:string,
  nomeEmpresa:string,
  nomeResponsavel:string,
  endereço:string,
  cnpj:string,
  telefone: number,
  email:string,
  cpf: string,
  contadorVendas: number,
  negociacoes?: Array<Negociacao>
  produtos?: Array<Produto>
}
