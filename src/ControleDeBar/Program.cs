public class Program
{
    public static List<Cliente> Clientes = new List<Cliente>();
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Cliente " + i.ToString();
            cliente.Id = i.ToString();
            Clientes.Add(cliente);
        }
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //Minimal API

        //Delegate
        //POnteiro c++
        //Lambda expression 

        app.MapGet("/clientes", TragaClientes);
        app.MapPost("/clientes", AdicionarCliente);
        app.MapPost("/clientes/editar", EditarCliente);
        app.MapPost("/clientes/deletar", DeletarCliente);

        app.Run();
    }

    private static IResult TragaClientes()
    {
        string clientesTabela = string.Empty;
        foreach (var cliente in Clientes)
        {
            string linhaCLiente = $@"
<tr>
    <td> {cliente.Nome}</td>
    <td>{cliente.Id}</td>
    <td>Editar</td>
    <td>Deletar</td>    
</tr>";
            clientesTabela += linhaCLiente;
        }
        string html =
 @$"
<html>
<head>
<title>Meu Primeiro Website</title>
</head>
<body>

<form method='post' action='/clientes'>
    <label for='nome'> Nome: </label>
    <input type='text' id='nome' name='nome' required>
    <button type='submit'> Adicionar Cliente </button>
</form>


<h1>Clientes</h1>

<table>
  <thead>
    <tr>
        <th>Nome</th>
        <th>Id</th>
        <th>Editar</th>
        <th>Deletar</th>
    </tr>
  </thead>

 <tbody>
    {clientesTabela}
 </tbody>
</table>
</body>
</html>
";
        return Results.Text(html, "text/html");
    }

    private static IResult AdicionarCliente(HttpContext httpContext)
    {
        var form = httpContext.Request.Form;
        var nome = form["nome"].ToString();
        var id = Clientes.Count + 1;
        var cliente = new Cliente()
        {
            Nome = nome,
            Id = id.ToString()
        };
        Clientes.Add(cliente);
        return Results.Redirect("/clientes");
    }

    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}
