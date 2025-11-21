namespace PreparationPrograms;

public class BiggestNumber
{
    public double FindingBiggestNumber(double[] array1, int size)
    {
        double biggestNumber = 0;

        for (int i = 0; i < size; i++)
        {
            if (array1[i] > biggestNumber)
            {
                biggestNumber = array1[i];
            }
        }
        return biggestNumber;
    }
}