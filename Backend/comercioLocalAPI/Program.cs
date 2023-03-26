using Microsoft.EntityFrameworkCore;
using comercioLocalAPI.Model;
using comercioLocalAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<ApiContext>(builder.Configuration.GetConnectionString("ServerConnection"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(p => p
    .AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod()
);


app.MapGet("/cliente", async(ApiContext context) => {
    var clientes = await context.Cliente.ToListAsync();

    return Results.Ok(clientes);
});

app.MapPost("/cliente", async(ApiContext context, Cliente cliente) => 
{
    await context.Cliente.AddAsync(cliente);
    await context.SaveChangesAsync();

    return Results.Ok();
});


app.MapGet("/Fornecedor", async(ApiContext context) => {
    var fornecedores = await context.Fornecedor.ToListAsync();

    return Results.Ok(fornecedores);
});

app.MapPost("/Fornecedor", async(ApiContext context, Fornecedor fornecedor) => 
{
    await context.Fornecedor.AddAsync(fornecedor);
    await context.SaveChangesAsync();

    return Results.Ok();
});

app.MapGet("/Produto", async(ApiContext context) => {
    var produtos = await context.Produto.ToListAsync();

    return Results.Ok(produtos);
});

app.MapPost("/Produto", async(ApiContext context, Produto produto) => 
{
    await context.Produto.AddAsync(produto);
    await context.SaveChangesAsync();

    return Results.Ok();
});

app.MapGet("/Negociacao", async(ApiContext context) => {
    var negociacoes = await context.Negociacao.ToListAsync();

    return Results.Ok(negociacoes);
});

app.MapPost("/Negociacao", async(ApiContext context, Negociacao negociacao) => 
{
    await context.Negociacao.AddAsync(negociacao);
    await context.SaveChangesAsync();

    return Results.Ok();
});

app.Run();
