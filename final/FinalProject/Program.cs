using System;

class Program
{



    static void Main(string[] args)
    {
        int userchoice = 0;

        Console.WriteLine("To begin you adventure type 1");
        Console.WriteLine("To end you adventure type 2");
        userchoice = int.Parse(Console.ReadLine());

        CharacterClass player = new CharacterClass();

        while (userchoice != 2)
        {


            if (userchoice == 1)
            {
                int useraction = 0;

                Console.WriteLine("You've stumbled arcoss a Monster!");
                Monster currentmob = MonsterRarity.GetRandMonster();

                while (useraction != 3 && currentmob.CheckDead() == false && player.CheckPlayerDead() == false)
                {
                    Console.WriteLine($"it's a {currentmob.GetMobName()}");
                    Console.WriteLine("Attack : 1");
                    Console.WriteLine("Use Item : 2");
                    Console.WriteLine("Run : 3");
                    useraction = int.Parse(Console.ReadLine());

                    if (useraction == 1) // user choose to attack
                    {
                        if (player.GetSpeed() >= currentmob.GetMobSpeed()) // this checks who's faster
                        {
                            currentmob.Defence(player.Attack()); // player damage to monster
                            if (currentmob.CheckDead())
                            {
                                Console.WriteLine("You killed the monster!");
                                string listId = currentmob.DroppedItem(); // this is for the player's new item
                                LootType treasure = LootDrop.ItemRarity(listId);
                                Console.WriteLine($"{treasure.GetName()}");
                                Console.WriteLine("Do you want to keep this item?: y/n");
                                string keepItem = Console.ReadLine();
                                if (keepItem.ToLower() == "y")
                                {
                                    if (treasure.GetLootType() == "potion")
                                    {
                                        player.GetInventory().ReplacePotion(treasure);
                                    }
                                    else if (treasure.GetLootType() == "sword")
                                    {
                                        player.GetInventory().ReplaceSword(treasure);
                                    }
                                    else if (treasure.GetLootType() == "armor")
                                    {
                                        player.GetInventory().ReplaceArmor(treasure);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry can't use that");
                                    }
                                }

                            }
                            else
                            {
                                int mobDamage = currentmob.Attack() - player.Defence(); // mob turn damage
                                if (mobDamage > 0)
                                {
                                    player.LoseHealth(mobDamage);
                                    Console.WriteLine($"The monster Hit you for {mobDamage}");
                                }
                            }
                        }
                        else // if mob fsater monster attacks first
                        {
                            if (currentmob.RunAway(player.GetSpeed()) == true) // mob decides to run away
                            {
                                Console.WriteLine("The Monster got away!");
                            }
                            else // mob attaks if slower
                            {
                                int mobDamage = currentmob.Attack() - player.Defence();
                                if (mobDamage > 0)
                                {
                                    player.LoseHealth(mobDamage);
                                    Console.WriteLine($"The monster Hit you for {mobDamage}");
                                }
                                if (player.CheckPlayerDead() == true)
                                {
                                    Console.WriteLine("You LOSE");
                                }
                                else
                                {
                                    currentmob.Defence(player.Attack()); // player damage to monster
                                    if (currentmob.CheckDead())
                                    {
                                        Console.WriteLine("You killed the monster!");
                                    }
                                }
                            }
                        }

                    }
                }

            }
            Console.WriteLine("Would you like to continue? 1 to continue");
            Console.WriteLine("Would you like to continue? 2 to end");
            userchoice = int.Parse(Console.ReadLine());

            if (userchoice == 2)
            {
                Console.WriteLine("good luck another day!");
            }
        }

    }
}