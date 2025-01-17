using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos_C_.models // criando o nome do name space
{
    public class Calculadora  // criando a classe
    {
        public void Somar(int x, int y) // criando o metodo
        {
            Console.WriteLine($"{x} + {y} = {x + y}"); // escrevendo na tela
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potenciar(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} elevado a {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radian = angulo * Math.PI / 180; // Conversão de graus para radianos
            double seno = Math.Sin(radian);     // Calculando o seno
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}{seno}");   // Escrevendo na tela e arredondando para 4 casas
        }
        public void Cosseno(double angulo)  // Recendo o angulo como parâmetro
        {
            double radian = angulo * Math.PI / 180; // Conversão de graus para radianos
            double cosseno = Math.Cos(radian);     // Calculando o cosseno
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}{cosseno}");   // Escrevendo na tela
        }
        public void Tangente(double angulo)  // Recendo o angulo como parâmetro
        {
            double radian = angulo * Math.PI / 180; // Conversão de graus para radianos
            double tangente = Math.Tan(radian);     // Calculando a tangente
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}{tangente}");   // Escrevendo na tela
        }
        public void RaizQuadrada(double x) // void cria um metodo
        {
            double raiz = Math.Sqrt(x);  // Calculando a raiz quadrada
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz, 4)}{raiz}");   // Escrevendo na tela e arreondando para 4 casas
        }
    }
}
