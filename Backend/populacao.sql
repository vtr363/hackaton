-- Insert rows into table 'TableName'
INSERT INTO cliente
( -- columns to insert data into
 [clienteId], [nomeCliente], [responsavelCliente], [cnpj], [Endereço], [cpf], [telefone], [email]
)
VALUES
(
 1, 'Mercadorias da Tia', 'Gabriela' , '12345678912345', 'Rua Leopoldina', '12345678912', '987586684', 'gabiamarantos@gmail.com'),

( 2, 'Banca Noix', 'Pedro', '54321987654321', 'Rua João Gomes', '21987654321', '9854267485', 'jp.1998@gmail.com'),
(
 3, 'Mercado Grande', 'Ana Paula', '87654321543219', 'Rua Gomes Lopes', '65432121987', '9857485426', 'paulana.2023@gmail.com'
)
-- add more rows here
GO

-- Insert rows into table 'TableName'
INSERT INTO fornecedor
( -- columns to insert data into
 [fornecedorId], [cnpj], [contadorVendas], [nomeEmpresa], [nomeResponsavel], [Endereço], [cpf], [telefone], [email]
)
VALUES
(
 1, '12378912345645', 0 , 'Vitão', 'Victor Miguel', 
 'Rua São Pedro', '21981765432','9842674855', 'vtr.miguel@gmail.com'),

(2, '12456378912345', 0 , 'Saca', 'Rodrigo', 
 'Rua Pedro da Aldeia', '28176195432','9874426855', 'magrão@gmail.com'),
(3, '15237891234645', 0 , 'Nagem', 'Mauro', 
 'Rua São Miguel', '26519817432','9848542675', 'm.auro@gmail.com')

GO

INSERT INTO negociacao
( -- columns to insert data into
 [negociacaoId], [fornecedorId], [clienteId], [status], [dataNegociacao]
)
VALUES
(
 1, 3, 1 , 'Concluido', '2023/04/21'),

(2, 2, 3 , 'Interessado', '2023/01/01'),

(3, 1, 2 , 'Concluido', '2022/12/02')

GO

INSERT INTO produto
( -- columns to insert data into
 [produtoId], [nomeProduto], [valorUnitario], [quantidadeProduto], [descricaoProduto], [fornecedorId], [negociacaoId]
)
VALUES
(
 1, 'Tomate', 15 , 300, 'Valor do Kilo', 1, 3),

(2, 'Pão', 1 , 300, 'O melhor e maior do mundo', 2, 2),

(3, 'Yogurte', 6 , 20, 'Unidade de 2L', 3, 1)

GO