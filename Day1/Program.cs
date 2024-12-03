var lines = File.ReadAllLines("./input.txt");

var rigthLeft = lines.Select(l => l.Split("   "));
var right = rigthLeft.Select(l => int.Parse(l[0])).OrderDescending().ToArray();
var left = rigthLeft.Select(l => int.Parse(l[1])).OrderDescending().ToArray();
var sum = 0;



for(int i = 0; i < right.Length; i++)
{
    sum += Math.Abs(right[i] - left[i]);
}

Console.WriteLine("Part 1");
Console.WriteLine(sum);

// Part 2
sum = 0;
for(int i = 0; i < right.Length; i++)
{
    sum += right.Count(r => left[i] == r ) * left[i];
}

Console.WriteLine("Part 2");
Console.WriteLine(sum);