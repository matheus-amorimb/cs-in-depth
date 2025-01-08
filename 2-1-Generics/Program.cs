static List<string> GenerateNames()
{
    List<string> names = [];
    names.Add("Joe");
    names.Add("Matthew");
    names.Add("Bruna");
    return names;
}

static void PrintNames(List<string> names)
{
    foreach (string name in names) 
    {
        Console.WriteLine(name);
    }
}

var names = GenerateNames();
PrintNames(names);


