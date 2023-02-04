using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Summator 
{
    public static class Summator 
    {
        public static int sum(int[] arr)
        {
            int sum = arr[0];

            for (int i = 1; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            return sum;
            
        }

        public static void Test_TwoNumbers()
        {
            if (sum(new int[] { 1, 2 }) != 3)
            {

                throw new Exception(" 1+2 != 3");
            }else
            {
                Console.WriteLine("Test Pass!");
             
            }
                
            
        }
    }
}

