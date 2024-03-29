using System;

class Program {
    static void Main() {
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");
    }
    
    static double CalcularPegadaDeCarbono(double km, int horas, int refeicoes) {
        return km * 365 * 0.2 + horas * 0.1 + refeicoes * 0.5;
    }
}
