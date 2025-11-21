namespace PreparationPrograms;

public class FillingAnArray
{
    public double[] FillingArray(int size)  
    {
        double[] array1 = new double[size]; 
        
        for (int i = 0; i < size; i++)
        {   
            Console.Write("Enter element to add to an array: ");
            double element = Convert.ToDouble(Console.ReadLine());
            array1[i] = element;
        }

        return array1;
    }
}