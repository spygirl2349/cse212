using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // ***PLAN***
        // 1. Create an array.
        // 2. Fill the array with multiples of the first number passed in for the length decided by the 2nd
        // number that is passed in.
        // 3. Return the array.
        // ***END PLAN***
        double [] multiples = new double[length];
        multiples[0] = number; 
        int j = 0;
        for (int i = 1; i < length; i++)
        {
            multiples[i] = multiples[j] + number; 
            j++;
        };


        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // *** PLAN ***
        // 1. Get the length of the list  
        // 2. use getRange method to split data
        // 2. Make 2 lists, and combine 2 lists into one in correct order.
        int length = data.Count ;
        List<int> list1 = data.GetRange(length - amount, amount);
        List<int> list2 = data.GetRange(0, length - amount);

        list1.AddRange(list2);

        data.Clear();
        data.AddRange(list1);
    }
}
