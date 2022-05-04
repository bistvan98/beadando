using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace beadando
{
    class MethodsClass
    {
        public int n;

        public ConcurrentQueue<int> lista = new ConcurrentQueue<int>();

        public MethodsClass(int n, ConcurrentQueue<int> lista)
        {
            this.n = n;
            this.lista = lista;
        }

        // 1. Átmásolja a lista tartalmát egy tömbbe a 0. indextől kezdve - ConcurrentQueue.CopyTo metódus használata
        public static void copyData(ConcurrentQueue<int> lista, int[] array)
        {
            lista.CopyTo(array, 0);
        }

        // 2. Törli a lista összes elemét - ConcurrentQueue.Clear metódus használata
        public static void clearListData(ConcurrentQueue<int> list)
        {
            list.Clear();
        }

        // 3. Feltölti a listát random egész számokkal - ConcurrentQueue.Enqueue metódus használata
        public static ConcurrentQueue<int> fill(int n)
        {
            ConcurrentQueue<int> lista = new ConcurrentQueue<int>();

            Task t1 = Task.Run(() => MethodsClass.fillList(lista, n));
            Task t2 = Task.Run(() => MethodsClass.fillList(lista, n));
            Task.WaitAll(t1, t2);

            return lista;
        }

        // Lista feltöltése második rész
        public static ConcurrentQueue<int> fillList(ConcurrentQueue<int> lista, int n)
        {
            for (int i = 0; i < n/2; i++)
            {
                Random random = new Random();
                int rNumber = random.Next(10);
                Thread.Sleep(100);
                lista.Enqueue(rNumber);
            }

            return lista;
        }

        // 4. Összehasonlítja a két objektumot: azonosak-e? - ConcurrentQueue.Equals metódus használata
        public static void compareObjects(ConcurrentQueue<int> list, ConcurrentQueue<int> list2)
        {
            var isEqual = list.Equals(list2);
            Console.WriteLine();

            if (isEqual == false)
            {
                Console.WriteLine("A két lista nem azonos!");
            }
            else
            {
                Console.WriteLine("A két lista azonos!");
            }

        }

        // 5. Output-ként kiírja a konzolra a megadott ebjektum hash kódját - ConcurrentQueue.GetHashCode metódus használata
        public static void hashGetter(ConcurrentQueue<int> list)
        {
            Console.WriteLine();
            Console.WriteLine("A lista Hash Kódja: " + list.GetHashCode());
        }

        // 6. Végigmegy a lista elemein és kiírja őket egyesével - ConcurrentQueue.GetEnumerator metódus használata
        public static void enumeratorList(ConcurrentQueue<int> list)
        {
            Console.WriteLine();
            Console.WriteLine("Enumerator: ");

            IEnumerator enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();
        }

        // Kiiratja a lista elemeit
        public static void writeListData(ConcurrentQueue<int> lista)
        {
            Console.WriteLine("A lista elemei: ");

            foreach (var i in lista)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        // Kiiratja a tömb elemeit
        public static void writeArrayData(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("A tömb elemei: ");

            foreach (var i in array)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
