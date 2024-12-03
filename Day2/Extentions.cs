namespace Day2;

public static class Extentions
{
    public static IEnumerable<int> GetDifferences(this IEnumerable<int> list)
    {
        var differences = new List<int>();
        for (int i = 0; i < list.Count() - 1; i++)
        {
            differences.Add(list.ElementAt(i + 1) - list.ElementAt(i));
        }
        return differences;
    }
}