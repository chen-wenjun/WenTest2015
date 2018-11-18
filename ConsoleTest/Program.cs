using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleTest
{
    delegate string MyFunc(int a, int b);
    public delegate void MyEvent(object sender, int id);

    delegate Animal ReturnAnimalDelegate();
    delegate Bird ReturnBirdDelegate();

    delegate void TakeAnimalDelegate(Animal a);
    delegate void TakeBirdDelegate(Bird b);

    interface IProcessor<out T>
    {
        T Process();
    }
    class AnimalProcessor<T> : IProcessor<T>
    {
        public T Process()
        {
            return default(T);
        }
    }

    interface IZoo<in T>
    {
        void Add(T t);
    }

    class Zoo<T> : IZoo<T>
    {
        public void Add(T t)
        {
            throw new NotImplementedException();
        }
    }

    struct MyValue
    {
        public int Value1 { get; set; }
        public Person Person { get; set; }

    }

    class Program
    {
        public static string Fun1(int a1, int b1)
        {
            return string.Format("{0}", a1 + b1);
        }

        static Animal GetAnimal() => new Animal();
        static Animal GetAnimal2() => new Animal();
        static Animal GetAnimal3() => new Animal();
        static Bird GetBird() => new Bird();

        static void Eat(Animal a) => a.Eat();
        static void Fly(Bird b) => b.Fly();

        static bool FindEmployee(Employee emp)
        {
            return emp.FullName.Contains("first3");
        }

        static void Main(string[] args)
        {
            {
                Tuple<int, int, int, int, int ,int, int, Tuple<int>> t = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));
            }


            {
                Anomymous anomymous = new Anomymous();
                anomymous.CallAnomymous(11);
                anomymous.CallAnomymous(22);
                anomymous.CallAnomymous(33);
            }

            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee("first1", "last1"),
                    new Employee("first2", "last2"),
                    new Employee("first3", "last3"),
                    new Employee("first4", "last4")
                };

                Predicate<Employee> fun = (Employee e) => e.FullName.Contains("first3");

                Employee emp1 = employees.Find(e => e.FullName.Contains("first3"));
                Employee emp2 = employees.Find(fun);
                Employee emp3 = employees.Find(FindEmployee);

            }


            {
                DateTime d1 = new DateTime(2070,1,1);
                DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime d4 = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Unspecified);
                DateTime d3 = DateTime.ParseExact("20181002", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            }


            {
                IEnumerable<Person> persons = new List<Person>()
                {
                    new Person() { FirstName = "f1", LastName = "l1", Age = 15 },
                    new Person() { FirstName = "f2", LastName = "l2", Age = 15 },
                    new Person() { FirstName = "f3", LastName = "l3", Age = 15 },
                    new Person() { FirstName = "f4", LastName = "l4", Age = 15 }
                };

                var query = from person in persons.AsQueryable()
                            select persons;

            }

            {
                NameValueCollection nvc = new NameValueCollection();
            }

            {
                dynamic obj = new ExpandoObject();


                FlagEnum color = (FlagEnum)(FlagEnum.Red - FlagEnum.Blue);
                Type type = typeof(FlagEnum);
                FlagEnum red = FlagEnum.Red;
                bool isBlue = color.HasFlag(FlagEnum.Blue);
                string desc = (red.GetType().GetField(red.ToString()).GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false)[0] as System.ComponentModel.DescriptionAttribute).Description;

            }

            {
                var a = new Animal<string>();
                Person p = new Person { FirstName = "", Age = 5 };
                p.Print<int>(5);


                p.MyEvent1 += (sender, n) => Console.WriteLine("MyEvent1 fired");
                p.MyEvent1 += delegate { Console.WriteLine("MyEvent1 fired"); };
                p.MyEvent2 += (sender, n) => Console.WriteLine("MyEvent2 fired");

                p.TriggerEvent();
            }

            {

                List<Person> people = new List<Person>()
                {
                    new Person() { Age = 10 },
                    new Person() { Age = 20 },
                    new Person() { Age = 30 },
                    new Person() { Age = 40 }
                };

                var readonlyP = people.AsReadOnly();
                readonlyP[0].Age = 100;

                IZoo<Animal> aniZoo = new Zoo<Animal>();
                aniZoo.Add(new Animal());
                IZoo<Bird> birdZoo = new Zoo<Bird>();
                birdZoo.Add(new Bird());

                birdZoo = aniZoo;


                IProcessor<Animal> animalProcessor = new AnimalProcessor<Animal>();
                IProcessor<Animal> animalProcessor2 = new AnimalProcessor<Bird>();
            }
            {
                ReturnAnimalDelegate a = GetAnimal;
                ReturnAnimalDelegate a2 = GetBird;
                ReturnBirdDelegate b = GetBird;
                //ReturnBirdDelegate b2 = GetAnimal;

                TakeAnimalDelegate ta = Eat;
                //TakeAnimalDelegate ta2 = Fly;
                TakeBirdDelegate tb = Fly;
                TakeBirdDelegate tb2 = Eat;



            }
            {
                object o = "abc";
                string s = (string)o;
                object o2 = (object)s;

                Type t = o.GetType();
                Type t1 = s.GetType();
                bool e = t == t1;
                List<int> ints = new List<int>();

                Comparison<Person> c = (p1, p2) => p1.Age - p2.Age;

                bool re = ReferenceEquals(null, null);
            }

            {
                MyFunc myf1 = Fun1;
                myf1 += delegate (int a2, int b2)
                {
                    return a2.ToString();
                };
                myf1 += (a3, b3) => b3.ToString();

                string r1 = myf1(10, 20);
            }

            {
                Type ty = Type.GetType("ConsoleTest.Employee, ConsoleTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=a950b44ee98bfbc8");
                object obj = Activator.CreateInstance(ty, new object[] { "wen1", "chen1" });


                Employee emp = new Employee("wen", "chen");
                Type type = emp.GetType();
            }

            {
                Employee emp = new Employee("wen", "chen");
                string fn1 = emp.FullName;
                string fn = ((IPerson)emp).GetFullName();

            }
            {
                Dictionary<string, string> dic1 = new Dictionary<string, string>();
                dic1.Add("key1", "value1");
                dic1.Add("key1", "value1");
                dic1.Add("key1", "value1");
            }

            {
                Person p1 = new Person();
                p1.FirstName = "Wen";
                p1.LastName = "Chen";
                p1.Age = 33;

                Person p2 = p1.ShallowCopy();

                p2.Age = 100;
                p2.FirstName = "w2";
                p2.LastName = "c2";
            }

            {
                Predicate<int> pre1 = e => e > 10;
                Predicate<int> pre2 = (e) => e > 10;
                Predicate<int> pre3 = (e) => { e++; return e > 10; };
                Predicate<int> pre4 = delegate (int e) { e++; return e > 10; };

                bool rePre1 = pre1(5);

                Func<string> fun1 = delegate () { return ""; };

                string reFun1 = fun1();

                Func<int, string, string> fun2 = (p1, p2) => p1.ToString() + p2;
                string reFun2 = fun2(100, "abc");

                Func<string> fun3 = () => "abcd";
                string reFun3 = fun3();

                List<int> ints = new List<int>();

                MyFunc myFunc1 = delegate (int a, int b) { return a.ToString() + b.ToString(); };
                MyFunc myFunc2 = (a, b) => a.ToString() + b.ToString();


                string reMyFunc1 = myFunc2(11, 21);

                Action action1 = () => {; };

                var obj1 = new { P1 = 500, P2 = "some", P3 = new Object() };

                string res = MyGeneric<int, string>((e) => e.ToString());

                IEnumerable<Person> persons = new List<Person>()
                {
                    new Person() { FirstName = "a1", LastName = "b1", Age = 10 },
                    new Person() { FirstName = "a2", LastName = "b2", Age = 20 },
                    new Person() { FirstName = "a3", LastName = "b3", Age = 30 }
                };
                foreach (Person p in persons)
                {
                    p.FirstName = "xy";

                }
            }
        }

        public static TResult MyGeneric<T1, TResult>(Func<T1, TResult> fun1)
        {
            return fun1(default(T1));
        }
    }
}
