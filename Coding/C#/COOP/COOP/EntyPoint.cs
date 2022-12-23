class Point
{
    public int x;
    public int y;
}

class EntryPoint
{
    static void Main()
    {
        Point point = new Point();

        point.x = 5;
        point.y = 3;

        System.Console.WriteLine(point.x);
        System.Console.WriteLine(point.y);
    }
}