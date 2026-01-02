using Daily_LeetCode_DSA.January;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Day 2: RepeatedNTimes:961
        int[] nums = { 1, 2, 3, 3 };
        Console.WriteLine("Day 2: " + RepeatedNTimes.RepeatedNTimesMethod(nums));

        //Day 1: Plus One:66
        int[] digits = { 9, 9 };
        Console.WriteLine("Day 1: " + string.Join(",", PlusOne.PlusOneMethod(digits)));
    }
}