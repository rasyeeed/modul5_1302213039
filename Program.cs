
﻿namespace modul5_1302213039
{
    internal class Program
    {
        public class Penjumlahan
        {
            public static void jumlahtigaangka<T>(T a, T b, T c)
            {
                Console.WriteLine((dynamic)a + (dynamic)b + (dynamic)c);
            }
        }
        public class simpledatabase<T>
        {
            private List<T> storeddata;
            private List<DateTime> inputdates;

            public simpledatabase()
            {
                storeddata = new List<T>();
                inputdates = new List<DateTime>();
            }
            public void addnewdata(T T)
            {
                storeddata.Add(T);
                inputdates.Add(DateTime.Now);
            }
            public void printalldata()
            {
                for (int i = 0; i < storeddata.Count; i++)
                {
                    Console.WriteLine("Data " + (i + 1) + " berisi: " + storeddata[i] + " yang disimpan pada waktu "
                        + inputdates[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Penjumlahan.jumlahtigaangka<long>(13, 02, 21);

            simpledatabase<long> outputan = new simpledatabase<long>();
            outputan.addnewdata(13);
            outputan.addnewdata(02);
            outputan.addnewdata(21);
            outputan.printalldata();
        }
    }
}
