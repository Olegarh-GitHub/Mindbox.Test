using System;
using System.Collections.Generic;
using System.Linq;
using Mindbox.Test.Enums;
using Mindbox.Test.Models;

namespace Mindbox.Test.Extensions
{
    /// <summary>
    /// Методы расширения треугольника
    /// </summary>
    public static class TriangleExtensions
    {
        /// <summary>
        /// Определяет тип треугольника
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Тип треугольника, представленный в перечислении <see cref="TriangleType"/></returns>
        public static TriangleType DefineTriangleType(this Triangle triangle)
        {
            bool isEquiliteral = triangle.IsEquilateral();

            if (isEquiliteral)
                return TriangleType.Equilateral;
            
            bool isIsosceles = triangle.IsIsosceles();

            if (isIsosceles)
                return TriangleType.Isosceles;

            bool isRectangular = triangle.IsRectangular();

            if (isRectangular)
                return TriangleType.Rectangular;

            return TriangleType.Regular;
        }

        /// <summary>
        /// Является ли треугольник равнобедренным
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Да/нет</returns>
        public static bool IsIsosceles(this Triangle triangle)
        {
            bool hasSameSides = triangle.Sides
                .GroupBy(side => side.Size)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .Any();

            return hasSameSides;
        }
        
        /// <summary>
        /// Является ли треугольник равносторонним
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Да/нет</returns>
        public static bool IsEquilateral(this Triangle triangle)
        {
            bool isAllSidesAreSame = triangle.Sides
                .GroupBy(side => side.Size)
                .Any(group => group.Count() == 3);

            return isAllSidesAreSame;
        }
        
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Да/нет</returns>
        public static bool IsRectangular(this Triangle triangle)
        {
            float biggestSide = triangle.Sides.Max(side => side.Size);

            List<float> otherSides = triangle.Sides
                .Select(side => side.Size)
                .Except(new [] {biggestSide})
                .ToList();

            float biggestSideSquared = (float) Math.Pow(biggestSide, 2);

            float otherSidesSquaredSum = (float) otherSides.Select(side => Math.Pow(side, 2)).Sum(); // Теорема Пифагора

            return biggestSideSquared == otherSidesSquaredSum;
        }
    }
}