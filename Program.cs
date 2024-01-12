using SegundoDeTresExerciciosAulaClassesUmlOrientacaoObjeto;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = (Console.ReadLine());
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CI);
            funcionario.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);

        }
    }
}