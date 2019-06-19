namespace TennisKata
{
    public class Tennis

    {
        public int firstplayerscoretime = 0;

        public string Score()
        {
            if (firstplayerscoretime == 0)
            {
                return "Love_All";
            }
            if (firstplayerscoretime == 1)
            {
                return "Thirty_All";
            }
            return "Love_All";
        }
    }
}