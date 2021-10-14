using System;

namespace BOOPM3_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            WineCellar wineCellar1 = new WineCellar(
            new IWine[] {
                new WineClass("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineClass("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineClass("Viña Ardanza Reserva", 2012, price:269M),
                new WineClass("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineClass)}");
            wineCellar1.ViewCellar();
            Console.WriteLine();


            WineCellar wineCellar2 = new WineCellar(
            new IWine[] {
                new WineStruct("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineStruct("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineStruct("Viña Ardanza Reserva", 2012, price:269M),
                new WineStruct("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineStruct)}");
            wineCellar2.ViewCellar();
        }
    }

    // Exercises
    // 1.   Create a WineCellar with mixed WineClass and WineStruct.
    // 3.   In WineCellar.ViewCellar() print out the type IWine is implemented in in the foreach loop
    // 2.   Make IWine immutable and implement as a record
}
