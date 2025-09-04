using System.Numerics;
using System.Runtime.InteropServices;

public class Game
{
    protected Player player = null;
    protected List<Character> otherCharacters = null;
    protected bool bRun = true;

    public void Init()
    {
        player = new Player();

        Console.WriteLine("클래스를 선택하세요");
        string selectNumberStr = Console.ReadLine();
        if (int.TryParse(selectNumberStr, out int selectNumber) == false)
        {
            Console.WriteLine("잘못된 값을 입력 했습니다");
            Close();
            return;
        }

        if (selectNumber <= (int)PlayerClass.None || selectNumber >= (int)PlayerClass.End)
        {
            Console.WriteLine("잘못된 값을 입력 했습니다");
            Close();
            return;
        }

        player.InitPlayer("Player", GameConfig.PlayerHpInitValue, GameConfig.PlayerAtkInitValue, (PlayerClass)selectNumber);

        otherCharacters = new List<Character>();
        otherCharacters.Add(ObjectFactory.CreateRandomMonster());
        otherCharacters.Add(ObjectFactory.CreateRandomMonster());
        otherCharacters.Add(ObjectFactory.CreateRandomMonster());
    }

    public void Run()
    {
        while (bRun)
        {

        }
    }

    void Close()
    {
        bRun = false;
    }
}