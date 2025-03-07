/*I first tried this solution and got a runtime of 1ms, but I saw that someone else got 0ms,
 so I felt a bit jealous and tried to reduce the time :)*/
public class Solution1
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        int[] arrayNums = new int[nums.Length];
        Array.Copy(nums, nums.Length - k, arrayNums, 0, k);
        Array.Copy(nums, 0, arrayNums, k, nums.Length - k);

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = arrayNums[i];
        }
    }
}
public class Solution2
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        Array.Reverse(nums, 0, nums.Length);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}