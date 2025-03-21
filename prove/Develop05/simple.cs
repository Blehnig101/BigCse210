public class Simple : Goal
{
    private bool Iscompl;

    public Simple(bool _iscompl, int _points, string _destription, string _name) : base(_points, _destription, _name)
    {
        this.Iscompl = _iscompl;
    }

    public Simple(string goaldata)
    {
        string[] parts = goaldata.Split("-");
        _name = parts[0];
        _destription = parts[1];
        _points = int.Parse(parts[2]);
        Iscompl = bool.Parse(parts[3]);
    }

    public override void Display()
    {
        if (Iscompl == true)
        {
            Console.WriteLine($"[X] {_name}-{_destription}-{_points}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name}-{_destription}-{_points}");
        }
    }

    public override int Record()
    {
        if (Iscompl == false)
        {
            Console.WriteLine($"Good job here's points {_points}");
            Iscompl = true;
            return _points;
        }
        else
        {
            Console.WriteLine("Goal already done.");
            return 0;
        }
        
    }

    public override string Save()
    {
        return $"Simple-{_name}-{_destription}-{_points}-{Iscompl}";
    }
}