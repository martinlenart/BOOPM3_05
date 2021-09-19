using System;

namespace BOOPM3_05_02
{
    class Program
    {
        //Implementation of IWine as a class
        public class WineClass : IWine
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }
            override public string ToString() => $"{nameof(Name)}: {Name}, {nameof(Year)}: {Year}, {nameof(Price)}: {Price:N2}";

            public WineClass(string name, int year, decimal price) => (Name, Year, Price) = (name, year, price);
        }

        //Implementation of IWine as a class
        public class WineStruct : IWine
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }
            override public string ToString() => $"{nameof(Name)}: {Name}, {nameof(Year)}: {Year}, {nameof(Price)}: {Price:N2}";

            public WineStruct(string name, int year, decimal price) => (Name, Year, Price) = (name, year, price);
        }

        static void Main(string[] args)
        {
            WineCellar wineCellar1 = new WineCellar(
            new WineClass[] {
                new WineClass("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineClass("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineClass("Viña Ardanza Reserva", 2012, price:269M),
                new WineClass("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineClass)}");
            wineCellar1.ViewCellar();
            Console.WriteLine();

            WineCellar wineCellar2 = new WineCellar(
            new WineStruct[] {
                new WineStruct("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineStruct("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineStruct("Viña Ardanza Reserva", 2012, price:269M),
                new WineStruct("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineStruct)}");
            wineCellar2.ViewCellar();
        }
    }

    // Exercises
    // 1.   Create a WineCellar with mixed WineClass and WineStruct. What type do you thing the initializing array should be?
    // 2.   Make IWine immutable and implement as a record
    // 3.   In WineCellar.ViewCellar() print out the type of the wine in the foreach loop
}
