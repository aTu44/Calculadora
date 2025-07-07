using System;

    public class ContasBasicas {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public void LerDados() {
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
        }

        public double Somar() {
            return num1 + num2;
        }

        public double Subtrair() {
            return num1 - num2;
        }

        public double Multiplicar() {
            return num1 * num2;
        }

        public double Dividir() {
            if (num2 == 0) {
                throw new DivideByZeroException("Divisão por zero não permitida.");
            }
            return num1 / num2;
        }
    }

