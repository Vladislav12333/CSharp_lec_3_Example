// // 1 группа методов. Это группа методов которая не чего не возвращает и не чего не принимают
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // Method1();





// // 2 группа методов. Это группа методов которая не чего не возвращает но могут принимать

// // 1 метод
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// // 2 метод
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // // либо 1 вариант либо 2 вариант
// // // Method21(msg: "Текст", count: 4);
// // Method21(count: 4, msg: "Новый текст");





// // 3 группа методов. Это группа методов которая что-то возвращает и не чего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// //Console.WriteLine(year);





// // 4 группа методов. Это группа методов которая что-то возвращает и что-то принимают
// // 1 вариант
// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     } 
// //     return result;
// // }

// // string res = Method4(10, "x");
// // Console.WriteLine(res);

// // 2 вариант

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "x");
// // Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }





// ===== Работа с текстом
// Дан текст. В тексте нужно все проблемы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречевы. Вы дадите мне чаю?";

// // Эти 3 строчки снизу не нужно выводить из комментариев
// // string s = "qwerty"
// //             012
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//    string result = String.Empty;

//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//    }

//    return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);






// 2 задача
// Упорядочить данные внутри массивов
// имеется какая-то последовательность чисел 
// 6 8 3 2 1 4 5 7

// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть не отсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
         
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
