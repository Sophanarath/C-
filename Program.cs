namespace People;

internal class Program
{
    static void Main(string[] args)
    {
        Console.SetIn(File.OpenText("People.txt"));
        Person p = new Person();
        string info = "";
        int line = 0;
        while (true) 
        {
            line++;
            Console.Write($"Reading line {line}...");
            var data = Console.ReadLine();
            if (string.IsNullOrEmpty(data)) 
            {
                Console.WriteLine(">Nothing");
                break; 
            }
            Console.WriteLine(">Ok");
            bool result = p.SetData(data,"/");          
            if (result == false) continue;
            info += "\n" + p.GetInfo();
        }
      
        Console.WriteLine(Person.GetHeading());
        Console.WriteLine(Person.GetBar());
        Console.WriteLine(info);
        Console.WriteLine(Person.GetBar());
    }
}
