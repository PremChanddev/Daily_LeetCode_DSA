namespace Daily_LeetCode_DSA.January
{
    internal class RepeatedNTimes
    {
        public static int RepeatedNTimesMethod(int[] nums)
        {
            //HashSet<int> seen = new HashSet<int>();
            //foreach (int num in nums)
            //{
            //    if (seen.Contains(num))
            //    {
            //        return num;
            //    }
            //    seen.Add(num);
            //}
            //return 0; 

            int len = nums.Length / 2;
            //foreach (int num in nums)
            //{
            //    if (nums.Count(num) == len)
            //        return num;
            //}
            //return 0;

            foreach(int num in nums)
            {
                if (nums.Count(n=>n==num) == len)
                    return num;
            }
            return 0;
        }
    }
}
