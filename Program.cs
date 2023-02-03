namespace Static.Extensionmethod.Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("adfsf", "dfghj", "ASDFGHJ",Month.January);
            Console.WriteLine(user1.GetDetails()); 
            
        }
    }
}