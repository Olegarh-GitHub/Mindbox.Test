using System.Collections.Generic;

namespace Mindbox.Test.Models.Base
{
    /// <summary>
    /// Базовый класс, описывающий геометрическую фигуру
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Стороны фигуры
        /// </summary>
        public abstract List<FigureSide> Sides { get; }
        
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public abstract float Perimeter { get; }
        
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract float Area { get; }
    }
}