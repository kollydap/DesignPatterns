using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer_Pattern
{
    using System;
    using System.Collections.Generic;

    // Subject interface
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    // Observer interface
    interface IObserver
    {
        void Update();
    }

    // Concrete subject class
    class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        // This method represents a change in the subject's state
        public void DoSomething()
        {
            // Do something here...
            NotifyObservers();
        }
    }

    // Concrete observer class
    class ConcreteObserver : IObserver
    {
        public void Update()
        {
            // Update the observer's state here...
            Console.WriteLine("Observer updated.");
        }
    }

    // Client code
    class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    ConcreteSubject subject = new ConcreteSubject();
        //    ConcreteObserver observer = new ConcreteObserver();

        //    subject.RegisterObserver(observer);

        //    subject.DoSomething(); // This will trigger the observer's update method
        //}
    }

    public interface IDistributor
    {
        void AddCollector(ICollector collector);
        void RemoveCollector(ICollector collector);
        void NotifyCollectors();
    }
    public interface ICollector
    {
        void update();
    }
    class Distributor : IDistributor
    {
        List<ICollector> collectorsList = new List<ICollector>();
        public void AddCollector(ICollector collector)
        {
            collectorsList.Add(collector);
        }
        public void RemoveCollector(ICollector collector)
        {
            collectorsList.Remove(collector);
        }
       public void NotifyCollectors()
        {
            foreach(ICollector collector in collectorsList)
            {
                collector.update();
            }

        }

        public void DoSomething()
        {
            // Do something here...
            NotifyCollectors();
        }
    }

    class Collectors : ICollector
    {
        public void update()
        {
            Console.WriteLine("Observer updated.");
        }
    }
}
