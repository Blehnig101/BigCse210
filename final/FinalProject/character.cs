using System;

public abstract class Character
{
    protected int _player_health;

    protected int _player_attack;

    protected int _player_speed;

    protected string _player_item;

    protected int _player_defence;

    
    public abstract int Attack();

    public abstract int GainHealth();

    public abstract string UseItem();

    public abstract int RunAway();

    public abstract int Defence();
    

}