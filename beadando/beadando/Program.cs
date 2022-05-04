using System;
using System.Collections.Concurrent;

namespace beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;

            MethodsClass listaPeldany1 = new MethodsClass(n, MethodsClass.fill(n));

            MethodsClass listaPeldany2 = new MethodsClass(n, MethodsClass.fill(n));

            MethodsClass.writeListData(listaPeldany1.lista);

            int[] array = new int[listaPeldany1.lista.Count];

            MethodsClass.copyData(listaPeldany1.lista, array);

            MethodsClass.writeArrayData(array);

            MethodsClass.compareObjects(listaPeldany1.lista, listaPeldany2.lista);

            MethodsClass.hashGetter(listaPeldany1.lista);

            MethodsClass.enumeratorList(listaPeldany1.lista);

            MethodsClass.clearListData(listaPeldany1.lista);

            MethodsClass.writeListData(listaPeldany1.lista);
        }
    }
}