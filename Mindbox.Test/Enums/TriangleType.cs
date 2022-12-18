namespace Mindbox.Test.Enums
{
    /// <summary>
    /// Тип треугольника
    /// </summary>
    public enum TriangleType
    {
        /// <summary>
        /// Обычный (без явного типа)
        /// </summary>
        Regular,
        
        /// <summary>
        /// Прямоугольный (один из углов равен 90 градусов)
        /// </summary>
        Rectangular,
        
        /// <summary>
        /// Равнобедренный (две стороны имеют одинаковую длину)
        /// </summary>
        Isosceles,
        
        /// <summary>
        /// Равносторонний (все стороны имеют одинаковую длину)
        /// </summary>
        Equilateral
    }
}