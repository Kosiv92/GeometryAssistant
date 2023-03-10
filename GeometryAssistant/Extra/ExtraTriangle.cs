using GeometryAssistant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAssistant.Extra
{
    /// <summary>
    /// Triangle with properties that show if it isosceles or equilateral
    /// </summary>
    public record struct ExtraTriangle : IGeometricFigure
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
        public ExtraTriangle(double firstSideLength, double secondSideLength, double thirdSideLength)
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
        public ExtraTriangle(double longSideLength, double shortSideLength)
        {
            FirstSideLength = longSideLength;

            SecondSideLength = ThirdSideLength = shortSideLength;

            IsIsosceles = true;

            IsEquilateral = longSideLength == shortSideLength ? true : false;

            IsRight = IsEquilateral ? false :
                Math.Pow(longSideLength, 2) == 2.0 * Math.Pow(shortSideLength, 2) ? true : false;
        }

        /// <summary>
        /// Constructor of equilateral triangle
        /// </summary>
        /// <param name="sideLength">Sides length of equilateral triangle</param>
        public ExtraTriangle(double sideLength)
        {
            FirstSideLength = SecondSideLength = ThirdSideLength = sideLength;
            IsEquilateral = IsIsosceles = true;
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
            if (IsEquilateral) return (Math.Pow(FirstSideLength, 2) * Math.Sqrt(3)) / 4.0;

            if (IsRight) return GetRightTriangleArea();

            if (IsIsosceles) return GetIsoscelesTriangleArea();

            double halfPerimeter = GetPerimeterValue() / 2.0;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSideLength)
                * (halfPerimeter - SecondSideLength)
                * (halfPerimeter - ThirdSideLength));
        }

        public double GetPerimeterValue()
        {
            return FirstSideLength + SecondSideLength + ThirdSideLength;
        }

        private double GetRightTriangleArea()
        {
            double[] sides = { FirstSideLength, SecondSideLength, ThirdSideLength };
            double hippotenuse = sides.Max();
            double[] catets = sides.Where(side => side != hippotenuse).ToArray();
            return (Math.Pow(catets[0], 2) * Math.Pow(catets[1], 2)) / 2.0;
        }

        private double GetEquilateralTriangleArea()
            => (Math.Pow(FirstSideLength, 2) * Math.Sqrt(3)) / 4.0;
        
        private double GetIsoscelesTriangleArea()
        {
            double[] sides = { FirstSideLength, SecondSideLength, ThirdSideLength };
            double longSide = sides.Max();
            double shortSide = sides.Where(side => side != longSide).FirstOrDefault();
            return (longSide * (Math.Pow(longSide / 2.0, 2) + Math.Pow(shortSide, 2))) / 2.0;
        }


        #endregion
    }
}
