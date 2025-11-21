public class MovingAverage
{    
    int size1;
    Queue<int> queue = new Queue<int>();
    double sum = 0;
    
    public MovingAverage(int size)
    {
        size1 = size;  
        queue = new Queue<int>(size); 
        sum = 0; 
    }

    public double Add(int x)
    {
        if (queue.Count == size1)
        {
            int removed = queue.Dequeue();
            sum -= removed;
        }
        
        queue.Enqueue(x);
        sum += x;

        return sum / queue.Count;
    }
}