class MonsterRarity
{

    public static List<Monster>CommonMobs = [
        new Monster("Goblin", 10, 7, 5, "Common", 3),
        new Monster("Bat", 8, 10, 3, "Common", 2),
        new Monster("skeleton", 5, 8, 3, "Common", 4)
    ];

    public static List<Monster>RareMobs = [
        new Monster("Ork", 15, 5, 7, "Rare", 5),
        new Monster("Golem", 20, 2, 5, "Rare", 8),
        new Monster("Dire Wolf", 12, 10, 6, "Rare", 4)
    ];

    public static List<Monster>EpicMobs = [
        new Monster("Dragon", 50, 15, 20, "Epic", 25),
        new Monster("Lich", 25, 8, 25, "Epic", 15),
        new Monster("Wurm", 55, 10, 20, "Epic", 27)
    ];

    public static Monster GetRandMonster()
    {
        Random rand = new Random();
        int mob_index = rand.Next(0, 3);

        int mob_list = rand.Next(0, 11);

        if (mob_list >= 0 && mob_list <= 6)
        {
            return CommonMobs[mob_index];
        }
        else if (mob_list >= 7 && mob_list <= 9)
        {
            return RareMobs[mob_index];
        }
        else
        {
            return EpicMobs[mob_index];
        }

    }

}