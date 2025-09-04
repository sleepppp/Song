enum PlayerInput
{
    Battle = 1,
    Runaway = 2,
    UseItem = 3,
}

public class Game
{
    protected Player player = null;
    protected List<Character> otherCharacters = null;
    protected Random gameRandom = null;
    protected bool bRun = true;

    public void Init()
    {
        gameRandom = new Random();

        player = new Player();

        Console.WriteLine("클래스를 선택하세요");

        for (int i = 1; i < (int)PlayerClass.End; ++i)
        {
            Console.Write($"{i}. {(PlayerClass)i} ");
        }

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

        otherCharacters.Add(ObjectFactory.CreateNpc(NpcType.Merchant));
    }

    public void Run()
    {
        while (bRun)
        {
            Monster liveMonster = GetLiveMonster();

            if (liveMonster == null)
            {
                Console.WriteLine("몬스터를 모두 처치했다");
                Close();
                break;
            }

            Console.WriteLine("몬스터가 나타났다");

            while (true)
            {
                Console.WriteLine("===============================");
                liveMonster.PrintInfo();

                Console.WriteLine("===============================");
                Console.WriteLine("내 차례");
                player.PrintItems();
                Console.WriteLine("===============================");
                Console.WriteLine("무엇을 할까?");
                Console.WriteLine("1.공격 2.도망 3.아이템사용");

                string selectStr = Console.ReadLine();
                if (int.TryParse(selectStr, out int selectNum) == false)
                {
                    Console.WriteLine("잘못 선택했다");
                    break;
                }
          
                if (selectNum == (int)PlayerInput.Runaway)
                {
                    int randomResult = gameRandom.Next(1, 11);
                    if (randomResult > GameConfig.PlayerRunawayProp)
                    {
                        Console.WriteLine("도망에 성공했다");
                        break;
                    }
                }
                else if (selectNum == (int)PlayerInput.Battle)
                {
                    Console.WriteLine("공격!\n");

                    liveMonster.ApplyDamage(player.GetAtk());

                    Console.WriteLine("몬스터 체력 : " + liveMonster.GetHp());
                }
                else if (selectNum == (int)PlayerInput.UseItem)
                {
                    Console.WriteLine("몇번째 아이템 사용할까?");
                    string inputStr = Console.ReadLine();
                    if (int.TryParse(inputStr, out int inputIndex) == false)
                    {
                        Console.WriteLine("잘못 선택했다");
                        break;
                    }

                    player.UseItem(inputIndex);

                }
                else
                {
                    Console.WriteLine("잘못 선택했다");
                    break;
                }

                if (liveMonster.GetHp() <= 0)
                {
                    Console.WriteLine("몬스터를 잡았다");

                    player.AddItem(ItemFactory.CreateRandomItem());

                    break;
                }


            }
        }
    }

    private void Close()
    {
        bRun = false;
    }

    private Monster GetLiveMonster()
    {
        Monster liveMonster = null;
        for (int i = 0; i < otherCharacters.Count; ++i)
        {
            if (otherCharacters[i] is Monster &&
                otherCharacters[i].GetHp() > 0)
            {
                liveMonster = otherCharacters[i] as Monster;
                break;
            }
        }
        return liveMonster;
    }
}