using System;

namespace PilhaGenerica
{
    public class Pilha<T>
    {
        private T[] itens;
        private int topo; // aponta para a próxima posição livre (também é a quantidade)

        public Pilha(int capacidade = 10)
        {
            if (capacidade <= 0)
                throw new ArgumentException("Capacidade deve ser maior que zero.");

            itens = new T[capacidade];
            topo = 0;
        }

        public void Empilhar(T item)
        {
            // Se chegou no limite, aumenta a capacidade automaticamente
            if (topo == itens.Length)
                AumentarCapacidade();

            itens[topo] = item;
            topo++;
        }

        public T Desempilhar()
        {
            if (topo == 0)
                throw new InvalidOperationException("A pilha está vazia. Não é possível desempilhar.");

            topo--;
            T item = itens[topo];

            // Opcional: “limpa” a posição para evitar manter referência (bom p/ memória em tipos referência)
            itens[topo] = default!;

            return item;
        }

        public int Contar()
        {
            return topo;
        }

        private void AumentarCapacidade()
        {
            int novaCapacidade = itens.Length * 2;
            T[] novoArray = new T[novaCapacidade];

            for (int i = 0; i < itens.Length; i++)
                novoArray[i] = itens[i];

            itens = novoArray;
        }
    }
}