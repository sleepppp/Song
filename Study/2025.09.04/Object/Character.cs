public class Character
{
    protected string name;
    protected int hp;
    protected int atk;

    public void InitCharacter(string inName, int inHp, int inAtk)
    {
        name = inName;
        hp = inHp;
        atk = inAtk;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"hp : {hp}");
        Console.WriteLine($"atk : {atk}");
    }
}

