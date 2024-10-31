namespace People;

public class Person
{
    //static members
    public const int NameFieldWidth = 30;
    public const int GenderFieldWidth  = 6;
    public const int AgeFieldWidth  = 4;
    
    //static methods
    public static string GetHeading()
    {
        string nameText = string.Format($"{{0,{-NameFieldWidth}}}", "name");
        string genderText = string.Format($"{{0,{-GenderFieldWidth}}}", "gender");
        string ageText = string.Format($"{{0, {AgeFieldWidth}}}", "age");
        return $"{nameText} {genderText} {ageText}";
    }
    public static string GetBar(char c = '-')
    {
        return new string(c, NameFieldWidth + GenderFieldWidth + AgeFieldWidth + 2);
    }

    //instance fields
    protected string _name = "";
    protected string _gender = "";
    protected byte _age = 0;

    //instance methods
    public string GetName() => _name;
    public string GetGender() => _gender;
    public byte GetAge() => _age;

    public bool SetData(string data, string delimiter)
    {
        string[] arr = data.Split(delimiter);
        if (arr.Length < 3) return false;
        string name = arr[0].Trim();
        string gender = arr[1].Trim();
        if (byte.TryParse(arr[2], out byte age) == false) return false;
        _name = name;
        _gender = gender;
        _age = age;
        return true;
    }
    public string GetInfo()
    {
        string nameInfo = string.Format($"{{0,{-NameFieldWidth}}}", _name);
        string genderInfo = string.Format($"{{0,{-GenderFieldWidth}}}", _gender);
        string ageInfo = string.Format($"{{0, {AgeFieldWidth}}}", _age);
        return $"{nameInfo} {genderInfo} {ageInfo}";
    }
}

