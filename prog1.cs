using System;

class prog1{

    static void Main(){
        
        int left = 100;
        int right =200;
        int temp = 0;

        Console.WriteLine("The primes number between {0} and {1} are: ", left, right);

        for (int i = left; i <= right; i++) {
            temp = 0;
            if (i>1) {
                for (int j=2;j<i;j++) {
                    if (i%j == 0) {
                        temp = 1;
                        break;
                    }
                }
                if (temp == 0) {
                    Console.WriteLine(i);
                }
            }
        }





    }






}