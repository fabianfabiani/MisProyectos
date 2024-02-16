/*Declarar el tipo de dato abstracto Pelicula, la información requerida es:
Título
Sinopsis
Duración (en segundos)
Géneros (array de strings)
Año de estreno
*/
record Pelicula
{
    public string Titulo { get; set; }
    public string Sinopsis { get; set; }
    public int Duracion { get; set; }
    public string[] Generos { get; set; }
    public int AnioDeEstreno { get; set; }
}
internal class Program
{
    static int PedirInt(string dato) //me retorna un int
    {
        int rta;
        Console.WriteLine($"Ingrese {dato}");
        string rtaString = PedirTextoDuracion(dato);
        while (!int.TryParse(rtaString, out rta) && rta > 0)
        {
            Console.WriteLine($"Respuesta invalida, debe responder un numero mayor a 0 ");
            rtaString = PedirTextoDuracion(dato);
        }

        return rta;
    }
    static string PedirTextoDuracion(string dato) // me retorna un texto
    {
        return Console.ReadLine();
    }

        static string PedirTexto(string dato) // me retorna un texto mayor a 3 caracteres
    {
        Console.Write($"Ingrese {dato}: ");
        string rta = Console.ReadLine();

        while (rta.Length < 3)
        {
            Console.WriteLine($"Respuesta invalida, debe tener al menos 3 caracteres");
            Console.Write($"Ingrese {dato}: ");
            rta = Console.ReadLine();
        }

        return rta;
    }

    /*2 Escriba la función SolicitarLista que no recibe parámetros y retorna un array de strings.
     * La función solicita al usuario indicar cuantos textos desea ingresar, crea un array del tamaño solicitado
     * y luego se pide al usuario que ingrese los valores de cada elemento.*/
    static string[] SolicitarLista ()
    {
        Console.WriteLine("Cuantos textos desea ingresar");
        int Cantidad = int.Parse(Console.ReadLine());
        string[] arr = new string[Cantidad];
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Ingrese el texto para el nº{i+1}");
            arr[i] = Console.ReadLine();
        }
        return arr;
    }
    /*3 Escriba la función SolicitarPelicula que no recibe parámetros y retorna una Película,
     * la función crea  y retorna una nueva película tras solicitar los valores de cada propiedad al usuario;
     * se debe validar que los valores numéricos sean mayores a 0 y los textos con longitud mayor a 3 caracteres.
     * La propiedad Géneros se carga usando la función SolicitarLista*/
    static Pelicula SolicitarPelicula()
    {
        Pelicula p = new Pelicula();
        p.Titulo = PedirTexto("Titulo");
        p.Sinopsis = PedirTexto("Sinopsis");
        p.Duracion = PedirInt("Duracion");
        p.Generos = SolicitarLista();  // Debo cargar un array?
        p.AnioDeEstreno = PedirInt("anio");
        return p;
    }
    /*4 Escriba la función CalcularTTR, esta función recibe como parámetro un array de Películas
     * que llamaremos pelis y retorna un long.
     * El objetivo de esta función es calcular el tiempo total de reproducción de pelis 
     * que es la sumatoria de la duración de todas las películas.
*/
    static long CalcularTTR(Pelicula[] pelis)
{
    long duracionTotal = 0;
    for(int i = 0; i < pelis.Length; i++)
    {
        duracionTotal += pelis[i].Duracion;
    }
    return duracionTotal;
}
    /*Escriba la función SumarCartesiano, esta función recibe como parámetro dos arrays de short
     * a los cuales llamaremos a y b y retorna un valor double.
     * La función calculará la sumatoria de todas las sumas de cada par del producto cartesiano entre a y b.
    */
    static double SumarCartesiano(short[] a, short[] b)
    {
        double total = 0;
        for(int i=0; i<a.Length; i++)
        {
            for(int k=0; k<b.Length; k++)
            {
                total+=a[i]+b[k];
            }
        }
        return total;
    }
    private static void Main(string[] args)
{
    //ejercicio 3
    Pelicula unaPeli = SolicitarPelicula();
    Console.WriteLine($"La pelicula Pedida es {unaPeli.Titulo} {unaPeli.Sinopsis} {unaPeli.Duracion} {unaPeli.AnioDeEstreno}");
    Console.WriteLine(String.Join(',', unaPeli.Generos));
    //

    //ejercicio 4 
    Pelicula[] pelis = new Pelicula[3]
    {
        new Pelicula() {Titulo="terminator", Duracion=65},
        new Pelicula() {Titulo="La llorona", Duracion=45},
        new Pelicula() {Titulo="La momia", Duracion=80},
    };
    long duracionTotalDePelis = CalcularTTR(pelis);
    Console.WriteLine($"La duracion total de todas las peliculas es: {duracionTotalDePelis} minutos");
        //ejercicio 5
        short[] a = new short[] { 4, 5, 3 };
        short[] b = new short[] { 4, 5, 3 };
        double sumarCartesiano = SumarCartesiano(a, b);
        Console.WriteLine($"La suma es de todos los cartesianos es: {sumarCartesiano}");
}
}