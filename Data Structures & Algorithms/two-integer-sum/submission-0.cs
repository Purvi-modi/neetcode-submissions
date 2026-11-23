public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // key will be the differecne and value will be index of the other number 

        Dictionary<int,int> dict = new Dictionary<int, int>();
        int[] result = new int[2];

        for(int i =0;i<nums.Length;i++){
            int curr = nums[i];
            int diff = target - curr;
            if(dict.ContainsKey(diff)){
                int index = dict[diff];
                if(i<index){
                    result[0]=i;
                    result[1]=index;
                }
                else{
                    result[0]=index;
                    result[1]=i;
                }
            } else{
                Console.WriteLine($"{diff} {i}");
                dict[nums[i]]=i;
            }
        }
        return result;
    }
}
