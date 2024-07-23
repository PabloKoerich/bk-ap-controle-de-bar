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

        app.Run();
    }

    private static IResult TragaClientes()
    {
        string clientesTabela = string.Empty;
        foreach (var cliente in Clientes)
        {
            string linhaCLiente = $"<tr><td> {cliente.Nome}</td><td>{cliente.Id}</td></tr>";
            clientesTabela += linhaCLiente;
        }
        string html =
 @$"
<html>
<head>
<title>Meu Primeiro Website</title>
</head>
<body>
<h1>Clientes</h1>

<table>
  <thead>
    <tr>
        <th>Nome</th>
        <th>Id</th>
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

    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}
