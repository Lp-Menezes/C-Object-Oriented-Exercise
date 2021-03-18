using System;

namespace Aula3
{
    class Calculadora
    {
        
          // método somar 
             public void Somar(float valor, float valor2)
             {

                 float soma = valor + valor2;
                 Console.WriteLine("Soma : " + soma);  
             }

        // método Subtrair
        public void Subtrair(float valor, float valor2)
        {
            float sub = valor - valor2;
            Console.WriteLine("Subtração : " + sub);
        }
            //Método Divisão
        public void  Divisão(float valor, float valor2)
        {

            float div = valor / valor2;
            Console.WriteLine("Divisão: " + div);
        }
        //método multiplicação 
        public void Multiplicar(float valor, float valor2)
        {

            float mult = valor * valor2;
            Console.WriteLine("Multiplicação:"  + mult);
        }

        static void Main(string[] args)

        {

            Calculadora calc = new Calculadora();

            calc.Somar(10,20);
            calc.Divisão(30, 5);
            calc.Multiplicar(25, 8);
            calc.Subtrair(450, 45);


        }


    }
}

