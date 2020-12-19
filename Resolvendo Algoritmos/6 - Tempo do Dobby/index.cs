using System;

class Desafio {
  public static void Main (string[] args) {
    int tempoFinalExpediente = int.Parse(Console.ReadLine());

    string[] tempoBrinquedos = Console.ReadLine().Split(" ");
    int tempoBrinquedoUm   = int.Parse(tempoBrinquedos[0]);
    int tempoBrinquedoDois = int.Parse(tempoBrinquedos[1]);

    string fareiHoje = "Farei hoje!";

    if (tempoBrinquedoUm + tempoBrinquedoDois > tempoFinalExpediente)
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else 
    {
      Console.Write(fareiHoje);
    }
  }
}