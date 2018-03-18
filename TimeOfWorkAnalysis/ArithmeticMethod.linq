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
	FilterDigit(arr, 5, out time);
	time.Dump();
}


public int[] FilterDigit(int[] array, int digit, out long time)
{
	int subElem;
	List<int> list = new List<int>();
	
	Stopwatch sw = Stopwatch.StartNew();
	
	for(int i = 0; i < array.Length; i++)
	{
	subElem = array[i];
		while(subElem != 0)
		{
			if(subElem % 10 == digit)
			{
				list.Add(array[i]);
			}
			subElem /= 10;
		}
	}
	
	time = sw.ElapsedMilliseconds;
	return list.ToArray();
}
