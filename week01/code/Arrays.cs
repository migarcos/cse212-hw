using System.Dynamic;

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

        // the result should be a double, we declare this var to track de multiples
        var result = new double[length];

        // to complete te result use 'lenth' as capacity info
        for (int i = 0; i < length; i++)
        {
            // a new element is added ro the array but using the position index more one 
            // the reason the fsr element is number * 1 but in index 0
            result[i] =  number * ( i  + 1 );
        }

        return result; // replace this return statement with your own
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

        // declate a list to save the final values 
        var start = new List<int> {};
        // add the final range values from data
        start.AddRange(data.GetRange(data.Count - amount, amount));
        // declate a list to save the first values 
        var end = new List<int> {};
        // add the first range values from data
        end.AddRange(data.GetRange(0, data.Count - amount));
        // clean the original list
        data.Clear();
        // add the lastest as first
        data.AddRange(start);
        // add the first range values as lastest
        data.AddRange(end);        
    }
}
