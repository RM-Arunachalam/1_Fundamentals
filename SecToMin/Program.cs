class Sample
{
    public static void Main(string[] args)
    {
        seconds(288970);//3days,8 hours, 16 minutes,10 seconds
        seconds(987654);//11days,10 hours, 20 minutes,54 seconds
        seconds(7676);//0days,2 hours, 7 minutes,56 seconds
    }
    /// <summary>
    ///  seconds = 288970 [The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"]
    /// </summary>
    /// <param name="seconds"></param>
    public static void seconds(int seconds)
    {
        //  seconds = 288970
        //The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"

        int secondsInOneDay = 24 * 60 * 60;
        int days = seconds / secondsInOneDay;//days
        int remainingSeconds = seconds % secondsInOneDay;

        int hrs = remainingSeconds / (60*60);//hrs
        remainingSeconds = remainingSeconds % (60*60);

        int minutes = remainingSeconds / 60;//mins
        remainingSeconds = remainingSeconds % 60;//sec

        System.Console.WriteLine(days + "days," + hrs + " hours, " + minutes + " minutes," + remainingSeconds + " seconds");

    }
}