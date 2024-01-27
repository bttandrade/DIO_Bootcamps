using System;

class Personagem {
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Personagem(string nome, string raca, string classe) {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public override string ToString() =>
        $"Status:\nNome:{Nome}\nRaça:{Raca}\nClasse:{Classe}\nNível:{Nivel}\nVida:{Vida}";
}

class Program {
    static void Main() {
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();

        Personagem personagem = new Personagem(nome, raca, classe);
        Console.WriteLine(personagem);
    }
}
