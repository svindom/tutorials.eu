// How to write a text to the file
// This is also, an example of how to create a new text file

string filePath = @"F:\C#_Courses\Course_2_Germ\tutorials.eu\C#Masterclass\Lesson_08_Polymorphism\ReadFromTextLesson\Assets\";

string[] lines = new string[] { "first line", "second line", "third line"};
string[] highScore = new string[] { "235", "456", "102" };

File.WriteAllLines($"{filePath}textFileLesson2.txt", lines);
File.WriteAllLines($"{filePath}textFileLesson2HighScore.txt", highScore);

string text01ToRead = System.IO.File.ReadAllText($"{filePath}textFileLesson2.txt");
string text02ToRead = System.IO.File.ReadAllText($"{filePath}textFileLesson2HighScore.txt");

Console.WriteLine($"The content of the file 1:\n{text01ToRead}");
Console.WriteLine($"The content of the file 2:\n{text02ToRead}");

Console.WriteLine("------------------------------------------------------------------------");

// How to add a content and a file name through the console input

bool isNaming = true;

while (isNaming)
{
    Console.WriteLine("Give a file name (or type 'exit' to skip):");
    string fileName = Console.ReadLine();
    if (string.IsNullOrEmpty(fileName) || fileName.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        isNaming = false;
        break;
    }

    Console.WriteLine("Please write some text:");
    string fileContent = Console.ReadLine();

    File.WriteAllText(filePath + fileName + ".txt", fileContent);
}


Console.WriteLine("------------------------------------------------------------------------");

// Another method to add a text to the file

string[] newLinesOfText = new string[] { "Some text 01", "Some text 02", "Some text 03 (hide)" };
using (StreamWriter file = new StreamWriter($"{filePath}additionalText.txt"))
{
    foreach (string line in newLinesOfText)
    {
        if (line.Contains("hide"))
        {
            file.WriteLine(line);
        }
    }
}

// here is a method of how to add a new linew to the existed file

using (StreamWriter file = new StreamWriter($"{filePath}additionalText.txt", true))
{
    file.WriteLine("Here is a new additional line :)");
}


    Console.ReadKey();
