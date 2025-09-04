public enum PlayerClass : int
{
    None,

    Warrior,

    End
}

public class Player : Character
{
    protected PlayerClass playerClass;

    public void InitPlayer(string inName, int inHp, int inAtk, PlayerClass inPlayerClass)
    {
        InitCharacter(inName, inHp, inAtk);

        playerClass = inPlayerClass;
    }
}