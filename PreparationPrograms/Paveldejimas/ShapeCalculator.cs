namespace PreparationPrograms.Paveldejimas;

public class ShapeCalculator
{
    public static double GetTotalArea(List<Shape> shapes)
    {
        double total = 0;

        foreach (var shape in shapes)
        {
            total += shape.GetArea();
        }

        return total;
    }
}
