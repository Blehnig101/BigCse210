public static class LootDrop
{
    public static List<LootType> CommonLoot = [

        new LootType("Rusty Dagger", "Common", "sword", 5),
        new LootType("stone sword", "Common", "sword", 6),
        new LootType("broken spear", "Common", "sword", 4),
        new LootType("lesser heaing potion", "Common", "potion", 10),
        new LootType("Leather hide", "Common", "armor", 5),
        new LootType("Chain shirt", "Common", "armor", 6)
    ];

    public static List<LootType> RareLoot = [
        new LootType("Steel Sword", "Rare", "sword", 8),
        new LootType("Pearl bow", "Rare", "sword", 9),
        new LootType("Steel Spear", "Rare", "sword", 10),
        new LootType("Greater heaing potion", "Rare", "potion", 20),
        new LootType("Steel helm", "Rare", "armor", 10),
        new LootType("Steel breastplate", "Rare", "armor", 12)
    ];

    public static List<LootType> EpicLoot = [
        new LootType("Flameblade", "Epic", "sword", 15),
        new LootType("Shadow Spear", "Epic", "sword", 17),
        new LootType("Water Blade", "Epic", "sword", 18),
        new LootType("MEGA heaing potion", "Epic", "potion", 40),
        new LootType("Dragonscale mail", "Epic", "armor", 15),
        new LootType("Soul bound chestplate", "Epic", "armor", 17)
    ];

    public static LootType GetRandLoot()
    {
        Random rand = new Random();
        int loot_index = rand.Next(0, 6);

        int loot_list = rand.Next(0, 11);

        if (loot_list >= 0 && loot_list <= 6)
        {
            return CommonLoot[loot_index];
        }
        else if (loot_list >= 7 && loot_list <= 9)
        {
            return RareLoot[loot_index];
        }
        else
        {
            return EpicLoot[loot_index];
        }
    }
    public static LootType ItemRarity(string id)
    {
        if (id == "Common")
        {
            Random rand = new Random();
            int choice = rand.Next(0, CommonLoot.Count);

            return CommonLoot[choice];
        }
        else if (id == "Rare")
        {
            Random rand = new Random();
            int choice = rand.Next(0, RareLoot.Count);

            return RareLoot[choice];
        }
        else if (id == "Epic")
        {
            Random rand = new Random();
            int choice = rand.Next(0, EpicLoot.Count);

            return EpicLoot[choice];

        }
        else // neither epic nor rare nor common
        {
            return new LootType("Rusty Dagger", "Common", "sword", 5);
        }
    }

}