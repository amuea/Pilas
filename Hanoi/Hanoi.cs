namespace DefaultNamespace;

public static class Hanoi{

    static Stack<int> torre_a = new Stack<int>();
    static Stack<int> torre_b = new Stack<int>();
    static Stack<int> torre_c = new Stack<int>();

    
    public static void Ejecutar(){
        InicializarHanoi(); // Eliminar datos en las torres de Hanoi
        Console.Write("ingrese los discos que contiene las torres de Hanoi");
        int NumDiscos = int.Parse(Console.ReadLine());

        for (int i = NumDiscos; i >=1 ; i--){ 
            torre_a.Push(i);
        }
        TrazarHanoi();

        Resolver(NumDiscos, torre_a, torre_c, torre_b);
    }

    static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar){
        if (n == 1)
        {
            Trasladar(origen, destino);
            TrazarHanoi();
        }
        else{
            // Utilizar recursividad
            Resolver(n-1, origen, auxiliar, destino);
            Trasladar(origen, destino);
            
            TrazarHanoi();
            Resolver(n-1, auxiliar, destino, origen);
        }
    }

    // Trasladar un disco desde el origen hacia el destino de una torre a otra
    static void Trasladar(Stack<int> origen, Stack<int> destino){
        destino.Push(origen.Pop());
    }

    static void TrazarHanoi(){
        Console.WriteLine("Estado de las torres de Hanoi:");
        Console.WriteLine("Torre a: {0}", string.Join(", ", torre_a.Reverse()));
        Console.WriteLine("Torre b: {0}", string.Join(", ", torre_b.Reverse()));
        Console.WriteLine("Torre c: {0}", string.Join(", ", torre_c.Reverse()));
        Console.WriteLine(new string('*',30));
    }

    static void InicializarHanoi(){
        // Borrar el contenido de las torres de Hanoi
        torre_a.Clear();
        torre_b.Clear();
        torre_c.Clear();
    }
}