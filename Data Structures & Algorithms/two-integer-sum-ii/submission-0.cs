public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //[1,1,1,3,4,5]

        int p1 = 0;
        int p2 = numbers.Length - 1;
        int[] result = new int[2];

        while(p1<p2){
            int sum = numbers[p1]+numbers[p2];

            if(sum < target){
                p1++;
            }
            else if(sum == target){
                result[0]=p1+1;
                result[1]=p2+1;
                return result;
            }
            else{
                p2--;
            }
        }
        return result;
    }
}
