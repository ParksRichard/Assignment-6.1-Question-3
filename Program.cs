/*
Give an integer array nums, move all 0's to the end of it
while maintaining the relative order of non-zero elements
*/

//static array?
//but now linkedlist

namespace Assignment_6._1_Question_3
{
    internal class Program
    {
        //setup array
        static void MovingZeros(int[] nums)
        {
            int zeroindex = 0;
            //count and increment array index
            //find way to swap 0's
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) //checking non-zero numbers
                {
                    int move = nums[zeroindex]; //to new array
                    nums[zeroindex] = nums[i];
                    nums[i] = move;

                    zeroindex++;
                }
            }
        }

        //create input and output unless hardcoded
        //print results
        static void Main(string[] args)
        {
            //hardcode to start
            int[] nums = { 0, 1, 0, 3, 12 };

            //also need to include intial array
            Console.WriteLine("Initial Array:");

            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); 

            MovingZeros(nums);

            //print mod array
            Console.WriteLine("Array after zeros:"); //me after linkedlist.jpg
            foreach (var num in nums)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("");
            //why did this come out vertically? because loop and not full string?
        }
    }
}
