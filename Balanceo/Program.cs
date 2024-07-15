namespace DefaultNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ingrese una formula:");
        string formula = Console.ReadLine();

        // Verificar la formula en la clase Balanceo
        string resultado = Balanceo(formula);

        // Mostrar el resultado
        Console.WriteLine("Formula " + resultado);
    }
}