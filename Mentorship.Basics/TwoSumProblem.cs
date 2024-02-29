namespace Mentorship.Basics;

internal class TwoSumProblem
{
    public static KeyValuePair<int,int> FindTwoSum(int[] array, int target)
    {
        int left=0,right=array.Length-1;
        while(left<right) 
        {
            if (array[left] + array[right] == target)
            {
                return new(left+1, right+1);
            }
            else if (array[left] + array[right] > target) 
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return new(-1, -1);
    }
}