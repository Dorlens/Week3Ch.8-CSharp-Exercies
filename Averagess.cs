using static System.Console;

// Write a program named Averages that includes a method that accepts any number of numeric parameters, displays them, 
// and displays their average. Demonstrate that the method works correctly when passed one, two, or three numbers, or an array of numbers.
class Averagess
{
    static void Main()
    {

         Averages(1,5, 12);
        Averages(1,5, 13, 14, 17);
        Averages(1,5, 13,10, 100, 1000, 911,999);


    }
        static void Averages(params int[] nums){
        int sum =0;
        foreach (int n in nums){
            sum += n;
        }
        int mean = sum / nums.Length;
        WriteLine("The average is {0}", mean);
    }

}