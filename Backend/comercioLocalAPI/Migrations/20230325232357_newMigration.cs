using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace comercioLocalAPI.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Negociacoe_Usuario_usuarioId",
                table: "Negociacoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Negociacoe_NegociacaoId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Usuario_fornecedorusuarioId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "ClienteFornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Produto_fornecedorusuarioId",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "fornecedorusuarioId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Fornecedor");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Negociacoe",
                newName: "FornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Negociacoe_usuarioId",
                table: "Negociacoe",
                newName: "IX_Negociacoe_FornecedorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "NegociacaoId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "FornecedorId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Negociacoe",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nomeResponsavel",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nomeEmpresa",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "endereço",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "contadorVendas",
                table: "Fornecedor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Fornecedor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "FornecedorId",
                table: "Fornecedor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomeResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereço = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_FornecedorId",
                table: "Produto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Negociacoe_ClienteId",
                table: "Negociacoe",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Negociacoe_Cliente_ClienteId",
                table: "Negociacoe",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Negociacoe_Fornecedor_FornecedorId",
                table: "Negociacoe",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Negociacoe_NegociacaoId",
                table: "Produto",
                column: "NegociacaoId",
                principalTable: "Negociacoe",
                principalColumn: "NegociacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Negociacoe_Cliente_ClienteId",
                table: "Negociacoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Negociacoe_Fornecedor_FornecedorId",
                table: "Negociacoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Negociacoe_NegociacaoId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Produto_FornecedorId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Negociacoe_ClienteId",
                table: "Negociacoe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Negociacoe");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "Negociacoe",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Negociacoe_FornecedorId",
                table: "Negociacoe",
                newName: "IX_Negociacoe_usuarioId");

            migrationBuilder.AlterColumn<Guid>(
                name: "NegociacaoId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "fornecedorusuarioId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nomeResponsavel",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nomeEmpresa",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "endereço",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "contadorVendas",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FornecedorId",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "usuarioId",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "usuarioId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Produto_fornecedorusuarioId",
                table: "Produto",
                column: "fornecedorusuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFornecedor_fornecedoresusuarioId",
                table: "ClienteFornecedor",
                column: "fornecedoresusuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Negociacoe_Usuario_usuarioId",
                table: "Negociacoe",
                column: "usuarioId",
                principalTable: "Usuario",
                principalColumn: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Negociacoe_NegociacaoId",
                table: "Produto",
                column: "NegociacaoId",
                principalTable: "Negociacoe",
                principalColumn: "NegociacaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Usuario_fornecedorusuarioId",
                table: "Produto",
                column: "fornecedorusuarioId",
                principalTable: "Usuario",
                principalColumn: "usuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
