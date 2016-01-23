namespace ConsoleApplication1
{
    internal class Point
    {
        public string name;
        public int x;
        public int y;
        public Point()
        {
        }
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public Point(int X, int Y, string na)
        {
            x = X;
            y = Y;
            name = na;
        }
        public void setX(int X)
        {
            x = X;
        }
        public void setY(int Y)
        {
            y = Y;
        }
        public void setName(string na)
        {
            name = na;
        }

    }
}