using System.Threading.Channels;

namespace SumOfarray
{
    public class Program
    {

        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                {
                    Console.WriteLine("enter array elements:");
                    arr[i] = int.Parse(Console.ReadLine());
                    sum = sum + arr[i];
                }
            }
            return sum;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("enter the size of the array:");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                int sum = ArraySum(arr);
                Console.WriteLine("array sum is:"+sum);
            }
        }
    }

