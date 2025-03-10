
class Reflectionact : Activity
{
    static Animation animation = new Animation();

    public static void Exercise()
    {
        int refectiontime = RunTime();

        DateTime nowtime = DateTime.Now;
        DateTime futuretime = nowtime.AddSeconds(refectiontime);

        while (nowtime < futuretime)
        {
            Console.WriteLine("Begin Refecltion Lets start by thinking about a experience that made you mad.");
            animation.GetAnimation(10);
            Console.WriteLine("Think about why that experience made tou mad.");
            animation.GetAnimation(10);

            nowtime = DateTime.Now;
        }
    }

}