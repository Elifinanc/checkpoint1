using System;

namespace Checkpoint1Elif
{
    class Program
    {
        public class Array
        {
            //*Méthode remplissage avec saisie d'un tableau unidimentionelle de 4 éléments *//
            static int[] ArrayFill()
            {
                int[] array = new int[4];
                int userNumber;
                int i;
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("You have to write 4 integers of your choice. Please write the integer number " + (i + 1) + " : ");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    array[i] = userNumber;
                }
                return array;
            }

            //*Méthode somme d'un tableau unidimentionelle *//
            static int ArraySum(int[] array)
            {
                int i;
                int sum = 0;
                for (i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }

            //*Méthode moyenne d'un tableau unidimentionelle de 4 éléments *//
            static double ArrayAverage()
            {
                int[] array = new int[4];
                int userNumber;
                int i;
                int sum = 0;
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("You have to write 4 integers of your choice. Please write the integer number " + (i + 1) + " : ");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    array[i] = userNumber;
                    sum += array[i];
                }
                double average;
                average = Convert.ToDouble(sum / array.Length);
                return average;
            }
        }

      


        static void Main(string[] args)
        {
        
            //*Trier un tableau unidimentionelle de 4 éléments par ordre croissant*//
            int [] array = new int[4] { 80, 5, 42, 8 };
            int i;
            int j;
            int temp;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Your numbers in ascending order are:");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
