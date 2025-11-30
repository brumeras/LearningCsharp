namespace PreparationPrograms.LogicOnes;

public class MinDistanceBetweenTargets
{
    public int GetMinDistanceBetweenTargets(int[] nums, int target)
    {
        int minDistance = int.MaxValue; 
        int lastTargetIndex = -1;       
    
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                if (lastTargetIndex != -1)
                {
                    int distance = i - lastTargetIndex;
                    minDistance = Math.Min(minDistance, distance);
                }
                
                lastTargetIndex = i;
            }
        }
        
        return minDistance == int.MaxValue ? -1 : minDistance;
    }
}