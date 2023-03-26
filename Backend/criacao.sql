create table negociacao (negociacaoId INT PRIMARY KEY,
                        fornecedorId INT,
                        clienteId INT,
                           status varchar(15),
                         dataNegociacao DATE,
                         foreign key(fornecedorId) REFERENCES fornecedor(fornecedorId),
                         foreign key(clienteId) REFERENCES cliente(clienteId)
                         );
create table produto (produtoId INT PRIMARY key ,
                      nomeProduto VARCHAR (30) NOT NULL,
                      valorUnitario NUMERIC,
                      quantidadeProduto INT,
                      descricaoProduto VARCHAR(100),

                      );

create table fornecedor (fornecedorId INT NOT NULL primary key,
                         cnpj CHAR(18),
                         contadorVendas INT,
                         nomeEmpresa VARCHAR (80),
                         nomeResponsavel varchar (80),
                         Endereço VARCHAR(120),
                         cpf char(14),
                         telefone CHAR (14),
                         email char(60)
                        );

create table cliente     (clienteId INT NOT NULL primary key,
                         nomeCliente VARCHAR (80),
                           responsavelCliente VARCHAR(80),
                           cnpj char(14) not null,
                         Endereço VARCHAR(120),
                         cpf char(14),
                         telefone CHAR (14),
                         email char(60)
                        );

create table negociacao (negociacaoId INT PRIMARY KEY,
                        fornecedorId INT,
                        clienteId INT,
                           status varchar(15),
                         dataNegociacao DATE,
                         foreign key(fornecedorId) REFERENCES fornecedor(fornecedorId),
                         foreign key(clienteId) REFERENCES cliente(clienteId)
                         );