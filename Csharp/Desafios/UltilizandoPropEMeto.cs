using System;

class Robo {
    public int VelocidadeAtual { get; private set; } = 0;

    public Robo(int velocidadeMinima, int velocidadeMaxima) {
        VelocidadeAtual = velocidadeMinima;
        VelocidadeMaxima = velocidadeMaxima;
    }

    public int VelocidadeMaxima { get; }

    public void Acelerar() => VelocidadeAtual = Math.Min(VelocidadeAtual + 1, VelocidadeMaxima);
    public void Desacelerar() => VelocidadeAtual = Math.Max(VelocidadeAtual - 1, 0);
}

class Program {
    static void Main() {
        string[] velocidades = Console.ReadLine().Split(' ');
        int velocidadeMinima = int.Parse(velocidades[0]);
        int velocidadeMaxima = int.Parse(velocidades[1]);

        Robo robo = new Robo(velocidadeMinima, velocidadeMaxima);

        string comandos = Console.ReadLine();

        foreach (char comando in comandos) {
        if (comando == 'A') robo.Acelerar();
        else if (comando == 'D') robo.Desacelerar();
        }
        Console.WriteLine(robo.VelocidadeAtual);
    }
}
