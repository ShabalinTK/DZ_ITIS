using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestrovaya
{
    public class GraphicPic
    {
        private List<Figure> figures;

        public GraphicPic(List<Figure> figures)
        {
            this.figures = figures;
        }

        public GraphicPic(string filename)
        {
            figures = ReadFile(filename);
        }
        public List<Figure> ReadFile(string filemane)
        {
            var result = new List<Figure>();
            using (var sr = new StreamReader(filemane))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var str = line.Split(';');
                    var type = int.Parse(str[0]);
                    var leftUpX = double.Parse(str[1]);
                    var leftUpY = double.Parse(str[2]);
                    var rightDownX = double.Parse(str[3]);
                    var rightDownY = double.Parse(str[4]);
                    var color = int.Parse(str[5]);
                    var figure = new Figure(type, leftUpX, leftUpY, rightDownX, rightDownY, color);
                    result.Add(figure);
                }
            }
            return result;
        }
        public void Show()
        {
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.ToString());
            }
        }

        public void Delete(int i)
        {
            for (int j = figures.Count - 1; j >= 0; j--)
            {
                var figure = figures[j];
                if ((int)figure.Type == i)
                {
                    figures.Remove(figure);
                }
            }
        }

        public void Insert(Figure f)
        {
            foreach (var figure in figures)
            {
                if (f.Equals(figure))
                {
                    figure.ColorNumber = f.ColorNumber;
                    return;
                }
            }
            figures.Add(f);
        }

        public GraphicPic commonWith(Figure r)
        {
            if ((int)r.Type != 1)
                throw new ArgumentException("Фигура не прямоугольник");
            var list = new List<Figure>();
            foreach (var figure in figures)
            {
                if (figure.CommonPointsWithRectangle(r))
                {
                    list.Add(figure);
                }
            }

            return new GraphicPic(list);
        }

        public GraphicPic hasSquareBiggerThanS(double s)
        {
            var list = new List<Figure>();
            foreach (var figure in figures)
            {
                if (figure.GetSquare() > s)
                    list.Add(figure);
            }
            return new GraphicPic(list);
        }
    }
}
