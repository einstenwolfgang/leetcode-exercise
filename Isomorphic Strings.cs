public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,char> dic = new Dictionary<char,char>();
        for(int i = 0; i < s.Length; i++){
            if(!dic.ContainsKey(s[i]))dic[s[i]] = t[i];
            else if(dic[s[i]] != t[i]) return false;
        }
        dic.Clear();
        for(int i = 0; i < s.Length; i ++){
            if(!dic.ContainsKey(t[i]))dic[t[i]] = s[i];
            else if(dic[t[i]] != s[i]) return false;
        }
        return true;
    }
}