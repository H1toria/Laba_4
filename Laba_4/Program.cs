Console.Write("Введите желаемый размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-5, 16);
}
Console.WriteLine($"Элементы массива имеют следующий вид: {String.Join(" ", arr)}");

Console.WriteLine($"Сумма отрицательных элементов массива: {arr.Where(n => n < 0).Sum()}");

int maxIndex = Array.FindIndex(arr, n => n == arr.Max());
int minIndex = Array.FindIndex(arr, n => n == arr.Min());
int result = maxIndex < minIndex
    ? getNum(maxIndex + 1, minIndex)
    : getNum(minIndex + 1, maxIndex);

int getNum(int start, int end)
{
    int result = 1;
    for (int i = start; i < end; i++)
    {
        result *= arr[i];
    }
    return result;
}
Console.WriteLine($"Произведение элементов массива, расположенных между максимальным и минимальным элементами массива: {result}");

Console.Write($"Упорядоченные элементы массива имеют следующий вид: ");
var orderedArr = from i in arr
                 orderby i
                 select i;
foreach (int i in orderedArr)
{
    Console.Write($"{i} "); 
    Console.Write("hi");
}
   