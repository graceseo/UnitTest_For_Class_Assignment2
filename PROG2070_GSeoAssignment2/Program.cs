/**
 * File name: Program.cs
 * the main class for Assignment2 of Quality Assurance
 * 
 * Created by :
 *      Gyeonglim Seo, 2019-02-10
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_GSeoAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensionsList = new List<int>();

            //It's purpose is to check how many numbers inputted
            int inputNoCount = 1;

            //menu number
            string inMenu = "";

            //flags for While statements
            bool correctMenuNo = true;
            //bool correctDimension = true;
            
            do
            {
                Console.WriteLine("###################################");
                Console.WriteLine("### 1. Enter triangle dimensions###");
                Console.WriteLine("### 2. Exit                     ###");
                Console.WriteLine("###################################\n");
                Console.Write("Please enter a number : ");
                inMenu = Console.ReadLine();

                if (inMenu == "2")
                {
                    //Exit
                    correctMenuNo = false;
                }
                else if (inMenu == "1")
                {
                    //initialize a List and a number counting variable
                    dimensionsList.Clear();
                    inputNoCount = 1;

                    Console.WriteLine("\nPlease enter three integers \n");

                    while (inputNoCount <= 3)
                    {
                        Console.Write(inputNoCount + "st number: ");
                        try
                        {
                            int inputDimensiton = 0;
                            inputDimensiton = int.Parse(Console.ReadLine());

                            //check input value is positive
                            if (inputDimensiton>0) {
                                dimensionsList.Add(inputDimensiton);

                                //Only a correct number inputted, increase the inputNoCount
                                inputNoCount++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid value, please enter a positive integer!!\n");
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid value, please enter a integer!!\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Something wrong!, please try again!\n");
                        }
                    }

                    //sort for finding the longgest dimension
                    dimensionsList.Sort();
                    
                    //form a triangle or not
                    if ((dimensionsList[0] + dimensionsList[1])>dimensionsList[2])
                    {
                        Console.WriteLine("\nIt is a triangle\n");

                        //call a static method called Analyze
                        string outReport=TriangleSolver.Analyze(dimensionsList[0],dimensionsList[1],dimensionsList[2]);

                        Console.WriteLine("This triangle is "+outReport+"\n");
                    }
                    else
                    {
                        Console.WriteLine("\n+++++++++++It is not a triangle!!\n");
                    }
                }
                else
                {
                    //if input number is not 1 or 2, ask a number again
                    Console.WriteLine("\nInvalid value entered, please try again!\n");
                }
            } while (correctMenuNo);
        }
    }
}
