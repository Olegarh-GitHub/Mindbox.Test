namespace Mindbox.Test.Models.Base
{
    /// <summary>
    /// Сторона фигуры
    /// </summary>
    public class FigureSide
    {
        /// <summary>
        /// Размер стороны
        /// </summary>
        public float Size { get; set; }

        public FigureSide(float size)
        {
            Size = size;
        }
    }
}