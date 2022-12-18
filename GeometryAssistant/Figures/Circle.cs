using GeometryAssistant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryAssistant.Figures
{
    public record struct Circle : IGeometricFigure
    {
        #region Properties

        /// <summary>
        /// Radius of circle
        /// </summary>
        public double Radius { get; init; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor of circle
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        public Circle(double radius) => Radius = radius;

        #endregion

        #region Methods

        /// <summary>
        /// Get value of circle's area
        /// </summary>
        /// <returns></returns>
        public double GetAreaValue() => Math.PI * Math.Pow(Radius, 2);
        
        /// <summary>
        /// Get value of circle's perimeter
        /// </summary>
        /// <returns></returns>
        public double GetPerimeterValue() => 2.0 * Radius * Math.PI;
        
        #endregion
    }
}
