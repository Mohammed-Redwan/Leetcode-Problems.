public class Solution {
    public int[] PlusOne(int[] digits) {
        int index = digits.Length - 1;

        while(index >= 0 && digits[index] == 9)
        {
            digits[index] = 0;
            index--;
        }

        if (index >= 0)
        {
            digits[index]++;
            return digits;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;







        // int index = digits.Length - 1;

        // while (index >= 0 && digits[index] == 9) {
        //     digits[index] = 0; 
        //     index--; 
        // }

        
        // if (index >= 0) {
        //     digits[index]++; 
        //     return digits;
        // }

        // int[] result = new int[digits.Length + 1];
        // result[0] = 1; 
        // return result;
        









        // int currentCheckIndex = digits.Length - 1;

        // int[] newDigits;
        // if (digits[currentCheckIndex] == 9)
        // {
        //     newDigits = new int[digits.Length + 1];
        //     while (digits[currentCheckIndex] == 9)
        //     {
        //         Console.WriteLine(currentCheckIndex);
        //         newDigits[currentCheckIndex + 1] = 0;
        //         if (currentCheckIndex < 0)
        //             currentCheckIndex--;
        //     }
        //     newDigits[currentCheckIndex] = 1;
        //     return newDigits;
        // }
        //     digits[currentCheckIndex]++;
        // return digits;

    }
}