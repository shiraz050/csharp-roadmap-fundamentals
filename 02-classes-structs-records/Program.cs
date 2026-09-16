
using _02_classes_structs_records.Examples;

PrintHeading("MUTABILITY: CLASS vs STRUCT vs RECORD");
MutabilityExample.Run();

PrintHeading("EQUALITY: CLASS vs RECORD vs RECORD STRUCT");
EqualityExample.Run();

static void PrintHeading(string title)
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 50));
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 50));
}