using System;
using PilhaGenerica;

class Program
{
    static void Main()
    {
        // 1) Pilha de int
        var pilhaInt = new Pilha<int>();
        pilhaInt.Empilhar(10);
        pilhaInt.Empilhar(20);
        pilhaInt.Empilhar(30);

        Console.WriteLine("Pilha<int> - Contar: " + pilhaInt.Contar());
        Console.WriteLine("Desempilhando: " + pilhaInt.Desempilhar()); // 30
        Console.WriteLine("Desempilhando: " + pilhaInt.Desempilhar()); // 20
        Console.WriteLine("Contar agora: " + pilhaInt.Contar());

        Console.WriteLine("--------------------------------");

        // 2) Pilha de string
        var pilhaString = new Pilha<string>();
        pilhaString.Empilhar("A");
        pilhaString.Empilhar("B");
        pilhaString.Empilhar("C");

        Console.WriteLine("Pilha<string> - Contar: " + pilhaString.Contar());
        Console.WriteLine("Desempilhando: " + pilhaString.Desempilhar()); // C

        Console.WriteLine("--------------------------------");

        // 3) Pilha de Produto (tipo customizado)
        var pilhaProduto = new Pilha<Produto>();
        pilhaProduto.Empilhar(new Produto(1, "Mouse"));
        pilhaProduto.Empilhar(new Produto(2, "Teclado"));

        Console.WriteLine("Pilha<Produto> - Contar: " + pilhaProduto.Contar());
        Console.WriteLine("Desempilhando: " + pilhaProduto.Desempilhar());
    }
}

public record Produto(int Id, string Nome)
{
    public override string ToString() => $"Produto(Id={Id}, Nome={Nome})";
}