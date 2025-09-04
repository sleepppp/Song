public enum NpcType : int
{
    None,

    Merchant,
    Storage,
}

public class Npc : Character
{
    protected NpcType npcType;

    public void InitNpc(string inName, int inHp, int inAtk, NpcType inNpc)
    {
        InitCharacter(inName, inHp, inAtk);

        npcType = inNpc;
    }
}