public enum NpcType : int
{
    None,

    Merchant,
    Storage,
}


public class Npc : Character
{
    protected NpcType npcType;

    public bool CanInteraction(Character inCharacter)
    {
        //if (inCharacter와 나의 거리가 < GameConfig.InteractionRange)
        return true;
    }
}