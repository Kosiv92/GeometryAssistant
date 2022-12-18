using GeometryAssistant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAssistant.Figures
{
    public record struct Triangle : IGeometricFigure
    {
        #region Properties
        /// <summary>
        /// First side length of triangle
        /// </summary>
        public double FirstSideLength { get; init; }

        /// <summary>
        /// Second side length of triangle
        /// </summary>
        public double SecondSideLength { get; init; }

        /// <summary>
        /// Third side length of triangle
        /// </summary>
        public double ThirdSideLength { get; init; }
                
        /// <summary>
        /// Triangle is right
        /// </summary>
        public bool IsRight { get; init; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor of simple triangle with different sides
        /// </summary>
        /// <param name="firstSideLength">First side length of triangle</param>
        /// <param name="secondSideLength">Second side length of triangle</param>
        /// <param name="thirdSideLength">Third side length of triangle</param>
        public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
            ThirdSideLength = thirdSideLength;                        

            IsRight = (Math.Pow(firstSideLength, 2) == Math.Pow(secondSideLength, 2) + Math.Pow(thirdSideLength, 2))
            || (Math.Pow(secondSideLength, 2) == Math.Pow(firstSideLength, 2) + Math.Pow(thirdSideLength, 2))
            || (Math.Pow(thirdSideLength, 2) == Math.Pow(firstSideLength, 2) + Math.Pow(secondSideLength, 2));

        }

        /// <summary>
        /// Constructor of isosceles triangle
        /// </summary>
        /// <param name="longSideLength">Long side length of isosceles triangle</param>
        /// <param name="shortSideLength">Short sides length of isosceles triangle</param>
        public Triangle(double longSideLength, double shortSideLength)
        {
            if(longSideLength <= shortSideLength) throw new Exception("Long side of isosceles triangle can't be less than or equal to short side");
            
            FirstSideLength = longSideLength;

            SecondSideLength = ThirdSideLength = shortSideLength;                        

            IsRight = Math.Pow(longSideLength, 2) == 2.0 * Math.Pow(shortSideLength, 2);
        }

        /// <summary>
        /// Constructor of equilateral triangle
        /// </summary>
        /// <param name="sideLength">Sides length of equilateral triangle</param>
        public Triangle(double sideLength)
        {
            FirstSideLength = SecondSideLength = ThirdSideLength = sideLength;            
            IsRight = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculate area of triangle instance
        /// </summary>
        /// <returns>Area value</returns>
        public double GetAreaValue()
        {
            if (IsRight) return GetRightTriangleArea();                        

            double halfPerimeter = GetPerimeterValue() / 2.0;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSideLength)
                * (halfPerimeter - SecondSideLength)
                * (halfPerimeter - ThirdSideLength));
        }

        /// <summary>
        /// Get value of triangle perimetr
        /// </summary>
        /// <returns></returns>
        public double GetPerimeterValue()
        {
            return FirstSideLength + SecondSideLength + ThirdSideLength;
        }

        /// <summary>
        /// Get value of triangle area
        /// </summary>
        /// <returns></returns>
        private double GetRightTriangleArea()
        {
            double[] sides = { FirstSideLength, SecondSideLength, ThirdSideLength };
            double hippotenuse = sides.Max();
            double[] catets = sides.Where(side => side != hippotenuse).ToArray();
            return (Math.Pow(catets[0], 2) * Math.Pow(catets[1], 2)) / 2.0;
        }                

        #endregion
    }
}
