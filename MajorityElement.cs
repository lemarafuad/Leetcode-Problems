public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dictionaryNums = new Dictionary<int, int>();
        int maxElement = 0; int number = 0;
        foreach (int num in nums)
        {
            if (dictionaryNums.ContainsKey(num))
            {
                dictionaryNums[num]++;
            }
            else dictionaryNums.Add(num, 1);
            if (dictionaryNums[num] > maxElement)
            {
                maxElement = dictionaryNums[num];
                number = num;
            }
        }
        return number;
    }
}