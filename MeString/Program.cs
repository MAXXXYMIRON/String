using System.IO;
using System.Diagnostics;

namespace MeString
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("Test.txt"))
            {
                Stopwatch time = new Stopwatch();
                int index = 0;

                time.Start();
                index = Search("Ниlкитиlн Максиllм Анатlольевlич!gweorilbvwoeibwelolrivbwleoirvbweoirbvlwleorbvwelornvbew", "levj");
                time.Stop();

                writer.Write($"Неудачный поиск в строке \"Ниlкитиlн Максиllм Анатlольевlич!gweorilbvwoeibwelolrivbwleoirvbweoirbvlwleorbvwelornvbew\",\n" +
                    $"подстроки \"levj\", занял - {time.ElapsedMilliseconds} милли секунд\n" +
                    $"И вернул идекс начала подстроки - {index}\n\n\n\n");



                time.Restart();
                index = Search("Никитин Максим Анатольевич!gweoribvwoeibweorivbweoirvbweoirbvweorbvweornvbew", "им Анат");
                time.Stop();

                writer.Write($"Удачный поиск в строке \"Никитин Максим Анатольевич!gweoribvwoeibweorivbweoirvbweoirbvweorbvweornvbew\",\n" +
                    $"подстроки \"им Анат\", занял - {time.ElapsedMilliseconds} милли секунд\n" +
                    $"И вернул идекс начала подстроки - {index}\n\n\n\n");


            }
        }


        /// <summary>
        /// Поиск подстроки в строке
        /// </summary>
        static int Search(NewString str, NewString subStr)
        {
            //первый символ подстроки
            char firstChar = subStr[0];
            //длина подстроки
            int length = subStr.Size;
            //временная строка для проверки
            NewString searchStr;

            for (int i = 0; i < str.Size; i++)
            {
                //Поиск в строке символа совпадающего с первым символом подстроки
                if(str[i] == firstChar)
                {
                    //При нахождении символа, с текущей позиции
                    //из строки выделяется подстрока длинной length
                    searchStr = str.Substr(i, length);
                    //Если выделенная подстрока совпадает 
                    //с подстрокой, которую нужно найти
                    //происходит возврат индекса, с которого эта подстрока начинается
                    if (searchStr == subStr)
                        return i;
                }
            }
            //В случае неудачи происходит возврат -1
            return -1;
        }
    }
}
