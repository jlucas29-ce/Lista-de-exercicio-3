/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
* Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
* Comando: Crie um programa que receba o nome, idade, nível inicial,
classe, e raça do personagem e exiba esses dados no console.
@Lista: 02 - Condicionais
@Autor: João Lucas
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program 
{
    static void Main(string[] args)
    {
        Random random= new Random();

        int total,tipo;

        Console.WriteLine(" Quantos baús ele deseja abrir?");
        int.TryParse(Console.ReadLine(), out total);

        Console.WriteLine("Quantos tipos diferentes de baús existem no jogo?");
        int.TryParse(Console.ReadLine(), out tipo);

        for (int i=0;i<=tipo;i++)
    {
        Console.WriteLine($"no({i}) tipo,quantos tipos serão abertos");
    }
    
                
    }
}
