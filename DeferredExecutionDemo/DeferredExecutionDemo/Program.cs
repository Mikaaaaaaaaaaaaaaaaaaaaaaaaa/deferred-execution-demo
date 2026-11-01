public class Producto
    {

    public string Nombre { get; set; } = "";
    public int Precio { get; set; }

    public static void Main(string[] args)
        {

        string resultado = Consultar();
        Console.WriteLine(resultado);
    }

    public static string Consultar()
        {

        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Mouse", Precio = 15000 },
            new Producto { Nombre = "Teclado", Precio = 30000 },
            new Producto { Nombre = "Monitor", Precio = 120000 },
            new Producto { Nombre = "Auriculares", Precio = 25000 }
        };

        var consulta = from p in productos
                       where p.Precio >= 25000
                       orderby p.Nombre
                       select p.Nombre;

        productos.Add(new Producto
            {
            Nombre = "Webcam",
            Precio = 40000
            });

        string resultado = "";
        foreach (string nombre in consulta)
            {
            resultado += $"{nombre}; ";
            }

        return resultado;
        }
    }