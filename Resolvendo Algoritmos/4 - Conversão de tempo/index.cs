using System;

class Desafio {
  public static void Main (string[] args) {
    int tempoEmSegundos = int.Parse(Console.ReadLine());
    
    int quantidadeDeHoras = tempoEmSegundos / 3600;
    int quantidadeDeMinutos = (tempoEmSegundos % 3600) / 60;
    int quantidadeDeSegundos = (tempoEmSegundos % 3600) % 60;
    
    Console.Write($"{quantidadeDeHoras}:{quantidadeDeMinutos}:{quantidadeDeSegundos}");
    
  }
}
