namespace CalculateAreaShapeLib
{
    public abstract class Figure
    {
        public string FigureName { get; set; }

        public Figure(string figureName)
        {
            this.FigureName = figureName;
        }

        public abstract double CalcArea();
        public static double CalcFigure(Figure figure) => figure.CalcArea();
    }

}