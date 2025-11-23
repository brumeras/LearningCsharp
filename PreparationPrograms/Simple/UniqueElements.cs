namespace PreparationPrograms;

public class UniqueElements
{
    public double[] UniqueArray(double[] array)
    {   
        List<double> uniqueList = new List<double>();
        
        for (int i = 0; i < array.Length; i++)
        {   
            bool isUnique = true;
            
            for (int j = 0; j < uniqueList.Count; j++)
            {
                if (array[i] == uniqueList[j])
                {
                    isUnique = false;
                    break;
                }
            }
            
            if(isUnique)
            {
                uniqueList.Add(array[i]);
            }
        }
        
        return uniqueList.ToArray();
    }
}