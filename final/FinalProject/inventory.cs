public class Inventory
{
    private LootType SwordSLot = null;

    private LootType PotionSLot = null;

    private LootType ArmorSLot = null;


    public void ReplaceSword(LootType new_sword)
    {
        SwordSLot = new_sword;
    }

    public LootType GetSword()
    {
        return SwordSLot;
    }

    public void ReplacePotion(LootType new_potion)
    {
        PotionSLot = new_potion;
    }

    public LootType GetPotion()
    {
        return PotionSLot;
    }

    public void ReplaceArmor(LootType new_armor)
    {
        ArmorSLot = new_armor;
    }

    public LootType GetArmor()
    {
        return ArmorSLot;
    }

    

    public void GetInven()
    {
        Console.WriteLine($"Rarity:{SwordSLot.GetRarity()}-Name:{SwordSLot.GetName()}-Damage:{SwordSLot.GetValue()}");
    }

}