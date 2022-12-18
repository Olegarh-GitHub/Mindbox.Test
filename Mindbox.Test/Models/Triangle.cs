using System;
using System.Collections.Generic;
using System.Linq;
using Mindbox.Test.Enums;
using Mindbox.Test.Extensions;
using Mindbox.Test.Models.Base;

namespace Mindbox.Test.Models
{
    /// <summary>
    /// Геометрическая фигура треугольник
    /// </summary>
    public class Triangle : Figure
    {

        public Triangle(float a, float b, float c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
                throw new ArgumentException("Треугольник с указанными сторонами не может существовать");

            Sides = new List<FigureSide>()
            {
                new (a), new (b), new (c)
            };
        }

        public override List<FigureSide> Sides { get; }
        public override float Perimeter => Sides.Sum(side => side.Size);
        private float HalfPerimeter => Perimeter / 2f;
        
        public override float Area => (float) Math.Sqrt(HalfPerimeter * (HalfPerimeter - Sides[0].Size) * (HalfPerimeter - Sides[1].Size) * (HalfPerimeter - Sides[2].Size));

        /// <summary>
        /// Тип треугольника
        /// </summary>
        public TriangleType Type => this.DefineTriangleType();

        public override string ToString()
        {
            return $"Стороны треугольника: {string.Join(",", Sides.Select(side => side.Size))}\n" +
                   $"Площадь треугольника: {Area}\n" +
                   $"Периметр треугольника: {Perimeter}\n" +
                   $"Тип треугольника: {Type}\n";
        }
    }
}