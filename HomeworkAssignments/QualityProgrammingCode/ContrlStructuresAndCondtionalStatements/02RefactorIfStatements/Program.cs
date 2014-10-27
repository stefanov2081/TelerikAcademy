using System;

namespace _02RefactorIfStatements
{
    // I know that I should avoid having more than one class in one file, except when using nested classes, but for this exercise is ok.
    class Potato
    {
        public bool isPeeled { get; set; }
        public bool isRotten { get; set; }

        public void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cook potatoes :X
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.isPeeled)
                {
                    if (!potato.isRotten)
                    {

                        potato.Cook(potato);
                    }
                }
            }
            // Visited cells
            const int MinX = 0;
            const int MaxX = 10;
            const int MinY = 0;
            const int MaxY = 10;
            int x = 0;
            int y = 0;
            bool visited = true;

            if (x >= MinX && x <= MaxX)
            {
                if (MaxY >= y && MinY <= y)
                {
                    if (!visited)
                    {
                        VisitCell();
                    }
                }
            }
        }

        static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
