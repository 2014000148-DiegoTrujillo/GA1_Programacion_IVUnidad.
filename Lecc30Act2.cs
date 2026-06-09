internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADEMICOS\nNombre: Diego Trujillo"+
            "\nGrado:IV C"+
            "\nClave: 31");
        int[] edadPersonas=new int [7];
        int cantidadPersonasMayores =0;
        int menoresdeEdad = 0;
        int i  ;

        for ( i = 0; i < edadPersonas.Length; i++)
        {
            Console.Write("Ingrese la edad de la persona " +(i+1)+ ":");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());


            if (edadPersonas[i] >= 18) 
            {
                cantidadPersonasMayores++;
            }
            if (edadPersonas[i] < 18)
            {
                menoresdeEdad++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad " +
            cantidadPersonasMayores);
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas menores de edad " +
            menoresdeEdad);
        Console.WriteLine("La cantidad de personas es: "+i);

    }
}
