//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.Observer_Pattern
//{
//    using System;
//    using System.Collections.Generic;

//    // Subject interface
//    interface ISubject
//    {
//        void RegisterObserver(IObserver observer);
//        void RemoveObserver(IObserver observer);
//        void NotifyObservers();
//    }

//    // Concrete subject class
//    class WeatherData : ISubject
//    {
//        private float temperature;
//        private float humidity;
//        private float pressure;
//        private List<IObserver> observersList = new List<IObserver>();

//        public void SetMeasurements(float temperature, float humidity, float pressure)
//        {
//            this.temperature = temperature;
//            this.humidity = humidity;
//            this.pressure = pressure;
//            NotifyObservers();
//        }

//        public void RegisterObserver(IObserver observer)
//        {
//            observersList.Add(observer);
//        }

//        public void RemoveObserver(IObserver observer)
//        {
//            observersList.Remove(observer);
//        }

//        public void NotifyObservers()
//        {
//            foreach (IObserver observer in observersList)
//            {
//                observer.Update(temperature, humidity, pressure);
//            }
//        }
//    }

//    // Observer interface
//    interface IObserver
//    {
//        void Update(float temperature, float humidity, float pressure);
//    }

//    // Concrete observer classes
//    class CurrentConditionsDisplay : IObserver
//    {
//        private float temperature;
//        private float humidity;

//        public void Update(float temperature, float humidity, float pressure)
//        {
//            this.temperature = temperature;
//            this.humidity = humidity;
//            Display();
//        }

//        public void Display()
//        {
//            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
//        }
//    }

//    class StatisticsDisplay : IObserver
//    {
//        private float temperature;
//        private float humidity;
//        private float pressure;

//        public void Update(float temperature, float humidity, float pressure)
//        {
//            this.temperature = temperature;
//            this.humidity = humidity;
//            this.pressure = pressure;
//            Display();
//        }

//        public void Display()
//        {
//            Console.WriteLine("Avg/Max/Min temperature: " + temperature + "/" + temperature + "/" + temperature);
//        }
//    }

//    class ForecastDisplay : IObserver
//    {
//        private float temperature;
//        private float humidity;
//        private float pressure;

//        public void Update(float temperature, float humidity, float pressure)
//        {
//            this.temperature = temperature;
//            this.humidity = humidity;
//            this.pressure = pressure;
//            Display();
//        }

//        public void Display()
//        {
//            Console.WriteLine("Forecast: More of the same");
//        }
//    }

//    // Client code
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            WeatherData weatherData = new WeatherData();
//            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
//            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
//            ForecastDisplay forecastDisplay = new ForecastDisplay();

//            weatherData.RegisterObserver(currentDisplay);
//            weatherData.RegisterObserver(statisticsDisplay);
//            weatherData.RegisterObserver(forecastDisplay);

//            weatherData.SetMeasurements(80, 65, 30.4f);
//            weatherData.SetMeasurements(82, 70, 29.2f);
//            weatherData.SetMeasurements(78, 90, 29.2f);

//            weatherData.RemoveObserver(forecastDisplay);

//            weatherData.SetMeasurements(75, 80, 28.2f);
//        }
//    }
//    class Weather
//    {
//    }
//}
