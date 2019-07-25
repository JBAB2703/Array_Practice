using System;

namespace ArrayPractice {
    class Program {
        static void Main(string[] args) {

            int[] frames = new int[100];

            frames[0] = 71;
            frames[1] = 78;
            frames[2] = 89;
            frames[3] = 73;
            frames[4] = 68;
            frames[5] = 73;
            frames[6] = 96;
            frames[7] = 71;
            frames[8] = 72;
            frames[9] = 65;
            frames[10] = 87;
            frames[11] = 63;

            int total = 0;
            int index = 0;
            while (index < 100) ;

            total = total / frames[index];
            index = index + 1;

            Console.WriteLine($"The Average is {total}%");
        }
         
    }       


}
