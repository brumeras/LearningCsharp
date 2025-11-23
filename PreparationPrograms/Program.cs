using PreparationPrograms;
using PreparationPrograms.Dictionary;
using PreparationPrograms.LinQ;
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

Employee employee = new Employee();
var employees = new List<Employee>
{
    new Employee { Name = "Jonas", Salary = 3000 },
    new Employee { Name = "Petras", Salary = 4500 },
    new Employee { Name = "Ana", Salary = 3500 }
};

AverageSalary avgSalary = new AverageSalary();
double avg = avgSalary.GetAverageSalary(employees);
Console.WriteLine("Average salary: " + avg);

SalaryHigherThan salaryHigherThan = new SalaryHigherThan();
List<Employee> highEarners = salaryHigherThan.GetSalaryHigherThan(employees, 3500);

for (int i = 0; i < highEarners.Count; i++)
{
    Console.WriteLine(highEarners[i].Name);
}

ABCorder abcOrder =  new ABCorder();
List<Employee> alphabethical = abcOrder.GetOrder(employees);

for (int i = 0; i < alphabethical.Count; i++)
{
    Console.WriteLine(alphabethical[i].Name);
}

TotalSalary totalSalary = new TotalSalary();
double tsalary = totalSalary.GetTotalSalary(employees);
Console.WriteLine("Total salary: " + tsalary);

MaxSalary maxSalary = new MaxSalary();
double max = maxSalary.GetMaxSalary(employees);
Console.WriteLine("Max salary: " + max);

MinSalary minSalary = new MinSalary();
double min = minSalary.GetMinSalary(employees);
Console.WriteLine("Min salary: " + min);

//Any
DoesNameExist checker = new DoesNameExist();
bool hasJonas = checker.CheckIfNameExist(employees, "Jonas");
Console.WriteLine($"Has employee 'Jonas'? {hasJonas}");

//All
MakesMoreThan more =  new MakesMoreThan();
bool moreThan = more.CheckIfMakesMoreThan(employees, 3500);
Console.WriteLine($"Makes more than {moreThan}");

//Only Names
OnlyNames onlyNames = new OnlyNames();
List<string> names = onlyNames.GetEmployeeNames(employees);
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

//Sukurimas
ProductPrices products = new ProductPrices();
Dictionary<string, double> productPrices = new Dictionary<string, double>();
productPrices = products.ManagePrices();

//Tikrina kaina
Price p =  new Price();
double ApplePrice = p.GetProductPrice(productPrices, "Apple");
Console.WriteLine("Apple price: " + ApplePrice);

MaxPrice maxPrice = new MaxPrice();
double m =  maxPrice.GetMaxPrice(productPrices);
Console.WriteLine("Max price: " + m);
