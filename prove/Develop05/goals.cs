public abstract class Goal
{
    protected int _points;

    protected string _destription;

    protected string _name;

    public Goal(int _points, string _destription, string _name)
    {
        this._points = _points;
        this._destription = _destription;
        this._name = _name;

    }

    public Goal()
    {
        
    }

    public abstract void Display();

    public abstract string Save();

    public abstract int Record();
}