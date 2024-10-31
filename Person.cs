namespace People;

public class Person
{

    public string name;
    public string gender;
    public byte age;
    public Person(){}
    public Person(string name, string gender, byte age)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }
    public bool SetData(string data, string sep)
    {
        var arr = data.Split(sep);
        if(arr.Length < 3) return false;
        var result = byte.TryParse(arr[2], out byte a);
        if ((result == false)) return false;
        {
            name = arr[0];
            gender = arr[1];
            age = a;
        }
        return true;
    }
    public string GetInfo()
    {
        return $"{name,-30} {gender,-7} {age,3}";
    }
    public static string GetHeading()
    {
        return $"{"name",-30} {"gender",-7} {"age",3}";
    }
    public static string GetBar()
    {
        return new string('-', 42);
    }
}
