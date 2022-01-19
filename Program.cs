using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivco_Casino_Assesment
{
    internal class Program
    {
        static List<string> deck = new List<string>();
        static void Main(string[] args)
        {
            GenerateDeck();
            var d = deck.ToList();
            int X = deck.Count;
        }

        static void GenerateDeck()
        {

                for(int j = 1; j < 11; j++)
                {
                    deck.Add("D-" + j);
                    deck.Add("H-" + j);
                    deck.Add("S-" + j);
                    deck.Add("C-" + j);
                    if (j == 10)
                    {
                        deck.Add("DJ-" + 10); deck.Add("DQ-" + 10); deck.Add("DK-" + 10);
                        deck.Add("HJ-" + 10); deck.Add("HQ-" + 10); deck.Add("HK-" + 10);
                        deck.Add("SJ-" + 10); deck.Add("SQ-" + 10); deck.Add("SK-" + 10);
                        deck.Add("CJ-" + 10); deck.Add("CQ-" + 10); deck.Add("CK-" + 10);
                    }
                }
            
        }
    }
}
