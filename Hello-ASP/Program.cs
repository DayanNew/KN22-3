var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Lamda Ausdruck. Anonyme-Methode
app.MapGet("/ search", (string query) => $"Suchergebnis = '{query}'");
app.MapGet("/customer", () =>{
    if(true){
        return "CustomerList";
    }
    return "No Customers found";
});

app.MapGet ("/customer/{ID}", (int id) => $"Customer {id}");

app.Run();

