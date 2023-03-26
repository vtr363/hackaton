using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace comercioLocalAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomeResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endereço = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FornecedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    contadorVendas = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                });

            migrationBuilder.CreateTable(
                name: "ClienteFornecedor",
                columns: table => new
                {
                    clientesusuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fornecedoresusuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteFornecedor", x => new { x.clientesusuarioId, x.fornecedoresusuarioId });
                    table.ForeignKey(
                        name: "FK_ClienteFornecedor_Usuario_clientesusuarioId",
                        column: x => x.clientesusuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId");
                    table.ForeignKey(
                        name: "FK_ClienteFornecedor_Usuario_fornecedoresusuarioId",
                        column: x => x.fornecedoresusuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Negociacoe",
                columns: table => new
                {
                    NegociacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idFornecedor = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negociacoe", x => x.NegociacaoId);
                    table.ForeignKey(
                        name: "FK_Negociacoe_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valorProuto = table.Column<double>(type: "float", nullable: false),
                    quantidadeProduto = table.Column<int>(type: "int", nullable: false),
                    descricaoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idFornecedor = table.Column<int>(type: "int", nullable: false),
                    fornecedorusuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idNegociacao = table.Column<int>(type: "int", nullable: false),
                    NegociacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produto_Negociacoe_NegociacaoId",
                        column: x => x.NegociacaoId,
                        principalTable: "Negociacoe",
                        principalColumn: "NegociacaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Usuario_fornecedorusuarioId",
                        column: x => x.fornecedorusuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFornecedor_fornecedoresusuarioId",
                table: "ClienteFornecedor",
                column: "fornecedoresusuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Negociacoe_usuarioId",
                table: "Negociacoe",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_fornecedorusuarioId",
                table: "Produto",
                column: "fornecedorusuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_NegociacaoId",
                table: "Produto",
                column: "NegociacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteFornecedor");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Negociacoe");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
