class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s: string): boolean {

        
        let final: string = s.toLowerCase();
        console.log(final);

        let p1 = 0;
        let p2 = final.length-1;

        while(p1<=p2){
            if(/[a-zA-Z0-9]/.test(final[p1]) ==false){
                p1++; 
                continue;
            }
            if(/[a-zA-Z0-9]/.test(final[p2]) ==false){
                p2--;
                continue;
            }
            console.log("p1",final[p1]," p2",final[p2]);
            if(p1 <= p2 && final[p1]===final[p2]){
                console.log("yes");
                p1++;
                p2--;
                continue;
            }
            else{return false;}
            
        }
        return true;
    }
}
