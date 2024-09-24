using static System.Console;

// // Create a program named Reverse3 whose Main() method declares three integers named firstInt, middleInt, and lastInt. 
// Assign values to the variables, display them, and then pass them to a method that accepts them as reference variables,
//  places the first value in the lastInt variable, and places the last value in the firstInt variable. In the Main() method,
//   display the three variables again, demonstrating that their positions have been reversed.





class Reverse3 
{

    static void Main()
    {
        int first = 1;
        int middle = 5;
        int last =99;
        Swap3(ref first, ref middle, ref last);
        WriteLine("first: {0}, last {1}", first, last);


    }

    static void Swap3( ref int first, ref int temp, ref int last)
    {
        temp = first;
        first = last;
        last = temp;
    }




}