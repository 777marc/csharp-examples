using System;

namespace csharp_examples.Boxing
{
    public class Boxer
    {
        public void SetBox()
        {
            int num = 10;
            object numObj = num;
            Console.WriteLine("Number: {0}", numObj.ToString());
        }

        public void UnBox()
        {
            int num = 10;
            object numObj = num;
            
            Console.WriteLine("Number: {0}", (int)numObj);
        }
    }
}