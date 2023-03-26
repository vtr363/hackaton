import { Cliente } from "./Cliente";
import { Fornecedor } from "./Fornecedor";
import { Produto } from "./Produto";

export interface Negociacao {
    negociacaoId: string,
    status: number,
    dataNegociacao: Date,
    produtos: Array<Produto>,
    fornecedor: Fornecedor,
    cliente: Cliente
}
