using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string nome = Console.ReadLine();

            string email = Console.ReadLine();

            string telefone = Console.ReadLine();
            
            Console.WriteLine("Contato adicionado!");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("E-mail: " + email);
            Console.WriteLine("Tel: " + telefone);
            break;
        }
    }
}