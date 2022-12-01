﻿//Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//метод создающий 0 массив
void NumberArray (int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
} 

//Метод, выводящий массив на экран
string PrintArray(int[] array)
{
  string result = "[ ";
  for(int i = 0; i < array.Length; i++)
  {
    result += ($"{array[i]} ");
  }
  return result + "]";
}
//Метод подсчета количества четных элементов массива
int CountEvenNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

//Клиентский код
int count_of_elements = 8;
int min_value_of_array = 100;
int max_value_of_array = 1000;
int[] my_array = new int[count_of_elements];
NumberArray(my_array, min_value_of_array, max_value_of_array);


