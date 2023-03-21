using System;

namespace Dias_faltando_aniversario
{
    public class Program
    {
        static void Main()
        {
            DateTime dataAniversario;

            while (true) // loop infinito
            {
                // Solicita ao usuário a data do aniversário
                Console.WriteLine("Digite a data do seu aniversário (dd/mm/aaaa):");
                string dataStr = Console.ReadLine();

                // Verifica se a string possui a barra para separar os números
                if (!dataStr.Contains("/"))
                {
                    Console.WriteLine("Data inválida. Utilize o formato dd/mm/aaaa.");
                    continue; // volta para o início do loop
                }

                // Tenta converter a string em uma data
                if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataAniversario))
                {
                    Console.WriteLine("Data inválida. Utilize o formato dd/mm/aaaa.");
                    continue; // volta para o início do loop
                }

                // Verifica se a data é futura
                if (dataAniversario > DateTime.Today)
                {
                    break; // sai do loop se a data for válida
                }
                else
                {
                    Console.WriteLine("Data inválida. Digite uma data futura.");
                }
            }

            // Calcula a diferença entre as duas datas em dias
            TimeSpan diff = dataAniversario - DateTime.Today;
            int diasFaltando = (int)diff.TotalDays;

            // Exibe a quantidade de dias faltando
            Console.WriteLine("Faltam {0} dias para o seu próximo aniversário!", diasFaltando);

            Console.ReadLine(); // Aguarda uma tecla ser pressionada para encerrar o programa
        }
    }

}
