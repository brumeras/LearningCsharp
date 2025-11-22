using PreparationPrograms;
using PreparationPrograms.SlidingWindow;
Console.WriteLine("Type the line, which you want to reverse");
string line = Console.ReadLine();
Reverse text = new Reverse();
string reversedLine = text.ReverseLine(line);  
Console.WriteLine(reversedLine); 

Console.WriteLine("Type how many elements you want to have in an array");
int size =  Convert.ToInt32(Console.ReadLine());
FillingAnArray array1 = new FillingAnArray();
double[] filledArray = array1.FillingArray(size);

SumofArray sumofArray = new SumofArray();
double sum = sumofArray.ArraySum(filledArray, size);
Console.WriteLine(sum);

BiggestNumber biggestNumber = new BiggestNumber();
double bigNum = biggestNumber.FindingBiggestNumber(filledArray, size);
Console.WriteLine(bigNum);

Console.WriteLine("Type the line");
string line1 = Console.ReadLine();
HowManyTimes times = new HowManyTimes();
times.HowManyTimesCount(line1);

UniqueElements uniqueElements = new UniqueElements();
double[] unique = uniqueElements.UniqueArray(filledArray);
Console.WriteLine("Unique elements in an array:");
for (int i = 0; i < unique.Length; i++)
{
    Console.WriteLine(unique[i]);
}

MovingSum movingSum = new MovingSum(3);
string[] lines = File.ReadAllLines(@"/Users/semilija25/RiderProjects/PreparationPrograms/PreparationPrograms/files/numbers.txt");
for (int i = 0; i < lines.Length; i++)
{
    string line2 = lines[i];
    
    if (double.TryParse(line2, out double value))
    {
        double result = movingSum.Sum(value);
        Console.WriteLine($"Pridėjome: {value,6:F2} → Suma: {result,8:F2}");
    }
}

Console.WriteLine("Type the line (will check, if it is a polindrome");
string polin = Console.ReadLine();
CheckPolindrome checkPolindrome = new CheckPolindrome();
bool resultP = checkPolindrome.CheckIfPolindrome(polin);

if (resultP)
{
    Console.WriteLine($"'{polin}' IS a palindrome! ✓");
}
else
{
    Console.WriteLine($"'{polin}' is NOT a palindrome. ✗");
}


