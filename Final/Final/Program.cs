
internal class Program
{
    const float NIVEL_MINIMO_TINTA = 1.0f;
    /*1- Declare el tipo de dato Lapicera con los atributos:
     * Marca, Color, Nivel Máximo de tinta y Nivel Actual De tinta.
     * Los dos últimos son de tipo float    */
    record Lapicera
    {
        public string Marca { get; set; }
        public string Color { get; set; }
        public float NivelMaximoDeTinta { get; set; }
        public float NivelActualDeTinta { get; set; }
    }
    static string PedirTexto(string dato, float n)
    {
        string rta;
        Console.WriteLine($"Ingrese {dato}");
        rta = Console.ReadLine();
        while (rta.Length < n)
        {
            Console.WriteLine($"Ingrese {dato}");
            rta = Console.ReadLine();
        }
        return rta;
    }
    static float PedirFloat(string dato, float n)
    {
        float rta;
        string suRta;   
        Console.WriteLine($"Ingrese {dato}");
        suRta = Console.ReadLine();
        while (!float.TryParse(suRta, out rta) || rta < n) //Mientras que suRta no sea un float o si es un float pero es menor a n
        {
            Console.WriteLine($"Ingrese {dato}");
            suRta = Console.ReadLine(); 
        }
        return rta;
    }

    /*2- Escriba la función SolicitarLapicera que no recibe parámetros y retorna una Lapicera.
     * Esta función solicitará al usuario los datos correspondientes a una lapicera, creará una nueva y la retornará.
     * Debe validarse que al momento de indicar nivel máx de tinta, este no puede ser menor a 1, de igual manera,
     * el nivel actual de tinta no puede ser mayor a Nivel máximo de tinta ni menor a 0.    */
    static Lapicera SolicitarLapicera()
    {
        Lapicera l = new Lapicera();
        l.Marca = PedirTexto("Marca", 1);
        l.Color = PedirTexto("Color", 1);
        l.NivelMaximoDeTinta = PedirFloat("Nivel Maximo de Tinta", NIVEL_MINIMO_TINTA);
        l.NivelActualDeTinta = PedirFloat("Nivel Actual de Tinta", NIVEL_MINIMO_TINTA);
        while(l.NivelActualDeTinta > l.NivelMaximoDeTinta && l.NivelActualDeTinta<0)
        {
            l.NivelActualDeTinta= PedirFloat("Nivel Actual de Tinta", NIVEL_MINIMO_TINTA);
        }
        return l;
    }
    /*3- Escriba la función Escribir que recibe como parámetro una lapicera llamada l y una string llamada texto,
    esta función es bool. Cada carácter del texto consume 0.3f del nivel de tinta de la lapicera, solo los espacios en blanco no consumen tinta (el char ‘ ‘).
    Por cada carácter de texto la función debe mostrar en consola el mensaje “Escribiendo {carácter} con una lapicera {color} de marca {marca}”
    y reducir el nivel de tinta actual según corresponda, solo si el nivel actual de tinta alcanza para escribir dicho carácter,
    de lo contrario debe mostrar el mensaje “Nivel de tinta insuficiente para escribir el caracter { carácter} “.
    La función retorna true si pudo escribir todos los caracteres, false de lo contrario.
    Por ejemplo:
    Dada una lapicera roja de marca “vic” con nivel de tinta 1.0f y un texto “hola” la funcion deberia decir:   */
    static bool Escribir ( Lapicera l, string texto)
    {
        //float tintaAGastar = 0;
        int Contador = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            if (l.NivelActualDeTinta >= 0.3f && texto[i]!=' ')
            {
                Console.WriteLine($"Escribiendo {texto[i]} con una lapicera {l.Color} de marca {l.Marca}");
                l.NivelActualDeTinta = l.NivelActualDeTinta - 0.3f;
                Contador++;
            }
            else 
            {
                Console.WriteLine($"Nivel de tinta insuficiente para escribir el caracter {texto[i]}");
            }
        }
        if (Contador==texto.Length)
        {
            return true;
        }
        else
        {
            return false;   
        }

    }
    /*4- Escriba la función Recargar que recibe como parámetro una lapicera, esta función es void y carga el nivel de tinta actual al máximo!
*/
    static void Recargar (Lapicera l)
    {
        l.NivelActualDeTinta = l.NivelMaximoDeTinta;
    }
    private static void Main(string[] args)
    {
        Lapicera l = SolicitarLapicera();
        Console.WriteLine(l);

        Escribir(l, "Ho a");
         
        Recargar(l);
        Console.WriteLine($"Ahora el nivel de tinta esta recargado al maximo: {l.NivelMaximoDeTinta}");
    }

}