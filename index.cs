using System;

class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem
{
    public int DanoBase { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public int CalcularDano(int quantidadeManaAtaque)
    {
        return DanoBase * quantidadeManaAtaque;
    }
}

class Program
{
    static void Main()
    {
        // Leitura das informações do personagem
        string nome = Console.ReadLine();

        int mana = int.Parse(Console.ReadLine());

        int danoBase = int.Parse(Console.ReadLine());

        // Criar objeto Subclasse
        Subclasse personagem = new Subclasse(nome, mana, danoBase);

        // Calcular dano e exibir mensagem
        int dano = personagem.CalcularDano(mana);
        Console.WriteLine($"{personagem.Nome} atacou e causou {dano} de dano!");
    }
}