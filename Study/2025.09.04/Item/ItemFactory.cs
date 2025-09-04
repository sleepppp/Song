public static class ItemFactory
{
    public static Item CreateRandomItem()
    {
        Random random = new Random();
        Item item = new Item();

        ItemType itemType = (ItemType)random.Next((int)ItemType.None + 1, (int)ItemType.End);

        int itemValue = 0;
        switch (itemType)
        {
            case global::ItemType.HpPotion:
            {
                itemValue = random.Next(GameConfig.HpPotionValueRandomMin, GameConfig.HpPotionValueRandomMax);
            }
            break;
        }

        item.Init(itemType, itemValue);

        return item;
    }
}