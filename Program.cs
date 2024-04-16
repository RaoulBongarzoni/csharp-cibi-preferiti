namespace CibiPreferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inizializzo l'array
            string[] CiboArray = { "pasta", "pizza", "gelato", "lasagna", "cioccolato", "caffe" };

            //stampo a schermo la lunghezza
            Console.WriteLine($"l'array è lungo {CiboArray.Length}");

            //stampo ogni elemento preceduto dalla sua posizione
            var i = 1;
            foreach (string Cibo in CiboArray)
            {
                Console.Write($" {i} - ");
                Console.WriteLine(Cibo);
                i++;
            }

            //stampo il primo elemento
            Console.WriteLine(CiboArray[0]);

            //e stampo l'ultimo elemento
            Console.WriteLine(CiboArray[CiboArray.Length - 1]);

            //e anche l'elemento in mezzo
            Console.WriteLine(CiboArray[CiboArray.Length / 2]);
        }
    }
}
