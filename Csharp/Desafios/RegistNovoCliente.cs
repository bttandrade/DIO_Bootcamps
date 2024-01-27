using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<(string Nome, string Email, string Telefone)> clientes = new List<(string, string, string)>();

        while (true)
        {
            string nome = Console.ReadLine();

            string email = Console.ReadLine();

            string telefone = Console.ReadLine();

            clientes.Add((nome, email, telefone));

            string continuar = Console.ReadLine();

            if (continuar.ToUpper() != "S")
            {
                break;
            }
        }
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"{cliente.Nome}, {cliente.Email}, {cliente.Telefone}");
        }
    }
}
