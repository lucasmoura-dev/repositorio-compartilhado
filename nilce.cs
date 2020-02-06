using System;

public static class Nilce {
    public static void Main(string[] args) {
        Random rnd = new Random();
        while(Console.ReadKey().Key != ConsoleKey.Escape) {
            switch(rnd.Next() % 5) {
                case 0:
                    Console.WriteLine("Nilce!");
                    break;
                case 1:
                    Console.WriteLine("Boa!");
                    break;
                case 2:
                    Console.WriteLine("Kk");
                    break;
                case 3:
                    Console.WriteLine("Continue assim!");
                    break;
                case 4:
                    Console.WriteLine("Massa");
                    break;
            }
        }
    }
}
