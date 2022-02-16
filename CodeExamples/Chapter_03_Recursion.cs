using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public int LookForKey(Box mainBox)
        {
            var list = new List<Box>();
            while (list.Any())
            {
                
            }

            return 0;

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
