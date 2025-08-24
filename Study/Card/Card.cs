enum Symbol : int
{
    None = -1,

    Spaid = 0,
    Heart,
    Clober,
    Dia,
}

class Card
{
    private Symbol Symbol;
    private int Number;

    public int GetNumber() { return Number;  }

    public void Init(int number, Symbol symbol)
    {
        SetNumber(number);
        SetSymbol(symbol);
    }

    void SetSymbol(Symbol symol)
    {
        Symbol = symol;
    }
    void SetNumber(int number)
    {
        Number = number;
    }

    public void Print()
    {
        switch (Symbol)
        {
            case Symbol.Spaid: Console.Write("♠"); break;
            case Symbol.Heart: Console.Write("♥"); break;
            case Symbol.Clober: Console.Write("♣"); break;
            case Symbol.Dia: Console.Write("◆"); break;
        }
        Console.WriteLine($"{Number}");
    }
}

