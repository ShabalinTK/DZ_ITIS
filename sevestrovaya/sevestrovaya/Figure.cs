using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestrovaya
{
    public class Figure
    {
        public enum FigureType
        {
            rectangle = 1,
            segment = 2,
            circle = 3
        }
        public double LeftUpX { get; set; }
        public double LeftUpY { get; set; }
        public double RightDownX { get; set; }
        public double RightDownY { get; set; }
        public int ColorNumber { get; set; }
        public FigureType Type { get; set; }
        public Figure(int type, double leftUpX, double leftUpY, double rightDownX, double rightDownY, int colorNumber)
        {
            Type = (FigureType)type;
            LeftUpX = leftUpX;
            LeftUpY = leftUpY;
            RightDownX = rightDownX;
            RightDownY = rightDownY;
            ColorNumber = colorNumber;
        }

        public override string ToString()
        {
            return $"Type: {Type}    Color: {ColorNumber}    Coordinates: ({LeftUpX}, {LeftUpY}), ({RightDownX}, {RightDownY})";
        }

        public override bool Equals(Object obj)
        {
            if (obj is Figure)
            {
                var figure = (Figure)obj;
                return Type == figure.Type && LeftUpX == figure.LeftUpX && LeftUpY == figure.LeftUpY && RightDownX ==
                    figure.RightDownX && RightDownY == figure.RightDownY;
            }
            throw new ArgumentException("Не фигура");
        }

        public bool CommonPointsWithRectangle(Figure r)
        {
            if ((int)r.Type != 1)
                throw new ArgumentException("Фигура не прямоугольник");

            return !(r.LeftUpX > RightDownX || r.RightDownX < LeftUpX || r.LeftUpY < RightDownY || r.RightDownY > LeftUpY);
        }

        public double GetSquare()
        {
            if ((int)Type == 1)
            {
                return (RightDownX - LeftUpX) * (LeftUpY - RightDownY);
            }
            if ((int)Type == 3)
            {
                return Math.PI * RightDownX * RightDownX;
            }

            return 0;
        }
    }
}
