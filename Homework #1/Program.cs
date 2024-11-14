using System;
//Seba Opadah Alahdab
//202310395
class Homework
{
    static void Main()
    {
        try
        {
            Random random = new Random();
            int min = 0;
            int max;

            Console.WriteLine("Enter min number:");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max number:");
            max = int.Parse(Console.ReadLine());

            int[] a = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                int num = random.Next(min, max + 1); 
                a[i] = num;
            }
            int d =max- min+1;
            int[,] frequencyArray = new int[d, 2];
            int Count =0;

            for (int i = 0; i < 1000; i++)
            {
                int num = a[i];
                int j;

                for (j = 0; j < Count; j++)
                {
                    if (frequencyArray[j, 0] == num)
                    {
                        frequencyArray[j, 1]++;
                        break;
                    }
                }
                if (j == Count)
                {
                    frequencyArray[Count, 0] = num;
                    frequencyArray[Count, 1] = 1;
                    Count++;
                }
            }


            Console.WriteLine("Number\tFrequency");
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine($"{frequencyArray[i, 0]}\t{frequencyArray[i,1]}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid number: " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Array index out of range: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
