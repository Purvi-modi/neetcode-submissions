public class Solution {
    public int Search(int[] nums, int target) {
        
        int l=0;
        int h= nums.Length-1;

        int mid =0;
        Console.WriteLine($"l:{l}, h:{h} length:{nums.Length}");
        while(l<=h){
            mid = (l+h)/2;
            Console.WriteLine("hello");
            if(target<nums[mid]){
                h= mid-1;  
            }
            else if(nums[mid]==target){
                return mid;
            }
            else {
                l = mid+1; 
            }
            Console.WriteLine($"l:{l}, h:{h}");
            
        }
        return -1;
    }
}
