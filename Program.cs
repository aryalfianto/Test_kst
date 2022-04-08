NameSorter.Sorts();
public class NameSorter
{
    public static List<string> output = new();
    public static List<string>  Sorts()
    {
        List<string> sortedName = new List<string>();
        //Read text from file and convert it to string array
        var readFiles = File.ReadAllLines(Environment.CurrentDirectory + "/unsorted-names-list.txt");
        string result = string.Empty;
        //Looping to set lastName place at front of string
        foreach (var line in readFiles)
        {
            var fileName = line.Split(' ');
            sortedName.Add(fileName[fileName.Length - 1] + "," + line);
        }
        //Sort name 
        sortedName.Sort();
        //Looping to print sorted name and remove temporary lastname at front of string
        foreach (var names in sortedName)
        {
            var splited = names.Split(',');
            result = result + splited[1] + Environment.NewLine;
            output.Add(splited[1]);
            Console.WriteLine(splited[1]);
        }
        //Write text to new text file 
        File.WriteAllText(Environment.CurrentDirectory + "/sorted-names-list.txt", result);
        return output;
    }

}


