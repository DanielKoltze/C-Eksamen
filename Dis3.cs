using System;
namespace eksamen
{
	public class Dis3
	{
		public static void Dis3Main()
		{

            int[] numbers = new int[5]; // Declaration and instantiation of an integer array with 5 elements

            numbers[0] = 10; // Assigning a value to the first element
            numbers[1] = 20; // Assigning a value to the second element
            Console.WriteLine(numbers.Max());
            string[] strings = {"a","b","c","d","e"};

            //Multi-dimensional arrays
            int[,] ints = new int[3, 4];

            //jagged arrays samme måde som i java
            int[][] numbers2 =
            {
                new int[] {1,2,3},
                new int[] {4,5}
            };



            //range
            Range myRange = 2..5;
            var numbers3 = myRange;



            //indexers
            var store = new Store();
            Console.WriteLine(store[1]);


            //generics
            //making a class
            var generic = new MyGeneric<string>("string");
            Console.WriteLine(generic.GetData());


            //combining indexers and generics
            var storeArr = new int[] { 1, 2, 3 };
            var storeGenerics = new StoreGenerics<int>(storeArr);
            Console.WriteLine(storeGenerics[1]);

        }
	}
}

class Store
{
    private int[] strArr = { 1, 2, 3, 4, 5 };

    public int this[int index]
    {
        get
        {
            return strArr[index];
        }
        set
        {
            strArr[index] = value;
        }
    }
}

class MyGeneric<T>
{

    private T data;

    public MyGeneric(T input)
    {
        data = input;
    }
    public T GetData()
    {
        return data;
    }
}

class StoreGenerics<T>
{
    private T[] arr;

    public StoreGenerics(T[] arr)
    {
        this.arr = arr;
    }
    public T this[int index]{
        get
        {
            return arr[index];
        }
        }
}