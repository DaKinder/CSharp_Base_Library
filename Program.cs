#region Тема 1 (Условия, циклы)

/*

//Метод подсчитывающий сумму цифр в числе

int CountNumbers(int num)
{
    int sum = 0;
    for (; num > 0; num = num / 10)
    {
        sum += num % 10;
    }
    return sum;
}

//метод выясняющий входит ли число в диапазон

bool RangeCheck(int num, int minRange, int maxRange)
{
    if(num > minRange && num < maxRange) return true;
    return false;
}

//Метод, который выдаёт номер четверти плоскости, в которой находится эта точка.

int GetQuarter(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

//Метод выдающий таблицу квадратов чисел от 1 до n.

void GetTable(int n)
{
    int i = 1;
    for(int i = 1; i <= n; i++) Console.WriteLine($"{i} {Math.Pow(i, 2)}");
}

//Метод который находит расстояние между точками в 2D пространстве.

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
}

//Метод выводящий сумму чисел от одного до N.

int GetSumOfNumbers(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + current;
    }
    return sum;
}

//Метод выдающий количество цифр в числе N.
int QuantityFigureInNumber(int number)
{
    int counter = 0;
    while (number> 0)
    {
        if (number > 0) 
        {
            counter++;
            number = number / 10;
        }
        else break;
    }
    return counter;
}

//Метод выдающий произведение чисел от 1 до N.

int Factroial(int num)
{
    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

//Метод определяющий существование треугольника

bool CheckTriangle(int a, int b, int c)
{
    if (a > b + c || b > a + c || c > a + b) return false;
    //if(a < b + c && b < a + c && c < a + b) return true;
    else return true;
}

//Метод поиска длины числа

int FindNumberLength(int input)
{
    int numLength = 0;

    while (input > 0)
    {
        input = input / 10;
        numLength++;
    }
    return numLength;
}

//Метод разворота числа длины Length (пример: если length = 5493, то multiplier = 1000)

int ReverseNumber(int multiplier, int num, int length)
{
    int newNum = 0;
    for (int i = 0; i < length; i++)
    {
        newNum = newNum + num % 10 * multiplier;
        num = num / 10;
        multiplier = multiplier / 10;
    }
    return newNum;
}

//Метод проверки является ли число палиндромом

bool CompareNumbers(int input, int divider, int length)
{
    int firstNum;
    int lastNum;
    int newNum = input;

    for (int i = 0; i < length / 2; i++)
    {
        firstNum = newNum / divider;
        lastNum = newNum % 10;

        if (firstNum == lastNum)
        {
            newNum = newNum % divider / 10;
            divider /= 100;
        }
        else return false;
    }
    return true;
}

//Метод возводящий число в степень(power)

int MathPowInt(int num, int power)
{
    int multiplier = num;
    for (int i = 1; i < power; i++)
    {
        num = num * multiplier;
    }
    return num;
}

*/

#endregion

#region Тема 2 (одномерные массивы)

/*

//Метод создающий одномерный массив заданного размера

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

//Метод поиска минимального значения

double FindMinValue(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] < min) min = arr[i];
    return min;
}

//Метод поиска маскимального значения

double FindMaxValue(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] > max) max = arr[i];
    return max;
}

//Метод возведения в степень(с массивом)

int MathPowInt(int[] numbers)
{
    int multiplier = numbers[0];
    for (int i = 1; i < numbers[1]; i++)
    {
        numbers[0] = numbers[0] * multiplier;
    }
    return numbers[0];
}

//Метод считающий количество чётных чисел

int CountEvenNumbers(int[] myArray)
{
    int evenCounter = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0) evenCounter += 1;
    }
    return evenCounter;
}

//Метод считающий сумму чисел нечетных индексов

int SumOfOddIndexValues(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

//Метод выводящий одномерный массив

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i]+ " ");
}

int[] array = CreateRandomArray(length, minValue, maxValue);

//метод выодящий сумму отрицательных чисел в массиве

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
return sum;
}

//Метод меняющий знаки в массиве

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }

    return array;
}

//Метод который ищет число в массиве(булевый)

bool SearchNumberInArray(int[] array, int searchNum)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] == searchNum)
            return true;
    }
    return false;
}

//Метод считающий сколько чисел в массиве диапазоне от a до b

int SearchCounter(int[] array, int minValue, int maxValue)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue) counter++;
    }
    return counter;
}

//Метод поиска произведений крайних пар чисел в одномерном массиве и возвращающий новый массив. 

int[] MultyArray(int[] array)
{
    int size = array.Length / 2;

    int[] NewArray = new int[array.Length];

    for (int i = 0; i < size; i++)
    {
        NewArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return NewArray;
}

//Метод разворачивающи одномерный массив

void ReverseArray(int[] arr)
{
    for (int leftIndex = 0, rightIndex = arr.Length - 1;
    leftIndex < rightIndex; leftIndex++, rightIndex--)
    {
        int temp = arr[leftIndex];
        arr[leftIndex] = arr[rightIndex];
        arr[rightIndex] = temp;
    }
}

//Метод выводящий ряд Фибоначи в виде массиав

int[] CreateFibonacci(int firstNumber, int secondNumber, int length)
{
    int[] arr = new int[length];
    arr[0] = firstNumber;
    arr[1] = secondNumber;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

//Метод копирующий массив

int[] CreateArray(int[] oldArray)
{
    int[] newArray = new int[oldArray.Length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = oldArray[i];
    }
    return newArray;
}

*/

#endregion

#region Тема 3 (двумерные массивы)

/*

//Метод выводящий двумерный массив в консоль

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] );
        }
        Console.WriteLine();
    }
}

//Метод создающий двумерный массив

int[,] CreateRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

*/

#endregion