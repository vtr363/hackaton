import { Negociacao } from "./Negociacao";

export interface Cliente {
  clienteId?:string,
  nomeCliente:string,
  responsavelCliente:string,
  endereço:string,
  cpf:string,
  cnpj:string,
  telefone: string,
  email:string,
  negociacoes: Array<Negociacao>
}
