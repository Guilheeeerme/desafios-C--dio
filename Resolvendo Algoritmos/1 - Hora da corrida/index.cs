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

/** Desafio

Augusto adora se exercitar, por isso levanta todos os dias 6h da manhã, em qualquer tempo ou estação do ano. Ele corre em volta de uma lagoa.
Ao longo da pista de corrida existem N placas igualmente espaçadas.
Augusto conta o número de placas pelas quais ele já passou e verifica se ele já correu pelo menos 10%, 20%, 90% do percurso.

Vamos ajudar o Augusto, calculando para ele o número de placas que ele precisa contar para ter completado pelo menos 10%, 20%, 90% da corrida,
de acordo com o número de voltas que ele quer correr e o número total de placas ao longo da pista.

Se Augusto quiser dar 3 voltas e o número de placas for 17, para garantir ter corrido pelo menos 30% do percurso, ele precisa contar 16 placas.
Para garantir pelo menos 60%, ele precisa contar 31 placas.

* Entrada
A entrada consiste de uma única linha que contém dois inteiros, A e N (1 ≤ A;N ≤ 104), onde A é o número pretendido de voltas e N é o número de placas na pista.

* Saída
Seu programa deve produzir uma única linha com nove inteiros representando os números de placas que devem ser contadas para garantir o cumprimento,
respectivamente, de 10%, 20% e 90% da meta.

*/
