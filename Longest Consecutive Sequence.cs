public class Solution
{
    public int LongestConsecutive(int[] nums) {
        if(nums.Length < 1)return 0;
        Array.Sort(nums);
        int count = 1;
        int temp = 1;
        int i = 1;
        while(i < nums.Length){
            if(nums[i]- 1 == nums[i - 1]){
                temp ++;
                i ++;
            }else if(nums[i] == nums[i - 1]){
                i++;
            }else{
                temp = 1;
                i ++;
            }
            count = Math.Max(count,temp);
        }
        return count;
    }
}