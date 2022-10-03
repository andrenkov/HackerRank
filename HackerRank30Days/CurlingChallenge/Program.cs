using CurlingChallenge.Models;

int widht = 1000;
double height = Math.Pow(10, 100);

Console.WriteLine("Enter the number of disks:");
int n = Convert.ToInt32(Console.ReadLine().Trim());

Console.WriteLine("Enter the disk radius:");
int r = Convert.ToInt32(Console.ReadLine().Trim());

if (!ValiadateInput())
{
    Console.WriteLine("Invalid input");
    return;
}

Random randNum = new Random();
int[] xCoordinates = Enumerable
    .Repeat(0, n)
    .Select(i => randNum.Next(0, widht))
    .ToArray();


bool ValiadateInput()
{
    return (n >= 1) && (r > 0) && (r < 1000) && (n < 1000);
}

Console.WriteLine(string.Join(", ", xCoordinates));

List<CurlingRock> disks = new();

foreach (int diskX in xCoordinates)
{

    Coords startCoords = new(diskX, height);
    CurlingRock CurlDisk = new(r, startCoords);


    CurlDisk.DoMove(SlideToTopAndCheck());

    disks.Add(CurlDisk);//set end position and display in UI
}

Coords SlideToTopAndCheck()
{
    Coords result = new(0,0);

    return result;
}


//////////////////////////////////////////////////////////////////////////
Console.Write("\nPress any key to continue... ");
Console.ReadLine();

