using System;

namespace ArrayPractice {
    class Program {
        static void Main(string[] args)
        {
            //My version
            //int[] frames = new int[100];

            //frames[0] = 71;
            //frames[1] = 78;
            //frames[2] = 89;
            //frames[3] = 73;
            //frames[4] = 68;
            //frames[5] = 73;
            //frames[6] = 96;
            //frames[7] = 71;
            //frames[8] = 72;
            //frames[9] = 65;
            //frames[10] = 87;
            //frames[11] = 63;

            //int total = 0;
            //int index = 0;
            //while (index < 100);

            //total = total / frames[index];
            //index = index + 1;

            //Console.WriteLine($"The Average is {total}%");

            //Gregs Version (correct version)
            int[] TestScores = new int[12]; //the number is twelve is references how many you want. Or, how many buckets

            TestScores[0] = 71;
            TestScores[1] = 78;
            TestScores[2] = 89;
            TestScores[3] = 73;
            TestScores[4] = 68;
            TestScores[5] = 73;
            TestScores[6] = 96;
            TestScores[7] = 71;
            TestScores[8] = 72;
            TestScores[9] = 65;
            TestScores[10] = 87;
            TestScores[11] = 63;

            int total = 0;
            int index = 0;
            while (index < 12) {
                total = total + TestScores[index];
                index = index + 1; //make sure to index the loop otherwise it will create an infinite loop
            }
            int average = total / 12; //to be more accurate in the percentage I could use "double instead of int". Example would be double average = total / 12.0;

            Console.WriteLine($"The Average is {average}%");

        }
         
    }       


}
