using static System.Console;
// // Create a program named IntegerFacts whose Main() method declares an array of 10 integers. 
// Call a method to interactively fill the array with any number of values up to 10 or until a sentinel value is entered. 
// If an entry is not an integer, reprompt the user. Call a second method that accepts out parameters if
// or the highest value in the array, lowest value in the array, sum of the values in the array, 
// and arithmetic average. In the Main() method, display all the statistics.

class IntegerFactss
{
    static void Main()
    {

        int max;
        int min;
        int[] nums = new int[10];
        IntegerFacts(out max, out min,  nums);
        WriteLine(string.Join(" ", nums));
        WriteLine("max is {0}, min is {1}", max, min);



    }
        static void IntegerFacts(out int max, out int min, int[] nums){
        int COUNT = 10;
        int SENTINEL = 911;
        int cnt = 0;
        do {
            WriteLine("Give me one more number");
            int n;
            bool successful = int.TryParse(ReadLine(), out n);
            if( !successful){
                WriteLine("Invalid entry");
                continue;  
            }
            if (n == SENTINEL)
                break; 
            nums[cnt] = n;
            cnt++;
        }while(cnt < COUNT);

            max = nums.Max();
            min = nums.Min();
    }
}