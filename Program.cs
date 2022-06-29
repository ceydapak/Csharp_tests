/*using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            //string string1 = " never odd or even" ;
            // string string2 = "book is life";
            //string reversedString = new string(string1.Reverse().ToArray());
            // Console.WriteLine(reversedString);*/


            /*Console.WriteLine(string1.SequenceEqual(string1.Reverse()));
            Console.Write(string2.SequenceEqual(string2.Reverse()));*/

            //string string2 = "book is life";
            //string Word = new string(string1.Distinct().ToArray());

            // string[] a = Word.Split(' ');
            //Array.Reverse(a);


            //Console.WriteLine(Word);

            /* string string3 = "apron";
             int j = 0;
             int i = 0;

             for (i = 1; i <= string3.Length; i++)
             {
                 for (j = 0; j <= string3.Length - i; j++)
                 {

                     // Using Substring() function
                     Console.WriteLine(string3.Substring(j, i));
                 }
             }*/
            //----------------------------------------------------------------------------------------------------------------------------------------------------//
            /*
                        int[] arr = new int[] { 4, 9, 7, 1, 2, 8 };
                        int n = 3;
                        Console.Write("Original Array :");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write(arr[i] + " ");
                        }

                        for (int i = 0; i < n; i++)
                        {
                            int j, first;
                            first = arr[0];

                            for (j = 0; j < arr.Length - 1;  j++)
                            {

                                arr[j] = arr[j + 1];
                            }

                            arr[arr.Length - 1] = first;
                        }

                        Console.WriteLine();

                        Console.WriteLine("Array after left rotation: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write(arr[i] + " ");
                        }


//------------------------------------------------------------------------------------------------------------------------//
                        Console.WriteLine();

//------------------------------------------------------------------------------------------------------------------------//
                        //Initialize array   
                        int[] arr2 = new int[] { 4, 9, 7, 1, 2, 8 };
                        //n determine the number of times an array should be rotated.  
                        int n2 = 3;

                        //Displays original array  
                        Console.WriteLine("Original array: ");
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            Console.Write(arr2[i] + " ");
                        }

                        //Rotate the given array by n times toward right  
                        for (int i = 0; i < n2; i++)
                        {
                            int j, last;
                            //Stores the last element of array  
                            last = arr2[arr2.Length - 1];

                            for (j = arr2.Length - 1; j > 0; j--)
                            {
                                //Shift element of array by one  
                                arr2[j] = arr2[j - 1];
                            }
                            //Last element of array will be added to the start of array.  
                            arr2[0] = last;
                        }

                        Console.WriteLine();

                        //Displays resulting array after rotation  
                        Console.WriteLine("Array after right rotation: ");
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            Console.Write(arr2[i] + " ");
                        }
            */
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            /*
                        int x = 285;
                        int result = Check_Prime(x);
                        if (result == 0)
                        {
                            Console.WriteLine("{0} is not a prime number", x);
                        }
                        else
                        {
                            Console.WriteLine("{0} is  a prime number", x);
                        }
            */
            //----------------------------------------------------------------------------------------------------------------------------------------------------------//

            /*int x = 285;
            int sum = 0;
            while (x != 0)
            {
                int rem;
                x = Math.DivRem(x, 10, out rem);
                sum += rem;
            }
            Console.WriteLine(sum);*/
            //-------------------------------------------------------------------------------------------------------------------------------------------//
            /* int[] a = new int[] { 4, 9, 7, 1, 2, 8 };
             int largest = int.MinValue;
             int second = int.MinValue;
             int third = int.MinValue;
             foreach (int i in a)
             {
                 if (i > largest)
                 {
                     second = largest;
                     third = second;
                     largest = i;
                 }
                 else if (i > second)
                 {
                     third = second;
                     second = i;

                 }
                 else if (i > third)
                 {
                     third = i;
                 }

             }
             System.Console.WriteLine(third);*/

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            /* public static int Check_Prime(int number)
              {
                  int i;
                  for (i = 2; i <= number - 1; i++)
                  {
                      if (number % i == 0)
                      {
                          return 0;
                      }
                  }
                  if (i == number)
                  {
                      return 1;
                  }
                  return 0;
              }*/
            //------------------------------------------------------------------------------------------------------------------------//


            /*  int[] arraya = new int[] { 4, 9, 7, 1, 2, 8 };

              int index= 0;
              int rows = 2;
              int cols = 3;

              int[,] TwoDimensionalArray = new int[rows , cols];


              for (int x = 0; x < rows; x++)
              {
                  for (int y = 0; y < cols; y++)
                  {
                      TwoDimensionalArray[x, y] = arraya[index];
                      index++;
                  }
              }

              Console.WriteLine("2D Array Elements : ");
              foreach (int item in TwoDimensionalArray)
              {
                  Console.Write(item + " ");
              }
            */


//--------------------------------------------------------------------------------------------------------------------------------//
           /* Queue q = new Queue();
            q.enQueue(1);
            q.enQueue(2);
            q.enQueue(3);

            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue());

        }*/


//----------------------------------------------------------------------------------------------------------------------//
      /*  public class Queue
        {
            public Stack s1 = new Stack();
            public Stack s2 = new Stack();

            public void enQueue(int x)
            {
                // Move all elements from s1 to s2
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                    //s1.Pop();
                }

                // Push item into s1
                s1.Push(x);

                // Push everything back to s1
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                    //s2.Pop();
                }
            }

            // Dequeue an item from the queue
            public int deQueue()
            {
                // if first stack is empty
                if (s1.Count == 0)
                {
                    Console.WriteLine("Q is Empty");

                }

                // Return top of s1
                int x = (int)s1.Peek();
                s1.Pop();
                return x;
            }
        }


    }
}*/