// Soal 1

var array = new int[] { 4, 6, 15, 25, 45, 2, 8 };
var targetSum = 10;

Console.WriteLine("Output: " + ConvertArrayToString(array, targetSum));

static string ConvertArrayToString(int[] arr, int targetSum)
{
    var result = FindPair(arr, targetSum);

    // Convert list array to string
    var arrayString = "[";

    for (int i = 0; i < result.Count; i++)
    {
        arrayString += "[" + string.Join(", ", result[i]) + "]";

        if (i < result.Count - 1)
            arrayString += ", ";
    }

    arrayString += "]";

    return arrayString;
}

static List<List<int>> FindPair(int[] arr, int targetSum)
{
    var result = new List<List<int>>();
    int i = 0, j = 1;

    while (i < arr.Length - 1)
    {
        int currentSum = arr[i] + arr[j];

        if (currentSum == targetSum)
        {
            var pairSum = new List<int> { arr[i], arr[j] };
            result.Add(pairSum);

            i += 2;
            j = i + 1;
        }
        else
        {
            j++;

            if (j == arr.Length)
            {
                i++;
                j = i + 1;
            }
        }
    }

    return result;
}
