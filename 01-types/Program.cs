using _01_types.Examples;

// Entry point - orchestrates each example.
// Each topic below has its own class in the Examples folder,
// keeping Program.cs thin and focused only on "what runs, in what order".
PrintHeading("VALUE VS REFERENCE TYPES");
ValueVsReferenceExample.Run();

PrintHeading("BOXING / UNBOXING");
BoxingExample.Run();

PrintHeading("STRING IMMUTABILITY");
StringImmutabilityExample.Run();

// Prints a simple banner to visually separate each example's output
// in the console, so results don't blur together when scrolling.
static void PrintHeading(string title)
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 50));
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 50));
}