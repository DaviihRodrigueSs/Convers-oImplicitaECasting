using System.Globalization;

namespace ImplicitaECasting
{
    class program
    {
        static void Main(string[] args)
        {
            // conversão implicita de tipos, pois o float tem 4 bytes, enquanto o double tem 8 bytes, sendo assim a conversão e possível,
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            // agora vou realizar o procedimento de casting, fazendo um valor double ser armazenado em uma variável do tipo float de 4 bytes.

            double a;
            float b;

            a = 5.1;
            // estou fazendo os valores de uma variável de 8 bytes serem armazenados em uma variável de 4 bytes. O famoso Casting.

            b = (float)a;


            Console.WriteLine(b);


            Console.ReadLine();





        }
    }
}