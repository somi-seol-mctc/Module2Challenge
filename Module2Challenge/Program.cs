float miles;
float gallons;
float mpg;

///prompt user
Console.Write("Enter number of miles driven: ");
miles = float.Parse(Console.ReadLine());

Console.Write("Enter number of gasoline used (gallons): ");
gallons = float.Parse(Console.ReadLine());

///calculate mpg
mpg = miles / gallons;

///display results
Console.WriteLine($@"Your mpg is {mpg}");