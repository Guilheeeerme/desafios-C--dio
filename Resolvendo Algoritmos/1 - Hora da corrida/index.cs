using System;

class Desafio {
  public static void Main (string[] args) {
    string[] line = Console.ReadLine().Split(" ");
    int voltas = int.Parse(line[0]);
    int placas = int.Parse(line[1]);

    int totalDePlacas = placas * voltas;

    for (int i = 10; i < 100; i += 10)
    {
      double resultado = (double)totalDePlacas / 100 * i;
      Console.Write(Math.Ceiling(resultado) + " ");
    }
  }
}