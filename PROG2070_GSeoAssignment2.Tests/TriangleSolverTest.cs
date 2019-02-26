/**
 * File name: TriangleSolverTest.cs
 * UNit test file for Assignment2 of Quality Assurance
 * 
 * Created by :
 *      Gyeonglim Seo, 2019-02-10
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace PROG2070_GSeoAssignment2.Tests
{
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeTest_Given0Negative_ResultIsException()
        {
            //Assert
            Assert.Throws<ArgumentException>(()=>TriangleSolver.Analyze(0,-1,0));
        }
        [Test]
        public void AnalyzeTest_GivenString_ResultIsException()
        {
            //Arrange
            string strDimention = "string";

            //Assert
            Assert.Throws<FormatException>(() => TriangleSolver.Analyze(int.Parse(strDimention), 2, 1));
        }
        [Test]
        public void AnalyzeTest_Given312_ResultIsNotTriangle()
        {
            //Act
            string triangleType = TriangleSolver.Analyze(3,1,2);

            //Assert
            Assert.AreEqual("not a triangle", triangleType);
        }
        [Test]
        public void AnalyzeTest_Given222_ResultIsEquilateral()
        {
            //Act
            string triangleType = TriangleSolver.Analyze(2,2,2);

            //Assert
            Assert.AreEqual("equilateral", triangleType);
        }
        [Test]
        public void AnalyzeTest_Given885_ResultIsIsosceles()
        {
            //Act
            string triangleType = TriangleSolver.Analyze(8, 8, 5);

            //Assert
            Assert.AreEqual("isosceles", triangleType);
        }
        [Test]
        public void AnalyzeTest_Given678_ResultIsScalene()
        {
            //Act
            string triangleType = TriangleSolver.Analyze(6,7,8);

            //Assert
            Assert.AreEqual("scalene", triangleType);
        }
    }
}
