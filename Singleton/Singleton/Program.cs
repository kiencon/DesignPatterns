using System;

namespace Singleton
{
    public class TraditionalSingletonClassExample
    {
        // hide constructor, avoid invoke from the outside
        private TraditionalSingletonClassExample()
        {
            //todo
        }

        static TraditionalSingletonClassExample _traditionalSingletonClassExampleInstance = null;

        public TraditionalSingletonClassExample GetInstance()
        {
            // condition to able to create an instance
            if (_traditionalSingletonClassExampleInstance == null)
            {
                return new TraditionalSingletonClassExample();
            }
            return _traditionalSingletonClassExampleInstance;
        }
    }

    public class ExtendedSingleton
    {
        // hide constructor, avoid invoke from the outside
        protected ExtendedSingleton()
        {
            //todo
        }

        public ExtendedSingleton GetInstance(Func<bool> IsValidCreating)
        {
            // condition to able to create an instance
            if (IsValidCreating.Invoke())
            {
                return new ExtendedSingleton();
            }
            return null;
        }
    }
    /// <summary>
    /// Simply, Singleton Pattern should be understanded is the limitation of object initialization.
    /// Simultaneously, it is an anti pattern too.
    /// </summary>

    // example
    class Farmer
    {
        private static int _nOFarmer = 0;
        private readonly int MAX_NUMBER_OF_FAMER = 200;
        private Farmer()
        {
            //todo
        }
        private bool IsValidCreating()
        {
            return _nOFarmer < MAX_NUMBER_OF_FAMER;
        }

        // properties
        public string Name { get; set; }
        public string Gender { get; set; }

        // factory method
        public Farmer GetFarmer(string name, string gender)
        {
            // condition to able to create an instance
            if (IsValidCreating())
            {
                _nOFarmer += 1;
                return new Farmer {
                    Name = name,
                    Gender = gender
                };
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
