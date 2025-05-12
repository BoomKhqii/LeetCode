public class Solution
{
    public int RemoveDuplicates(int[] dupNums)
    {
        List<int> nums = new List<int>();
        int constNum = dupNums[0], length = dupNums.Length - 1;

        for (int i = 0, j = 1; j <= length; i++)
        {
            if (constNum == dupNums[i] && dupNums[i] != dupNums[j])
            {
                nums.Add(dupNums[i]);
                constNum = nums[j];

                Console.Writeline("i: " + dupNums[i] + " j: " + dupNums[j]);
            }


            // only increments j if valid to avoid index out of bounds
            //int temp = i + 1;
            //if (temp <= length) 
                j++;
        }

        return nums.Count;
    }
}