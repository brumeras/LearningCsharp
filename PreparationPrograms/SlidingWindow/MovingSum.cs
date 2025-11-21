namespace PreparationPrograms.SlidingWindow;

public class MovingSum
{
    int size1;
    private Queue<double> queue;
    double sum;

    public MovingSum(int size)
    {
        size1 = size;
        queue = new Queue<double>();    
    }

    public double Sum(double value)
    {
        if (queue.Count == size1)
        {
            double removed = queue.Dequeue();
            sum -= removed;
        }
        
        queue.Enqueue(value);
        sum+= value;

        return sum;
    }
}