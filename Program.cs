// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше или равна 3 символам.

Console.Clear();

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string [array1.Length];

int a = 0;
int b = 0;
int n = 3;

for (a=0; a<array1.Length; a++)
{
    if (array1[a].Length <= n)
    {
        array2[b] = array1[a];
        b++;
    }
}

for(int i=0; i<array2.Length; i++)
{
    Console.Write($"{array2[i]} ");
}
