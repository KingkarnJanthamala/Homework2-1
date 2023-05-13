using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Input number: "); //number คือชั้นของสามเหลี่ยมปาสคาล
            int number = int.Parse(Console.ReadLine());
            if (number >= 0) {
                Loop(number);
                break;   
            } else {
                Console.WriteLine("Invalid Pascal’s triangle row number");
                continue;
            }
        }
     }
    static void Loop(int number) {
        for(int row = 0 ; row <= number ; row++) {
            for(int col = 0 ; col <= row ; col++) {
                Console.Write("{0} " , CNR(row,col));
            }
            Console.WriteLine();
        }
    }
    static double Factorial(double num) {
        if (num <= 1) {
            return 1;
        } 
        return num * Factorial(num - 1);
    }
    static double CNR(double n , double r) {
        Factorial(n);
        Factorial(r);
        double nr = n-r;
        Factorial(nr);

        double PrintCNR1 = Factorial(n);
        double PrintCNR2 = Factorial(nr) * Factorial(r);
        double PrintCNR = PrintCNR1 / PrintCNR2;
        return (PrintCNR);
    }
}