using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace comercioLocalAPI.Migrations
{
    /// <inheritdoc />
    public partial class newMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Negociacoe_Cliente_ClienteId1",
                table: "Negociacoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Negociacoe_Fornecedor_FornecedorId1",
                table: "Negociacoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId1",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Negociacoe_NegociacaoId1",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_FornecedorId1",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_NegociacaoId1",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Negociacoe_ClienteId1",
                table: "Negociacoe");

            migrationBuilder.DropIndex(
                name: "IX_Negociacoe_FornecedorId1",
                table: "Negociacoe");

            migrationBuilder.DropColumn(
                name: "FornecedorId1",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NegociacaoId1",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Negociacoe");

            migrationBuilder.DropColumn(
                name: "FornecedorId1",
                table: "Negociacoe");

            migrationBuilder.AlterColumn<Guid>(
                name: "NegociacaoId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "FornecedorId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "FornecedorId",
                table: "Negociacoe",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Negociacoe",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_FornecedorId",
                table: "Produto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_NegociacaoId",
                table: "Produto",
                column: "NegociacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Negociacoe_ClienteId",
                table: "Negociacoe",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Negociacoe_FornecedorId",
                table: "Negociacoe",
                column: "FornecedorId");

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

            migrationBuilder.DropIndex(
                name: "IX_Produto_FornecedorId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_NegociacaoId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Negociacoe_ClienteId",
                table: "Negociacoe");

            migrationBuilder.DropIndex(
                name: "IX_Negociacoe_FornecedorId",
                table: "Negociacoe");

            migrationBuilder.AlterColumn<int>(
                name: "NegociacaoId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FornecedorId1",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NegociacaoId1",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Negociacoe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Negociacoe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId1",
                table: "Negociacoe",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FornecedorId1",
                table: "Negociacoe",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_FornecedorId1",
                table: "Produto",
                column: "FornecedorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_NegociacaoId1",
                table: "Produto",
                column: "NegociacaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Negociacoe_ClienteId1",
                table: "Negociacoe",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Negociacoe_FornecedorId1",
                table: "Negociacoe",
                column: "FornecedorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Negociacoe_Cliente_ClienteId1",
                table: "Negociacoe",
                column: "ClienteId1",
                principalTable: "Cliente",
                principalColumn: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Negociacoe_Fornecedor_FornecedorId1",
                table: "Negociacoe",
                column: "FornecedorId1",
                principalTable: "Fornecedor",
                principalColumn: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId1",
                table: "Produto",
                column: "FornecedorId1",
                principalTable: "Fornecedor",
                principalColumn: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Negociacoe_NegociacaoId1",
                table: "Produto",
                column: "NegociacaoId1",
                principalTable: "Negociacoe",
                principalColumn: "NegociacaoId");
        }
    }
}
