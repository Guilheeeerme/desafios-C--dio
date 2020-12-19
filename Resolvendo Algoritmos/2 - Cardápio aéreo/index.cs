using System;
class Desafio {
  public static void Main (string[] args) {
    string[] refeicao = Console.ReadLine().Split(" ");
    int pizza  = int.Parse(refeicao[0]);
    int salada = int.Parse(refeicao[1]);
    int massa  = int.Parse(refeicao[2]);

    string[] pedidos  = Console.ReadLine().Split(" ");
    int pedidoPizza  = int.Parse(pedidos[0]);
    int pedidoSalada = int.Parse(pedidos[1]);
    int pedidoMassa  = int.Parse(pedidos[2]);

    int pizzaFaltante = 0;
    if (pizza - pedidoPizza < 0)
    {
      pizzaFaltante = (pizza - pedidoPizza) * - 1;
    }

    int saladaFaltante = 0;
    if (salada - pedidoSalada < 0)
    {
      saladaFaltante = (salada - pedidoSalada) * - 1;
    }

    int massaFaltante = 0;
    if (massa - pedidoMassa < 0)
    {
      massaFaltante = (massa - pedidoMassa) * - 1;
    }

    int totalRefeicoesFaltantes = pizzaFaltante + saladaFaltante + massaFaltante;

    Console.WriteLine(totalRefeicoesFaltantes);

    // Com foreach estava dando erro de syntax ;-;
  }
}
  
