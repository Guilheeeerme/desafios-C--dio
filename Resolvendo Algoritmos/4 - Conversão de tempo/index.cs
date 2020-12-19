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

/** Desafio

Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja,
e informe-o expresso no formato horas:minutos:segundos.

* Entrada
O arquivo de entrada contém um valor inteiro N.

* Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

*/
 
