using _03_properties_indexers.Examples;

PrintHeading("PROPERTY ACCESS: PRIVATE SETTER & INIT-ONLY");
PropertyAccessExample.Run();

PrintHeading("COMPUTED PROPERTY & VALIDATION");
ComputedPropertyExample.Run();

PrintHeading("INDEXERS");
IndexerExample.Run();

static void PrintHeading(string title)
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 50));
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 50));
}