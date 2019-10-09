void Main()
{
    string text = Hello.World.ToString() + "From VietNam with Love <3";
    
    Console.WriteLine(text);
}

public static class Hello
{
    public static class World
    {
        public static new string ToString()
        {
            return MethodBase.GetCurrentMethod().DeclaringType.ToString();
        }
    }
}
