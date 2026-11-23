public class Solution {
    public bool IsAnagram(string s, string t) {

        // lengths are not same
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char,int> dictT = new Dictionary<char, int>();

        for(int i = 0;i<s.Length;i++){
            if(dictS.ContainsKey(s[i])){
                dictS[s[i]] += 1;

            }
            else{
                dictS[s[i]]=1;
            }
        }

        for(int i = 0;i<t.Length;i++){
            if(dictT.ContainsKey(t[i])){
                dictT[t[i]] += 1;

            }
            else{
                dictT[t[i]]=1;
            }
        }

        foreach(var item in dictS){
            int freq1 = item.Value;
            if (!dictT.TryGetValue(item.Key, out int freq2) || freq1 != freq2){
                return false;
            }
        }
        return true;
    }
}
