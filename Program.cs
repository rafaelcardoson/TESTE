using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o pipeline HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Adiciona a rota personalizada para EmpresaCadastro
app.MapControllerRoute(
    name: "empresaCadastro",
    pattern: "EmpresaCadastro",
    defaults: new { controller = "Home", action = "EmpresaCadastro" });

// Adiciona outras rotas conforme necessário
app.MapControllerRoute(
    name: "fornecedorCadastro",
    pattern: "FornecedorCadastro",
    defaults: new { controller = "Home", action = "FornecedorCadastro" });

app.MapControllerRoute(
    name: "marcasCadastro",
    pattern: "MarcasCadastro",
    defaults: new { controller = "Home", action = "MarcasCadastro" });

app.MapControllerRoute(
    name: "clienteCadastro",
    pattern: "ClienteCadastro",
    defaults: new { controller = "Home", action = "ClienteCadastro" });

app.MapControllerRoute(
    name: "produtoCadastro",
    pattern: "ProdutoCadastro",
    defaults: new { controller = "Home", action = "ProdutoCadastro" });

app.MapControllerRoute(
    name: "raqueteCadastro",
    pattern: "RaqueteCadastro",
    defaults: new { controller = "Home", action = "RaqueteCadastro" });

app.MapControllerRoute(
    name: "estoqueCadastro",
    pattern: "EstoqueCadastro",
    defaults: new { controller = "Home", action = "EstoqueCadastro" });

app.MapControllerRoute(
    name: "vendaCadastro",
    pattern: "VendaCadastro",
    defaults: new { controller = "Home", action = "VendaCadastro" });

app.MapControllerRoute(
    name: "encordoamentoCadastro",
    pattern: "encordoamentoCadastro",
    defaults: new { controller = "Home", action = "EncordoamentoCadastro" });

app.MapControllerRoute(
    name: "cordaCadastro",
    pattern: "CordaCadastro",
    defaults: new { controller = "Home", action = "CordaCadastro" });

app.MapControllerRoute(
    name: "consultaCEP",
    pattern: "ConsultaCEP",
    defaults: new { controller = "CEPController", action = "EmpresaCadastro" });



app.Run();

