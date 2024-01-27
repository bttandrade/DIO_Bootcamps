using System;

class Personagem {
    public string Nome { get; }
    public int Mana { get; }

    public Personagem(string nome, int mana) {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem {
    public int DanoBase { get; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana) {
        DanoBase = danoBase;
    }

    public void CalcularDano() =>
        Console.WriteLine($"{Nome} atacou e causou {DanoBase * Mana} de dano!");
}

class Program {
    static void Main() {
        string nome = Console.ReadLine();
        int mana = int.Parse(Console.ReadLine());
        int danoBase = int.Parse(Console.ReadLine());

        Subclasse subclasse = new Subclasse(nome, mana, danoBase);
        subclasse.CalcularDano();
    }
}
