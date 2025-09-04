
public enum ItemType : int
{
    None,

    HpPotion,

    End,
}
public class Item
{
    protected ItemType itemType;
    protected int itemValue;

    public ItemType GetItemType() { return itemType;  }
    public int GetItemValue() { return itemValue;  }

    public void Init(ItemType inItemType, int inItemValue)
    {
        itemType = inItemType;
        itemValue = inItemValue;
    }
}

