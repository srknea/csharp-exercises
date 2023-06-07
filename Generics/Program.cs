
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            cities.Add("New York");
            cities.Add("Tokyo");
            Console.WriteLine(cities.Count);


            MyList<string> cities2 = new MyList<string>();
            cities2.Add("London");
            cities2.Add("Paris");
            cities2.Add("Milan");
            cities2.Add("New York");
            cities2.Add("Tokyo");
            Console.WriteLine(cities2.Count);


            Console.ReadKey();
        }
    }

    class MyList<T> // Generic Class
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}