using System;
using System.Collections.Concurrent;

namespace beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20; // Változó a listák elemszámainak meghatározásához

            MethodsClass listaPeldany1 = new MethodsClass(n, MethodsClass.fill(n)); // Létrehozza az első listát (Példányosítás)

            MethodsClass listaPeldany2 = new MethodsClass(n, MethodsClass.fill(n)); // Létrehozza a második listát (Példányosítás)

            MethodsClass.writeListData(listaPeldany1.lista); // Kiírja az első lista elemeit

            int[] array = new int[listaPeldany1.lista.Count]; // Létrehoz egy tömböt, ami annyi elemet tud tárolni, amennyi elem jelenleg van az első listában

            MethodsClass.copyData(listaPeldany1.lista, array); // Az első lista elemeit átmásolja a létrehozott tömbbe

            MethodsClass.writeArrayData(array); // Kiírja a tömb elemeit

            MethodsClass.compareObjects(listaPeldany1.lista, listaPeldany2.lista); // Összehasonlítja az első és a második listát (ugyanazok-e?)

            MethodsClass.hashGetter(listaPeldany1.lista); // Kiírja az első lista Hash Kódját

            MethodsClass.enumeratorList(listaPeldany1.lista); // Kiírja az első lista elemeit Enumerator-al

            MethodsClass.variableNumberOfArguments(listaPeldany1.lista, 11, 12, 13, 14, 15); // Váltotó hosszúságú paraméter használata

            MethodsClass.writeListData(listaPeldany1.lista); // Kiírja az első lista tartalmát a változó hosszúságú paraméter müködésének megerősítésére

            MethodsClass.clearListData(listaPeldany1.lista); // Törli az első lista tartalmát

            MethodsClass.writeListData(listaPeldany1.lista); // Kiírja az első lista tartalmát a törlés megerősítéséhez

        }
    }
}