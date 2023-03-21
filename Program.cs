namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Até que letra você quer que seja o Diamante?");
            char letra = Convert.ToChar(Console.ReadLine());
            int letraEscolhida = Convert.ToInt32(letra) - Convert.ToInt32('A') + 1;
            Console.Write(letraEscolhida);

            int tamanhoDoAlfabeto = 2 * letraEscolhida - 2;
            int meioDoArray = tamanhoDoAlfabeto / 2;
            int tamanhoDoArray = tamanhoDoAlfabeto - 1;

            string[,] DiamanteDeLetras = new string[tamanhoDoArray, tamanhoDoArray];
           
            for (int i = 0; i < tamanhoDoAlfabeto; i++)
            {
                if (i==0)
                {
                    DiamanteDeLetras[i, meioDoArray] = "A";
                    DiamanteDeLetras[tamanhoDoArray, meioDoArray] = "A";

                }

                if (i == 1)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "B";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "B";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "B";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "B";
                }
                if (i == 2)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "C";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "C";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "C";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "C";
                }
                if (i == 3)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "D";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "D";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "D";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "D";
                }
                if (i == 4)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "E";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "E";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "E";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "E";
                }
                if (i == 5)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "F";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "F";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "F";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "F";
                }
                if (i == 6)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "G";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "G";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "G";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "G";
                }
                if (i == 7)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "H";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "H";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "H";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "H";
                }
                if (i == 8)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "I";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "I";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "I";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "I";
                }
                if (i == 9)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "J";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "J";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "J";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "J";
                }
                if (i == 10)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "K";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "K";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "K";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "K";
                }
                if (i == 11)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "L";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "L";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "L";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "L";
                }
                if (i == 12)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "M";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "M";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "M";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "M";
                }
                if (i == 13)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "N";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "N";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "N";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "N";
                }
                if (i == 14)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "O";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "O";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "O";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "O";
                }
                if (i == 15)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "P";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "P";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "P";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "P";
                }
                if (i == 16)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "Q";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "Q";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "Q";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "Q";
                }
                if (i == 17)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "R";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "R";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "R";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "R";
                }
                if (i == 18)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "S";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "S";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "S";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "S";
                }
                if (i == 19)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "T";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "T";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "T";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "T";
                }
                if (i == 20)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "U";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "U";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "U";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "U";
                }
                if (i == 21)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "V";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "V";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "V";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "V";
                }
                if (i == 22)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "W";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "W";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "W";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "W";
                }
                if (i == 23)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "X";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "X";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "X";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "X";
                }
                if (i == 24)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "Y";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "Y";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "Y";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "Y";
                }
                if (i == 25)
                {
                    DiamanteDeLetras[i, tamanhoDoArray - i] = "Z";
                    DiamanteDeLetras[i, tamanhoDoArray + i] = "Z";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray - i] = "Z";
                    DiamanteDeLetras[meioDoArray + i, tamanhoDoArray + i] = "Z";
                }
                Console.Write(DiamanteDeLetras[i,i]);









            }
        }
    }
}