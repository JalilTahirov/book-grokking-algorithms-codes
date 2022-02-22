using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeExamples
{
    public class Chapter_03_Recursion
    {
        // Orgonize boxes inside the boxes
        public Box OrgonizeBoxes()
        {
            var box3 = new Box(null, 4);
            var box2 = new Box(box3, null);
            var box1 = new Box(box2,null);
            
            return box1;
        }
        
        public void LookForKey(Box mainBox)
        {
            var list = new List<Box>();
            list.Add(mainBox);
            while (list.Any())
            {
                var box = list.FirstOrDefault();
                if (box.Key.HasValue)
                {
                    Console.Write("found in loop ");

                    Console.WriteLine(box.Key.Value);

                    return;
                }
                else
                {
                    list.Add(box);
                }

            }
        }

        public void LookForKeyRecursively(Box box)
        {
            if (box.Key == null)
            {
                LookForKeyRecursively(box.InnerBox);
            }
            else
            {
                Console.Write("found in recursion ");
                Console.WriteLine(box.Key.Value);
                return;
            }
        }


        public void CountDown(int number)
        {
            Console.WriteLine(number);
            if (number == 0)
            {
                return;
            }
            CountDown(number-1);
        }

        public int factorial(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * factorial(num-1);
        }
        

    }

    /// lets assume the box is an object which can contain box and also key which is nullable
    public class Box 
    {
        public Box(Box box, int? key = null)
        {
            InnerBox = box;
            Key = key;
        }
        public Box InnerBox { get; set; }
        public int? Key { get; set; }
    }
}
