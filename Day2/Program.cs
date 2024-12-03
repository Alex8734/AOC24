using Day2;

var lines = File.ReadAllLines("./input.txt");

var numbers = lines.Select(n => n.Split(" ").Select(int.Parse).ToArray()).ToArray();

var sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    var reports = numbers[i];
    var differences = reports.GetDifferences().ToHashSet();

    if(!differences.All(int.IsPositive) && !differences.All(int.IsNegative))
    {
        continue;
    }

    if (differences.Any(d => Math.Abs(d) > 3) || differences.Any(d => Math.Abs(d) < 1))
    {
        continue;
    }

    sum ++;
}

Console.WriteLine("Part 1");
Console.WriteLine(sum);

// part 2

sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    var reports = numbers[i].ToList();
    var good = false;
    for (int j = 0; j < reports.Count; j++)
    {
        var report = reports.ToList();
        report.RemoveAt(j);

        if(IsGood(report))
        {
            good = true;
        }
    }

    if (good)
    {
        sum++;
    }

}

Console.WriteLine("Part 2");
Console.WriteLine(sum);


bool IsGood(List<int> report)
{
    var differences = report.GetDifferences().ToHashSet();

    if(!differences.All(int.IsPositive) && !differences.All(int.IsNegative))
    {
        return false;
    }

    return !differences.Any(d => Math.Abs(d) > 3) && !differences.Any(d => Math.Abs(d) < 1);
}
