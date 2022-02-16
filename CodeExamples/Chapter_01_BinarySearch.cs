namespace CodeExamples
{
    public static class Chapter_01_BinarySearch
    {
        public static int BinarySearch(int[] list, int item) 
        {
            int low = 0;
            int high = list.Length - 1;

            while (low <= high) 
            {
                int mid = (low + high) / 2;
                int guess = list[mid];

                if (guess == item)
                    return mid;
                if (guess > item)
                    high = mid - 1;
                if (guess < item)
                    low = mid + 1;
            }
        
            return -1;
        }
    }
}