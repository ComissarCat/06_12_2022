using System;
using System.Collections;
using System.Collections.Generic;

namespace _06_12_2022
{
    class Student
    {
        public string Name { get; private set; }
        public Student(string name)
        { Name = name; }
        public override string ToString()
        {
            return Name;
        }
    }
    class Group : IEnumerator, IEnumerable
    {
        public List<Student> Students { get; private set; } = new List<Student>();
        int position = -1;
        public bool MoveNext()
        {
            position++;
            return position < Students.Count;
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current => Students[position];        
        public void Add(string name) { Students.Add(new Student(name)); }
        public IEnumerator GetEnumerator()
        {
            return Students.GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main()
        {
            Group group = new Group
            {
                "Ялозницкий Станислав Валерьевич",
                "Свердлов Александр Сергеевич",
                "Медведев Андрей Юрьевич",
                "Назарько Данил Евгеньевич",
                "Негрей Виктор Владиславович",
                "Гречко Даниил Вячеславович",
                "Ткач Борис Эдуардович",
                "Рамазанов Надир Насрединович"
            };
            foreach (var student in group) { Console.WriteLine(student); }
        }
    }
}
