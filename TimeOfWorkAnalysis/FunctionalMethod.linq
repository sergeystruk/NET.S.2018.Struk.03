<Query Kind="Program" />

void Main()
{
	int[] arr = new int[100000];
	Random rn = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rn.Next(-1000, 1001);
	}
	long time = 0;
	FilterDigits(arr, 5, out time);
	time.Dump();
}
///<summary>
///Functional method of filtering digits
///</summary>
///<param name="array">
///Array to sort
///</param>
///<param name="digit">
///Filter of sorting
///</param>
///<param name="time">
///Time which is needed for computations
///</param>
///<returns>
///Filtered array
///</returns>
public static int[] FilterDigits(int[] array, int number, out long time)
{
    if (array == null)
    {
        throw new ArgumentNullException(nameof(array));
    }

    if (number < 0 || number > 9)
    {
        throw new ArgumentException(nameof(number));
    }
	
	Stopwatch sw = Stopwatch.StartNew();
	
    List<int> checker = new List<int>();
    foreach (int x in array)
    {
        if (x.ToString().Contains(number.ToString()))
        {
            checker.Add(x);
        }
    }	
	time = sw.ElapsedMilliseconds;

    return checker.ToArray();
}
