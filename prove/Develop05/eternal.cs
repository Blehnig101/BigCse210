class Eterenal : Goal
{
 
    public Eterenal(int _points, string _destription, string _name) : base(_points, _destription, _name)
    {

    }

    public Eterenal(string goaldata)
    {
        string[] parts = goaldata.Split("-");
        _name = parts[0];
        _destription = parts[1];
        _points = int.Parse(parts[2]);

    }

    public override void Display()
    {
        Console.WriteLine($"{_name}-{_destription}-{_points}");
    }

    public override int Record()
    {
        return _points;
        
    }

    public override string Save()
    {
        return $"Eternal-{_name}-{_destription}-{_points}";
    }
}