using System.Collections.Generic;

namespace Katas.CodeKatas
{
    public sealed class BinarySearchService
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

        public static int ChopRecursively(List<int> sortedList, int value, int? minNumber, int? maxNumber)
        {

            if (sortedList.Count == 0)
                return -1;

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
