using System;

public class Monster
{
    private int _currentHealth;
    private string _mobName;
    protected int _mobHealth;

    protected int _mobAttack;

    protected int _mobSpeed;

    protected string _dropItem;

    protected int _mobDefence;

    public Monster(string _mobName, int _mobHealth, int _mobSpeed, int _mobAttack, string _dropItem, int _mobDefence)
    {
        this._dropItem = _dropItem;
        this._mobAttack = _mobAttack;
        this._mobDefence = _mobDefence;
        this._mobHealth = _mobHealth; 
        this._currentHealth = _mobHealth;
        this._mobSpeed = _mobSpeed;
        this._mobName = _mobName;

    }

    
    public int Attack()
    {
        return _mobAttack;
    }

    public bool RunAway(int _player_speed)
    {
        if (_currentHealth <= _mobHealth / 6 && _mobSpeed > _player_speed) 
        {
            Console.WriteLine("Monster ran away!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public int Defence(int _player_attack)
    {
        if (_player_attack > _mobDefence)
        {
            Console.WriteLine("Your attack hit!");
            _mobHealth -= _player_attack;
           
        }
        else
        {
            Console.WriteLine("Your attack missed!");
        }
        return _mobHealth;
    }
    
    public string DroppedItem()
    {
        return _dropItem;
    }

    public string GetMobName()
    {
        return _mobName;
    }

    public int GetMobSpeed()
    {
        return _mobSpeed;
    }

    public bool CheckDead()
    {
        if (_mobHealth <= 0)
            return true;
        else
            return false;
    }

}