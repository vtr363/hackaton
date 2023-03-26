using Microsoft.EntityFrameworkCore;
using comercioLocalAPI.Model;
using comercioLocalAPI;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<ApiContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("ServerConnection")));
builder.Services.AddSqlServer<ApiContext>(builder.Configuration.GetConnectionString("ServerConnection"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
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

app.Run();
