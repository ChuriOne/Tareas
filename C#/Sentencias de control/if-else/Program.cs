using System;
using System.Timers;
class Program {
    static void Main(string[] args) {
        int numero = 10;
        if (numero > 0) {
            Console.WriteLine("El numero es positivo.");
        } else if (numero <0) {
            Console.WriteLine("El numero es negativo.");
        } else {
            Console.WriteLine("El numero es cero.");
        }
    }
}