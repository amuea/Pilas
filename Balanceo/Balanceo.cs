namespace DefaultNamespace;
using System.Collections.Generic;

public static class Balanceo{

    public static void Run(){
        // {7+(8*5)-[(9-7)+(4+1)]}

        // Definir una pila
        Stack<char> formula = new Stack<char>();

        //string formula = "{7+(8*5)-[(9-7)+(4+1)]}"; 
        Console.WriteLine("ingrese una formula");
        string formula = Console.ReadLine();

        foreach (char simbolo in formula)
        {
            formula.Push(simbolo); // Pasar cada simbolo de la formula a la pila
        }
        imprimirPila(formula);

        int ParentesisAbiertos = 0;
        int ParentesisCerrados = 0;

        while(formula.Count > 0){
            char simbolo = formula.Pop();
            if(simbolo == '('){
                ParentesisAbiertos ++;
            }
            if(simbolo == ')') ParentesisCerrados++;
        }
        
        // Resolver la cantidad de parentesis
        string resultado = ParentesisAbiertos == ParentesisCerrados? "Balanceada": "NO balanceada";
        Console.WriteLine("Formula " + resultado);
    }


    //Recorrer la pila e imprimir los elementos
    static void imprimirPila(Stack<char> pila){
        Console.WriteLine("Elementos de la pila: ");
        foreach (var item in pila) 
        {
            Console.WriteLine(item);
        }
    }
}