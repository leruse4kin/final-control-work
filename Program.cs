// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

        System.Console.WriteLine("Введите строку из слов, разделенных пробелами:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(' ');
        string[] newArray = CreateArrayMaxThreeChars(originalArray);

        PrintArray(originalArray);
        PrintArray(newArray);

        //
        // Функции
        //

        void PrintArray(string[] array) //Функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }

        string[] CreateArrayMaxThreeChars(string[] array) //Функция создания нового массива где элементы не длиннее 3 символов
        {
            string[] newArray = new string[originalArray.Length]; // Создаем новый массив такой же длины, как оригинальный
            int newIndex = 0; // Инициализируем индекс для нового массива

            // Формирование нового массива
            foreach (string str in originalArray) // Перебираем каждый элемент оригинального массива
            {
                // Если длина строки <= 3 символов, добавляем в новый массив
                if (str.Length <= 3) // Проверяем длину текущей строки
                {
                    newArray[newIndex] = str; // Добавляем строку в новый массив
                    newIndex++; // Увеличиваем индекс нового массива для следующего элемента
                }
            }
            return newArray; //возвращаем новый массив
        }
    }

}
