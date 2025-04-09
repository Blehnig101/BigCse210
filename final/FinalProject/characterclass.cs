using System;

public class CharacterClass : Character
{
    private Random rand = new Random();
    private Inventory _playerInventory = new Inventory();

    public CharacterClass()
    {
        // Start with a basic Wooden Sword
        LootType woodenSword = new LootType("Wooden Sword", "Common", "sword", 5);
        _playerInventory.ReplaceSword(woodenSword);

        _playerHealth = rand.Next(20, 40);
        _playerAttack = _playerInventory.GetSword().GetValue(); // Get the attack power (as int)
        _playerSpeed = rand.Next(5, 16);
        _playerDefence = rand.Next(5, 11);
        _playerItem = GetRandomItem();
    }

    private string GetRandomItem()
    {
        string[] items = { "Potion", "Sword", "Armor", };
        int index = rand.Next(items.Length);
        return items[index];
    }

    public override int Attack()
    {
        return _playerAttack;
    }

    public override int GainHealth()
    {
        int heal = rand.Next(10, 21); // Heal between 10–20
        _playerHealth += heal;
        return _playerHealth;
    }

    public int LoseHealth(int damage)
    {
        _playerHealth -= damage;
        return _playerHealth;
    }

    public bool CheckPlayerDead()
    {
        return _playerHealth <= 0;
    }

    public override string UseItem()
    {
        return $"{_playerItem} used!";
    }

    public override int RunAway()
    {
        return _playerSpeed;
    }

    public override int Defence()
    {
        return _playerDefence;
    }

    public int GetSpeed()
    {
        return _playerSpeed;
    }

    public Inventory GetInventory()
    {
        return _playerInventory;
    }
}
