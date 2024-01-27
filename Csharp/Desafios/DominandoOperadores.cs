using System;

class Program {
    static void Main() {
        string titulo = Console.ReadLine();
        string descricao = Console.ReadLine();

        if (descricao.Length > 50)
        Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        else {
        String dataVencimento = Console.ReadLine();
        Console.WriteLine($"{descricao} ate {dataVencimento}");
        }
    }
}