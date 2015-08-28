public class Solution
{
    public int minimumTotal(List<List<Integer>> triangle) {
        int rowLen = triangle.size();
        int[][] sum = new int[rowLen][rowLen];
        
        List<Integer> last = triangle.get(triangle.size()-1);
        for(int i=0; i<last.size(); i++){
            sum[rowLen-1][i] = last.get(i);
        }
        for(int i=rowLen-2; i>=0; i--){
            List<Integer> row = triangle.get(i);
            for(int j=0; j<=i; j++){
                sum[i][j] = Math.min(sum[i+1][j], sum[i+1][j+1]) + row.get(j);
            }
        }
         
        return sum[0][0];
    }
}