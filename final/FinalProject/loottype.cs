public class LootType
{
    protected string _lootName;

    protected string _lootRarity;

    protected string _lootType; // sword, armor or potion

    protected int _lootValue; // damage or heal or defence

    public LootType(string loot_name, string loot_rarity, string loot_type, int loot_value)
    {
        this._lootName = loot_name;
        this._lootRarity = loot_rarity;
        this._lootType = loot_type;
        this._lootValue = loot_value;
    }

    public string GetName()
    {
        return _lootName;
    }

    public string GetLootType()
    {
        return _lootType;
    }

    public string GetRarity()
    {
        return _lootRarity;
    }

    public int GetValue()
    {
        return _lootValue;
    }
}
