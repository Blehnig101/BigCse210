class Listeningact : Activity
{
    static Animation animation = new Animation();

    public static void Exercise()
    {
        int listeningtime = RunTime();

        DateTime nowtime = DateTime.Now;
        DateTime futuretime = nowtime.AddSeconds(listeningtime);

        while (nowtime < futuretime)
        {
            Console.WriteLine("Begin listening");
            animation.GetAnimation(10);
            Console.WriteLine("Think about why that idea was brought up.");
            animation.GetAnimation(10);

            nowtime = DateTime.Now;
        }
    }

}