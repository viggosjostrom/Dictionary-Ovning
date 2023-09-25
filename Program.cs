
string list = File.ReadAllText("../../../lista.csv");

Dictionary<string, int> husdjur = new Dictionary<string, int>();
    
string[] listSplit = list.Split(",");

int age;

foreach (var item in listSplit)
{
    Console.WriteLine(item); 
}