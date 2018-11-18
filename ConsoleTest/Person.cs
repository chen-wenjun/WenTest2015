using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Animal<T> : Person, IEnumerable<T> where T : class
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class Person
    {
        public Person()
        {

        }
        public event MyEvent MyEvent1;
        public MyEvent MyEvent2;
        public string FirstName { get; set; }
        public string LastName {get; set; }
        public int Age { get; set; }

        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public void TriggerEvent()
        {
            MyEvent1(this, 1);
            MyEvent2(this, 2);
        }

        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }

        public void Test(int i, int j, params Animal[] optional)
        {

        }

        public int this[int index]
        {
            get
            {
                return index;
            }
            set
            {

            }
        }

        public string this[int index, int age]
        {
            get
            {
                return index.ToString();
            }
            set
            {

            }
        }
    }

    public interface IPerson
    {
        string FullName {get;set;}
        string GetFullName();
    }

    public class Employee : IPerson
    {
        string _firstName, _lastName;
        public Employee(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", _firstName, _lastName);
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IPerson.GetFullName()
        {
            return string.Format("{0} {1}", _firstName, _lastName);
        }
    }
}
