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

        // initialize new empty result array
        double[] result = new double[length];
        // initialize current multiple
        double currentMultiple = number;
        // create a for loop starting with number, ending w/ length - 1
        for (int i = 0; i < length; i++) {
        // append to result array
            result[i] = currentMultiple;
        // multiply current multiple * current multiple
            currentMultiple += number;
        }
        
        // return result array
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

        // handle the wrapping
        int actualAmount = amount % data.Count;
        // subtract list length - amount to identify pivot index (5 - 9) = 4
        int pivotIndex = data.Count - actualAmount;
        // slice right side of list from left side of list
        List<int> rightSide = data.GetRange(pivotIndex, actualAmount);
        List<int> leftSide = data.GetRange(0, pivotIndex);
        // clear original list
        data.Clear();
        // add right side to result list
        data.AddRange(rightSide);
        // add left side to result list
        data.AddRange(leftSide);
    }
}
