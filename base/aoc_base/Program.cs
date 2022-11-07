// meeste puzzels beginnen met een lijst van inputs
// lees deze lijst in en maak een lijst per regel
// dit hangt dus sterk af per puzzel!
List<string> input = File.ReadAllLines("input.txt").ToList();

//bepaal of we deel 1 of deel 2 van de puzzel willen uitvoeren
string result_part1 = part1(input);
string result_part2 = part2(input);

// beschrijving deel 1
static string part1(List<String> input)
{
    try
    {
        return "result";
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: ", ex.Message);
        throw;
    }
}

// beschrijving deel 2
static string part2(List<String> input)
{
    try
    {
        return "result";
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: ", ex.Message);
        throw;
    }
}



