using System;

class Pessoa {
    public string Nome { get; }
    public int Idade { get; }
    
    public Pessoa(string n, int i) {
        Nome = n;
        Idade = i;
    }
}

class Program {
    static void Main() {
        string nomeDigitado = Console.ReadLine();
        int idadeDigitada = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nomeDigitado, idadeDigitada);
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
    }
}
