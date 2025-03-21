class Checklist : Goal
{
    
    private int bonuspoints;

    private int totaltimes;

    private int timesdone;
    public Checklist(int bonuspoints, int totaltimes, int _points, string _destription, string _name) : base(_points, _destription, _name)
    {
        this.bonuspoints = bonuspoints;
        this.totaltimes = totaltimes;
    }

    public Checklist(string goaldata)
    {
        string[] parts = goaldata.Split("-");
        _name = parts[0];
        _destription = parts[1];
        _points = int.Parse(parts[2]);
        timesdone = int.Parse(parts[3]);
        totaltimes = int.Parse(parts[4]);
        bonuspoints = int.Parse(parts[5]);
    }

    public override void Display()
    {
        Console.WriteLine($"{timesdone}/{totaltimes}-{_name}-{_destription}-{_points}-{bonuspoints}");
    }

    public override int Record()
    {
        totaltimes++;

        if (totaltimes == timesdone)
        {
            return bonuspoints + _points;
        }
        else if (totaltimes < timesdone)
        {
            return _points;
        }
        else
        {
            Console.WriteLine("You;ve already completed this.");
            return 0;
        }
        
    }

    public override string Save()
    {
        return $"Checklist-{_name}-{_destription}-{_points}-{timesdone}-{totaltimes}-{bonuspoints}";
    }
}