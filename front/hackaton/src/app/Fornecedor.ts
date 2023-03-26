export interface Fornecedor {
    id?:string,
    nome:string,
    nomeResponsavel:string,
    endereco:string,
    cnpj:string,
    telefone: number,
    email:string,
    created_at?:string,
    updated_at?:string
}