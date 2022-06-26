
int input = 1;
double r, perimeter, area;

while (true)
{
    Console.Write("Please write the radius of your circle : ");
    r = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("1.To find PERIMETER of a Circle\n2.To find AREA of a circle");
    input = int.Parse(Console.ReadLine());
    if(input == 1)
    {
        perimeter = 2 * 3.14 * r;
        Console.WriteLine("=============================================");
        Console.WriteLine("The perimeter of yor circle : " + perimeter);
    }
    else if(input == 2)
    {
        area = 3.14 * Math.Pow(r, 2);
        Console.WriteLine("=============================================");
        Console.WriteLine("The area of yor circle : " + area);
    }

    Console.WriteLine("Press any key to calculate again");
    Console.ReadKey();
    Console.WriteLine("\n\n\n");
}