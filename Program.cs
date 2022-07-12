/*int[] CreateRandomArray(int size) // Задача №34
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 999);

    return newArray;
}

int EvenNumber(int[] array)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
    
        if(array[i] % 2 == 0) count++;
    
    return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);

ShowArray(array);

Console.WriteLine("Count of even elements is " + EvenNumber(array));*/


int[] CreateRandomArray(int size, int minValue, int maxValue) // Задача № 36, Задача №38;
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;
}


int FindOddSum(int[] array)
{
    int sum = 0;
    
    for(int i = 1; i < array.Length; i = i + 2)
    
    sum += array [i];
    
    return sum;
}

int diffbeet(int[] array)
{
    int diff = 0;
    int maxnumber = array[0];
    int minnumber = array[0];


    for(int i = 0; i < array.Length; i++)
   {
    if(maxnumber < array[i])
       maxnumber = array[i];
       
    if(minnumber > array[i]) 
       minnumber = array[i];
         
   }
    
     
Console.WriteLine("Max number " + maxnumber);
Console.WriteLine("Min number " + minnumber);

diff = maxnumber - minnumber;
return diff;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfOdd = FindOddSum(array);
Console.WriteLine("Sum of Odd elements in current array is " +sumOfOdd);

int difference = diffbeet(array);
Console.WriteLine("Difference of elements in current array is " +difference);