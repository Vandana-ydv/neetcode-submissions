public class Solution {
    public int MajorityElement(int[] nums) {
        int count=0;
        int n=nums.Length;
        if (n == 1) return nums[0];
        for(int i=0;i<n;i++){
            count = 0;
            for(int j=0;j<n;j++){
              if(nums[i]==nums[j]){
                count+=1;
              }
            }
            if(count>n/2){
                return nums[i];
            }
        }
        return nums[0];
    }
}