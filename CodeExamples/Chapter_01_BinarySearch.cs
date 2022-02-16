namespace CodeExamples
{
    public static class Chapter_01_BinarySearch
    {
        public static int BinarySearch(int[] list, int item) 
        {
            // low and high to keep track of which part of the list you'l search in
            int low = 0;      
            int high = list.Length - 1;
            
            // while you have not narrowed it down to one element
            while (low <= high) 
            {
                // check the middle element
                int mid = (low + high) / 2; 
                int guess = list[mid];  
                
                if (guess == item) //found the item
                    return mid;
                
                if (guess > item) // the guess was too high
                    high = mid - 1;
                else // the guess was too low
                    low = mid + 1;
            }
        
            return -1; // the item does not exist
        }
    }
}