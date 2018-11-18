using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    [MyAttribute(MyProperty1 = "", MyProperty2 = 10)]
    public class Animal : IComparable<Animal>, IDisposable
    {
        public const int CONSTANT = 1;
        public readonly int ReadOnly = 10;

        public Animal()
        {
        }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, int count)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(Animal other)
        {
            return this.GetHashCode().CompareTo(other.GetHashCode());
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Test test = new Test();
        }

        public void GenericMethod<T>(T p) where T : class, IEnumerable, new()
        {
            
        }
        
        private class Test
        {
            public int MyProperty { get; set; }

        }
    }

    public class Bird : Animal
    {
        public void Fly() { }
    }

    public class Dog: Animal
    {
        public void Bark() { }
    }
}
