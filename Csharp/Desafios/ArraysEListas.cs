using System;

class Program {
    static void Main() {
        int quantidadeJogos = int.Parse(Console.ReadLine());
        string[] nomesJogos = new string[quantidadeJogos];

        for (int i = 0; i < quantidadeJogos; i++)
        nomesJogos[i] = Console.ReadLine();
        
        string resumo = $"Foi adicionado '{quantidadeJogos}' jogo{(quantidadeJogos > 1 ? "s" : "")}: {string.Join(", ", nomesJogos)} ao catalogo.";
        Console.WriteLine(resumo);
    }
}
