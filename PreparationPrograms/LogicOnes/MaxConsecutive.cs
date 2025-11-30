namespace PreparationPrograms.LogicOnes;

public class MaxConsecutive
{
    public int GetMaxConsecutive(int[] array)
    {
        int maxCount = 0;      
        int currentCount = 0;  
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 0; 
            }
        }
        
        return maxCount;
    }
}