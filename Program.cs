namespace modul5_1302213039
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

        static void Main(string[] args)
        {
            Penjumlahan.jumlahtigaangka<long>(13, 02, 21);
        }
    }
}

