using System;

namespace tratamentodeerros
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int idade;

            try
            {
                Console.WriteLine("Digite a sua idade: ");

                idade = int.Parse(Console.ReadLine());


                Console.WriteLine("sua idade: " + idade);

            }
            catch (Exception ex)
            {
                Console.WriteLine("tratamento de erro");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
