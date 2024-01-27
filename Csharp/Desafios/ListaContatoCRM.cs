using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int tamanhoLista = int.Parse(Console.ReadLine());

        List<string> listaClientes = new List<string>();

        for (int i = 1; i <= tamanhoLista; i++)
        {
            string cliente = Console.ReadLine();
            listaClientes.Add(cliente);
        }

        Console.WriteLine("\nLista de Contatos:");

        for (int i = 0; i < listaClientes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listaClientes[i]}");
        }
    }
}