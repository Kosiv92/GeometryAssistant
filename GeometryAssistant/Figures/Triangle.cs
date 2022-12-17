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
        /// Triangle is isosceles
        /// </summary>
        public bool IsIsosceles { get; init; }

        /// <summary>
        /// Triangle is isosceles
        /// </summary>
        public bool IsEquilateral { get; init; }

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

            IsIsosceles = firstSideLength == secondSideLength
                || firstSideLength == thirdSideLength
                || secondSideLength == thirdSideLength;

            IsEquilateral = firstSideLength == secondSideLength
                && secondSideLength == thirdSideLength;

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
            FirstSideLength = longSideLength;

            SecondSideLength = ThirdSideLength = shortSideLength;

            IsIsosceles = true;

            IsEquilateral = longSideLength == shortSideLength ? true : false;

            IsRight = IsEquilateral ? false :
                Math.Pow(longSideLength, 2) == 2 * Math.Pow(shortSideLength, 2) ? true : false;


        }

        /// <summary>
        /// Constructor of equilateral triangle
        /// </summary>
        /// <param name="sideLength">Sides length of equilateral triangle</param>
        public Triangle(double sideLength)
        {
            FirstSideLength = SecondSideLength = ThirdSideLength = sideLength;
            IsEquilateral = IsIsosceles = true;
            IsRight = false;
        }

        #endregion

        #region Methods

        public double GetAreaValue()
        {
            throw new NotImplementedException();
        }

        public double GetPerimetrValue()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
