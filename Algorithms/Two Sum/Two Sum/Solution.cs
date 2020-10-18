namespace Two_Sum
{
    class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int [2];

            for (int i = 0; i < nums.Length; i++)
            {
                int searchFor = target - nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[j]== searchFor) {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }                    
                }
            }
            
            return result;
        }
    }
}
