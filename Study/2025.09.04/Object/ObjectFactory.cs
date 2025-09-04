public static class ObjectFactory
{
    public static Monster CreateMoster(MonsterType inMonsterType)
    {
        Monster result = new Monster();
        switch (inMonsterType)
        {
            case MonsterType.Goblin:
                result.InitMonster("Goblin", 50, 20, inMonsterType);
                break;
            case MonsterType.Sekeleton:
                result.InitMonster("Sekeleton", 70, 10, inMonsterType);
                break;
            case MonsterType.Orc:
                result.InitMonster("Orc", 100, 20, inMonsterType);
                break;
        }

        return result;
    }

    public static Monster CreateRandomMonster()
    {
        Random random = new Random();
        MonsterType randomMonsterType = (MonsterType)random.Next(1, (int)MonsterType.End);
        return CreateMoster(randomMonsterType);
    }

    public static Npc CreateNpc(NpcType inType)
    {
        Npc result = new Npc();
        result.InitNpc("상인", 100, 100, inType);
        return result;
    }
}