public class Character
{
    protected string name;
    protected int hp;
    protected int atk;
    protected Character[] characters = new Character[100];

    public int GetHp() { return hp; }
    public int GetAtk() { return atk; }

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

    public void ApplyDamage(int damage)
    {
        hp -= damage;
    }
}

