/**
 * File name: TriangleSolver.cs
 * Calculate three dimensions for finding out a triangle type
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
    public static class TriangleSolver
    {
        /// <summary>
        /// This method accepts three integers as an input and returns a triangle's type
        /// </summary>
        /// <param name="firstDimension"></param> The longgest dimention
        /// <param name="secondDimension"></param>
        /// <param name="thirdDimension"></param>
        /// <returns></returns>
        public static string Analyze(int firstDimension, int secondDimension, int thirdDimension)
        {
            string triangleType = "";
            if (firstDimension<=0 || secondDimension<=0 || thirdDimension <=0 ) {
                throw new System.ArgumentException("Please enter more than 0\n");
            }else if (secondDimension+thirdDimension<=firstDimension)
            {
                triangleType = "not a triangle";
            }
            else
            {
                if (firstDimension == secondDimension && secondDimension == thirdDimension)
                {
                    triangleType = "equilateral";
                }
                else if (firstDimension == secondDimension || firstDimension == thirdDimension || secondDimension == thirdDimension)
                {
                    triangleType = "isosceles";
                }
                else if (firstDimension != secondDimension && secondDimension != thirdDimension && firstDimension != thirdDimension)
                {
                    triangleType = "scalene";
                }
            }

            return triangleType;
        }
    }
}
