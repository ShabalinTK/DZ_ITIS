

using Semestrovaya;

namespace sevestrovaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new GraphicPic("figures.txt");
            f.Show();

            Console.WriteLine();

            f.Insert(new Figure(1,1.0,1.0,1.0,1.0,3));

            f.Show();

            Console.WriteLine();

            f.hasSquareBiggerThanS(2.0).Show();

            Console.WriteLine();

            f.commonWith(new Figure(1, 4.0, 1.0, 15.0, 0.5, 3)).Show();

            Console.WriteLine();

            f.Delete(3);

            f.Show();
        }
    }
}
