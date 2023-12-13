using System;
using System.Text;

namespace OOPLaba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person person = new Person();

            Transport[] transport = { new Metro("Метро"), new ElectricTrain("Електричний потяг"), new Tram("Трамвай"), new TrolleyBus("Тролейбус"), new Bus("Автобус"), new Funicular("Фунікульор") };
            double price = 0;
            foreach (var t in transport) 
            {
                t.Trip();
                price += t.price;
                Console.WriteLine();
            }
            Console.WriteLine($"Загальна сума поїздок = {price} грн");
            Console.ReadLine();
        }

        abstract class Transport
        {
            public string Name { get; }
            protected int distance = 45;
            public double price { get; set; }
            public Transport(string name)
            {
                Name = name;
            }

            public void TypeTransport()
            {
                Console.WriteLine($"Тип транспорту - {Name}");
            }
            public virtual void Trip() { }


        }

        class Metro : Transport 
        {
            public Metro(string name) : base(name) { price = 8; }
            public override void Trip() 
            {
                Random random = new Random();
                TypeTransport();
                Console.WriteLine($"Від подольского району до соломенського району {distance = distance + random.Next(30)}км і ціна {price} грн");
            }

        }

        class ElectricTrain : Transport
        {
            public ElectricTrain(string name) : base(name) { price = 20; }
            public override void Trip()
            {
                Random random = new Random();
                TypeTransport();
                Console.WriteLine($"Від подольского району до соломенського району {distance = distance + random.Next(10)}км і ціна {price} грн");
            }
        }

        class Tram : Transport
        {
            public Tram(string name) : base(name) { price = 8; }
            public override void Trip()
            {
                Random random = new Random();
                TypeTransport();
                Console.WriteLine($"Від подольского району до соломенського району {distance = distance + random.Next(60)}км і ціна {price} грн");
            }
        }

        class TrolleyBus : Transport
        {
            public TrolleyBus(string name) : base(name) { price = 8; }
            public override void Trip()
            {
                Random random = new Random();
                TypeTransport();
                Console.WriteLine($"Від подольского району до соломенського району {distance = distance + random.Next(23)}км і ціна {price} грн");
            }
        }

        class Bus : Transport
        {
            public Bus(string name) : base(name) { price = 15; }
            public override void Trip()
            {
                Random random = new Random();
                TypeTransport();
                Console.WriteLine($"Від подольского району до соломенського району {distance = distance + random.Next(41)}км і ціна {price} грн");
            }
        }

        class Funicular : Transport
        {
            public Funicular(string name) : base(name) { price = 8; }
            public override void Trip()
            {
                Random random = new Random();
                TypeTransport();
                Console.WriteLine($"Від подольского району до соломенського району {distance = distance + random.Next(18)}км і ціна {price} грн");
            }
        }

        class Person
        {
            public void Goes(Transport transport)
            {
                    transport.Trip();
            }
        }
    }
}
