using System;
using System.Collections.Generic;
using System.Text;

namespace _201KaspichanNumbers
{
    class KaspichanNumbers
    {
        static string ToBase256(ulong num)
        {
            string[] base256 = 
                   { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
     "aA", "aB", "aC", "aD", "aE", "aF", "aG", "aH", "aI", "aJ", "aK", "aL", "aM", "aN", "aO", "aP", "aQ", "aR", "aS", "aT", "aU", "aV", "aW", "aX", "aY", "aZ",
     "bA", "bB", "bC", "bD", "bE", "bF", "bG", "bH", "bI", "bJ", "bK", "bL", "bM", "bN", "bO", "bP", "bQ", "bR", "bS", "bT", "bU", "bV", "bW", "bX", "bY", "bZ",
     "cA", "cB", "cC", "cD", "cE", "cF", "cG", "cH", "cI", "cJ", "cK", "cL", "cM", "cN", "cO", "cP", "cQ", "cR", "cS", "cT", "cU", "cV", "cW", "cX", "cY", "cZ",
     "dA", "dB", "dC", "dD", "dE", "dF", "dG", "dH", "dI", "dJ", "dK", "dL", "dM", "dN", "dO", "dP", "dQ", "dR", "dS", "dT", "dU", "dV", "dW", "dX", "dY", "dZ",
     "eA", "eB", "eC", "eD", "eE", "eF", "eG", "eH", "eI", "eJ", "eK", "eL", "eM", "eN", "eO", "eP", "eQ", "eR", "eS", "eT", "eU", "eV", "eW", "eX", "eY", "eZ",
     "fA", "fB", "fC", "fD", "fE", "fF", "fG", "fH", "fI", "fJ", "fK", "fL", "fM", "fN", "fO", "fP", "fQ", "fR", "fS", "fT", "fU", "fV", "fW", "fX", "fY", "fZ",
     "gA", "gB", "gC", "gD", "gE", "gF", "gG", "gH", "gI", "gJ", "gK", "gL", "gM", "gN", "gO", "gP", "gQ", "gR", "gS", "gT", "gU", "gV", "gW", "gX", "gY", "gZ",      "hA", "hB", "hC", "hD", "hE", "hF", "hG", "hH", "hI", "hJ", "hK", "hL", "hM", "hN", "hO", "hP", "hQ", "hR", "hS", "hT", "hU", "hV", "hW", "hX", "hY", "hZ",
     "iA", "iB", "iC", "iD", "iE", "iF", "iG", "iH", "iI", "iJ", "iK", "iL", "iM", "iN", "iO", "iP", "iQ", "iR", "iS", "iT", "iU", "iV"};

            //// Dynamic kaspichan numbers generation
            //List<string> base256 = new List<string>();

            //for (char i = 'A'; i <= 'Z'; i++)
            //{
            //    base256.Add(i.ToString());
            //}

            //for (char i = 'a'; i <= 'i'; i++)
            //{
            //    for (char j = 'A'; j <= 'Z'; j++)
            //    {
            //        base256.Add(i.ToString() + j.ToString());
            //    }
            //}

            StringBuilder sb = new StringBuilder();

            if (num == 0)
            {
                return "A";
            }

            while (num != 0)
            {
                sb.Insert(0, base256[(int)(num % 256)]);
                num /= 256;
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());

            string result = ToBase256(input);

            Console.WriteLine(result);

        }
    }
}
