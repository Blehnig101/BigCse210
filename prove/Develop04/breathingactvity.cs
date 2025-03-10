class Breathingact : Activity
{
    static Animation animation = new Animation();
    public static void Exercise()
    {
        int breathingtime = RunTime();

        DateTime nowtime = DateTime.Now;
        DateTime futuretime = nowtime.AddSeconds(breathingtime);

        while (nowtime < futuretime)
        {
            Console.WriteLine("Breath in");
            animation.GetAnimation(5);
            Console.WriteLine("breath out");
            animation.GetAnimation(5);
            

            nowtime = DateTime.Now;
        }
    }
}