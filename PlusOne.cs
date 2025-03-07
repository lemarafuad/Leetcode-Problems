public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        List<int> list = new List<int>(digits);
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] < 9)
            {
                list[i]++;
                digits = list.ToArray();
                return digits;
            }

            list[i] = 0;
        }

        list.Insert(0, 1);
        digits = list.ToArray();
        return digits;
    }
}