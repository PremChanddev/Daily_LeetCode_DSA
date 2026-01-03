namespace Daily_LeetCode_DSA.January
{
    internal class NumOfWays
    {
        public static int NumOfWaysMethod(int n)
        {
            long mod = 1000000007;
            long prevTwoSame = 6;              // patterns like ABA
            long prevAllDifferent = 6;         // patterns like ABC
            for (int i = 2; i <= n; i++)
            {
                long nextTwoSame = (prevTwoSame * 2 + prevAllDifferent * 2) % mod;
                long nextAllDifferent = (prevTwoSame * 2 + prevAllDifferent * 3) % mod;
                prevTwoSame = nextTwoSame;
                prevAllDifferent = nextAllDifferent;
            }
            return (int)((prevTwoSame + prevAllDifferent) % mod);
        }
    }
}