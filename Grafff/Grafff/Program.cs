using System.Text;

namespace Grafff
{
    public class Graf
    {
        public Dictionary<int, List<int>> graf = new Dictionary<int, List<int>>();
        public void Add_vertix(int vertix)
        {
            if (!graf.ContainsKey(vertix))
                graf.Add(vertix, new List<int>());
        }
        public void Add_edeg(int vertix1, int vertix2)
        {
            graf[vertix1].Add(vertix2);
        }
        public void Remove_vertix(int vertix)
        {
            graf.Remove(vertix);
            foreach (var item in graf)
            {
                if (item.Value.Contains(vertix))
                    item.Value.Remove(vertix);
            }

        }
        public void Remove_edeg(int vertix1, int vertix2)
        {
            graf[vertix1].Remove(vertix2);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in graf.Keys)
            {
                foreach (var ver in graf[item])
                {
                    str.Append($"{item} -> {ver} ");
                }
                str.AppendLine();
            }

            return str.ToString();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Graf graf = new Graf();
            graf.Add_vertix(1);
            graf.Add_vertix(2);
            graf.Add_vertix(3);
            graf.Add_edeg(1, 2);
            graf.Add_edeg(2, 1);
            graf.Add_edeg(2, 3);
            Console.WriteLine(graf);

            graf.Remove_vertix(3);
            graf.Remove_edeg(2, 1);
            Console.WriteLine(graf);
        }
    }
}
