using System;
using System.Collections.Generic;

namespace MeString
{
    class NewString
    {
        /// <summary>
        /// Список символов, составляющий строку.
        /// </summary>
        List<char> str = new List<char>();

        /// <summary>
        /// Длина строки.
        /// </summary>
        public int Size => str.Count;

        /// <summary>
        /// Оператор присваивания принимает на вход C# строку и передает ее в конструктор класса.
        /// </summary>
        static public implicit operator NewString(string s) => new NewString(s);

        /// <summary>
        /// Конструктор вставляет эл. строки в список.
        /// </summary>
        NewString(string s = "")
        {
            for (int i = 0; i < s.Length; i++)
            {
                str.Add(s[i]);
            }
        }

        /// <summary>
        /// Удалить строку.
        /// </summary>
        public void Del()
        {
            str.Clear();
            str = null;
        }

        /// <summary>
        /// Задать или получить символ по индексу.
        /// </summary>
        public char this[int index]
        {
            get
            {
                if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
                return str[index];
            }
            set
            {
                if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
                str[index] = value;
            }
        }


        //Переменные для операторов сравнения.
        static int sum1, sum2;

        //Сравнение объектов класса.
        //Сравнение объекта класса и строки c#.
        static public bool operator ==(NewString s1, NewString s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Size; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 == sum2);
        }

        static public bool operator ==(NewString s1, string s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 == sum2);
        }

        static public bool operator !=(NewString s1, NewString s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Size; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 != sum2);
        }

        static public bool operator !=(NewString s1, string s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 != sum2);
        }

        static public bool operator <(NewString s1, NewString s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Size; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 < sum2);
        }

        static public bool operator <(NewString s1, string s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 < sum2);
        }

        static public bool operator >(NewString s1, NewString s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Size; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 > sum2);
        }

        static public bool operator >(NewString s1, string s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 > sum2);
        }

        static public bool operator <=(NewString s1, NewString s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Size; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 <= sum2);
        }

        static public bool operator <=(NewString s1, string s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 <= sum2);
        }

        static public bool operator >=(NewString s1, NewString s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Size; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 >= sum2);
        }

        static public bool operator >=(NewString s1, string s2)
        {
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < s1.Size; i++)
            {
                sum1 += s1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sum2 += s2[i];
            }
            return (sum1 >= sum2);
        }

        //Операторы сложения объектов класса и объекта класса со строкой c# или символом
        static public NewString operator +(NewString s1, NewString s2)
        {
            return new NewString(s1.ToString() + s2.ToString());
        }

        static public NewString operator +(NewString s1, string s2)
        {
            return new NewString(s1.ToString() + s2);
        }

        static public NewString operator +(NewString s, char c)
        {
            return new NewString(s.ToString() + c);
        }

        //Кокатенация строк и символа
        public void Add(NewString s)
        {
            for (int i = 0; i < s.Size; i++)
            {
                str.Add(s[i]);
            }
        }

        public void Add(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                str.Add(s[i]);
            }
        }

        public void Add(char c)
        {
            str.Add(c);
        }

        /// <summary>
        /// Поиск первого вхождения символа, начиная с index
        /// </summary>
        public int Find(char c, int index)
        {
            if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
            for (int i = index; i < Size; i++)
            {
                if (c == str[i]) return i;
            }
            return -1;
        }

        /// <summary>
        /// Последнее вхождение символа в строку
        /// </summary>
        public int Find(char c)
        {
            for (int i = Size - 1; i >= 0; i--)
            {
                if (c == str[i]) return i;
            }
            return -1;
        }


        /// <summary>
        /// Получить подстроку длиной count из строки начиная с индека index
        /// </summary>
        public NewString Substr(int index, int count)
        {
            if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
            if (count < 0 || count > Size) throw new Exception("Некорректное количество элементов");
            if (count + index > Size) throw new Exception("Подстрока должна быть включена в строку");

            NewString s = "";

            for (int i = index; i < index + count; i++)
            {
                s.Add(this[i]);
            }
            return s;
        }

        //Вставить эл. в строку с позиции index
        public void Insert(NewString s, int index)
        {
            if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
            for (int i = 0; i < s.Size; i++)
            {
                str.Insert(index + i, s[i]);
            }
        }

        public void Insert(string s, int index)
        {
            if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
            for (int i = 0; i < s.Length; i++)
            {
                str.Insert(index + i, s[i]);
            }
        }

        public void Insert(char c, int index)
        {
            if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
            str.Insert(index, c);
        }

        /// <summary>
        /// Удалить подстроку дляиной count из строки, начиная с index
        /// </summary>
        public void Remove(int index, int count)
        {
            if (index < 0 || index > Size) throw new Exception("Индекс вне границ строки");
            if (count < 0 || count > Size) throw new Exception("Некорректное количество элементов");
            if (count + index > Size) throw new Exception("Подстрока должна быть включена в строку");


            while (count > 0)
            {
                str.RemoveAt(index);
                count--;
            }

        }

        /// <summary>
        /// Преобразовать экземпляр класса в строку C#
        /// </summary>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Size; i++)
            {
                s += str[i];
            }
            return s;
        }
    }
}
