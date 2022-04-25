using System.Collections.Generic;

namespace Katas.CodeKatas
{
    /** 
     * The binary Chop is used to sort through an ordered list 
     * and find the position of a target element. 
     * 
     * This example takes a list of integers, allows the user to find the 
     * index of a given value in the list. 
     * 
     * If it can't be found then return -1
     */

    public sealed class BinarySearchService
    {
        /**
         * Binary Sort/Chop using iteration. 
         * Looping over the same code again and agaib while 
         * The min number is lesser than or equal to the max number
         * 
         * NOTE: This method assumes that you are starting the chop
         * From the start and end of the List. 
        */
        public static int ChopIterative(List<int> sortedList, int value)
        {
            var minNumber = 0;
            var maxNumber = sortedList.Count - 1;
            
            while (minNumber <= maxNumber)
            {
                var middleValue = (minNumber + maxNumber) / 2;

                if (sortedList[middleValue] == value)
                {
                    return middleValue;
                }

                if (sortedList[middleValue] > value)
                {
                    maxNumber = middleValue - 1;
                }

                if (sortedList[middleValue] < value)
                {
                    minNumber = middleValue + 1;
                }
            }

            return -1;
        }

        /** 
         * Binary Search/Chop using recursion. 
         * 
         * Recall the method every time the result is not found in the List. 
         * This method needs a start and an end index to search against. 
         * 
         * The yielded result is the same as the iteration. 
         */ 
        public static int ChopRecursively(List<int> sortedList, int value, int? minNumber, int? maxNumber)
        {
            var startIndex = (int)(minNumber != null ? minNumber : 0);
            var endIndex = (int)(maxNumber != null ? maxNumber : sortedList.Count - 1);

            if (startIndex <= endIndex)
            {
                var middleValue = startIndex + (endIndex - startIndex) / 2;

                if (sortedList[middleValue] == value)
                    return middleValue;

                if (sortedList[middleValue] > value)
                    return ChopRecursively(sortedList, value, minNumber, middleValue - 1);

                return ChopRecursively(sortedList, value, middleValue + 1, endIndex);
            }

            return -1;
        }
    }
}
