public static class GameConfig
{
    private static readonly Random random = new Random();

    public static int GetZeroToTenProb()
    {
        return random.Next(0, 11);
    }

    public static readonly int PlayerHpInitValue = 100;
    public static readonly int PlayerAtkInitValue = 10;

    public static readonly int PlayerRunawayProp = 3;

    public static readonly int HpPotionValueRandomMin = 10;
    public static readonly int HpPotionValueRandomMax = 30;

}