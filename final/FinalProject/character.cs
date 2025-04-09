using System;

public abstract class Character
{
    protected int _playerHealth;

    protected int _playerAttack;

    protected int _playerSpeed;

    protected string _playerItem;

    protected int _playerDefence;

    
    public abstract int Attack();

    public abstract int GainHealth();

    public abstract string UseItem();

    public abstract int RunAway();

    public abstract int Defence();
    

}