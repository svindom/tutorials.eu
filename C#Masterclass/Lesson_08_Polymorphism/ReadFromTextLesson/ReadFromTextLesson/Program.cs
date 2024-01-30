string text = System.IO.File.ReadAllText(@"F:\C#_Courses\Course_2_Germ\tutorials.eu\C#Masterclass\Lesson_08_Polymorphism\ReadFromTextLesson\Assets\textFile.txt");
Console.WriteLine($"The Textfile contains the following text:\n{text}");

Console.WriteLine();

string[] lines = System.IO.File.ReadAllLines(@"F:\C#_Courses\Course_2_Germ\tutorials.eu\C#Masterclass\Lesson_08_Polymorphism\ReadFromTextLesson\Assets\textFile.txt");
Console.WriteLine($"The content of the textFile.txt = ");
int numbLine = 0;
foreach( string line in lines )
{
    numbLine++;
    Console.WriteLine($"{numbLine}. {line}");
}



Console.ReadLine();