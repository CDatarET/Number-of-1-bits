public class Solution {
    public int HammingWeight(int n) {
        string s = Convert.ToString(n, 2);
        int sum = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '1'){
                sum++;
            }
        }
        return(sum);
    }
}
