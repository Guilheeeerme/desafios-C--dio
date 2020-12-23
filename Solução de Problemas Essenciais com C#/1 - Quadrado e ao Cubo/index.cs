using System;

class Desafio {
  static void Main() {
    int numeroInteiro = int.Parse(Console.ReadLine());
    
    int a;
    int b;

    for (int i = 1; i <= numeroInteiro; i++)
    {
      a = i * i;
      b = i * i * i;
      
      Console.WriteLine($"{i} {a} {b}");
    }
  }
}

/** Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

* Entrada
O arquivo de entrada contém um número inteiro positivo N.

* Saída
Imprima a saída conforme o exemplo fornecido.

*/