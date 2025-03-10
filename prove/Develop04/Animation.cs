class Animation 
{
    public void GetAnimation(int length)
        {
        List<string> animation = new List<string>();
            animation.Add("|");
            animation.Add("/");
            animation.Add("-");
            animation.Add("\\");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(length);
            int i = 0;
            while (DateTime.Now < endTime)
            {
                string frame = animation[i];
                Console.Write(frame);
                Thread.Sleep(500);
                Console.Write("\b \b");

                i++;

                if (i >= animation.Count){
                    i = 0;
                }
            }
        }
}