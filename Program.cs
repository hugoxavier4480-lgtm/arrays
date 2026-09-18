namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays- tamanho fixo
            //listas- tamanho dinamico 
            // declarar / inicializar com valores
            int[] notas = { 1, 2, 3, 4, 5, 6, 7 };
            // declarar / inicializar sem valores 
            int[] notas2 = new int[5];

            notas2[0] = 15;
            notas2[1] = 18;
            notas2[2] = 7;
            notas2[3] = 19;
            notas2[4] = 17;
            

            //imprimir o valor do primeiro elemento e ultimo
            Console.WriteLine(notas2[0]);
            //ultimo
            Console.WriteLine(notas2[notas2.Length-1]);

            for (int i = 0; i < notas2.Length; i++)
            {

                Console.WriteLine(notas2[i]);
            }

        }
    }
}
