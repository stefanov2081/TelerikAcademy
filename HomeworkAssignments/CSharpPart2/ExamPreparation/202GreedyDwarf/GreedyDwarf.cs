using System;

namespace _202GreedyDwarf
{
    class GreedyDwarf
    {
        static long MoveDwarfThroughValley(int[] valley)
        {
            string[] rawMoves = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] dwarfMoves = new int[rawMoves.Length];

            for (int i = 0; i < dwarfMoves.Length; i++)
            {
                dwarfMoves[i] = int.Parse(rawMoves[i]);
            }

            long coinsSum = 0;
            coinsSum += valley[0];
            int currentPosition = 0;
            
            bool[] visited = new bool[valley.Length];
            visited[0] = true;

            while (true)
            {
                for (int i = 0; i < dwarfMoves.Length; i++)
                {
                    int nextMove = currentPosition + dwarfMoves[i];

                    if (nextMove >= 0 && nextMove < valley.Length && !visited[nextMove])
                    {
                        coinsSum += valley[nextMove];
                        currentPosition = nextMove;
                        visited[nextMove] = true;
                    }
                    else
                    {
                        return coinsSum;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Read and split input
            string[] rawValley = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            int[] valleyCoins = new int[rawValley.Length];

            for (int i = 0; i < rawValley.Length; i++)
            {
                valleyCoins[i] = int.Parse(rawValley[i]);
            }

            int numberOfDwarfMoves = int.Parse(Console.ReadLine());
            long maxCoins = long.MinValue;

            for (int i = 0; i < numberOfDwarfMoves; i++)
            {
                long sumOfCoins = MoveDwarfThroughValley(valleyCoins);

                if (sumOfCoins > maxCoins)
                {
                    maxCoins = sumOfCoins;
                }
            }

            Console.WriteLine(maxCoins);
        }
    }
}
