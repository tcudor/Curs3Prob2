namespace Curs3Prob2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți un cuvânt: ");
            string cuvant = Console.ReadLine();

            bool estePalindrom = VerificaPalindrom(cuvant);

            if (estePalindrom)
            {
                Console.WriteLine($"{cuvant} este palindrom.");
            }
            else
            {
                Console.WriteLine($"{cuvant} nu este palindrom.");
            }
        }

        static bool VerificaPalindrom(string cuvant)
        {
            cuvant = cuvant.ToLower();

            int lungime = cuvant.Length;
            for (int i = 0; i < lungime / 2; i++)
            {
                if (cuvant[i] != cuvant[lungime - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}