public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        if (gas.Length == 0 || cost.Length == 0 || gas.Length != cost.Length) return -1;
        int total = 0, sum = 0, start = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            total += (gas[i] - cost[i]);
            if (sum < 0)
            { //����������ˣ�����һ��վ�㳢��
                sum = (gas[i] - cost[i]);
                start = i;
            }
            else
                sum += (gas[i] - cost[i]);
        }
        return total < 0 ? -1 : start;
    }
}