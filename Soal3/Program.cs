// Soal 3

Console.Write("Input : ");

var input = Console.ReadLine();

if (!IsNumeric(input))
{
    Console.WriteLine("Input must be a number.");
    return;
}

var factori = CountFactory(int.Parse(input));

Console.WriteLine(factori.Count());
Console.WriteLine("Value by factor : " + string.Join(", ", factori));

static List<int> CountFactory(int Z)
{
    var faktorList = new List<int>();

    for (int i = 1; i <= Z / 2; i++)
        if (Z % i == 0)
            faktorList.Add(i);

    faktorList.Add(Z);

    return faktorList;
}

static bool IsNumeric(string str)
{
    foreach (char c in str)
        if (!char.IsDigit(c))
            return false;

    return true;
}