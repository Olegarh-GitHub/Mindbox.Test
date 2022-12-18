using System;
using System.Collections.Generic;
using Mindbox.Test.Models.Base;

namespace Mindbox.Test.Models
{
    /// <summary>
    /// Геометрическая фигура круг
    /// </summary>
    public class Circle : Figure
    {
        public Circle(float radius)
        {
            if (radius == 0)
                throw new ArgumentException("Не возможно существование круга с радиусом 0");
            
            Radius = radius;
        }
        
        /// <summary>
        /// Радиус круга
        /// </summary>
        public float Radius { get; }
        
        /// <summary>
        /// Диаметр круга
        /// </summary>
        public float Diameter => Radius * 2f;

        /// <summary>
        /// У круга одна "сторона" - его длина (периметр)
        /// </summary>
        public override List<FigureSide> Sides => new List<FigureSide>() { new (Perimeter) };
        
        /// <summary>
        /// Длина окружности (периметр круга)
        /// </summary>
        public override float Perimeter => (float) (Diameter * Math.PI);
        
        /// <summary>
        /// Площадь круга
        /// </summary>
        public override float Area => (float) (Math.Pow(Radius, 2) * Math.PI);

        public override string ToString()
        {
            return $"Радиус круга: {Radius}\n" + 
                   $"Площадь круга: {Area}\n" + 
                   $"Длина окружности: {Perimeter}\n";
        }
    }
}