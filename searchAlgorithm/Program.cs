using System;

namespace SearchAlgorthm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        //Get the number of element to store in the array
        int i;

        public void input ()
        {
            while (true)
            {
                Console.Write("Enter the number of elemets in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
                
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++) ;
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
            

        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //Accept the number to be serached
                Console.Write("\nEnter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //Obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements int the array
                while ((item != arr[mid]) && (lowerbound <= upperbound)) ;
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;

                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\nContiue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            //search the number to be comparison
            int ctr;
            do
            {
                //accept the number to be seacrh
                Console.Write("\nEnter the element you want to search : ");
                int item = Convert.ToInt32((Console.ReadLine()));

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position" + (i + 1).ToString());
                        break;

                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\nNumber of comparison : " + ctr);
                Console.WriteLine("\nContiue search (y/n:");
                ch = char.Parse(Console.ReadLine());



            } while ((ch == 'y') || (ch == 'Y'));
            

        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("Menu option");
                Console.WriteLine("================");
                Console.WriteLine("1.Linear Search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice (1,2,3 : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Linear Search ");
                        Console.WriteLine("---------------------");
                        mylist.input();
                        mylist.LinearSearch();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Binary Search ");
                        Console.WriteLine("---------------------");
                        mylist.input();
                        mylist.BinarySearch();
                        break ;
                    case 3:
                        Console.WriteLine("exit.");
                        break ;
                    default:
                        Console.WriteLine("error");
                        break ;


                }
                //to exit from the console 
                Console.WriteLine("\n\nPress Return to exit");
                Console.ReadLine();
            }while (pilihanmenu != 3);
        }

    }
}