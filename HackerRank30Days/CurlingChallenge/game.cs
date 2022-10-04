using CurlingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlingChallenge
{
    internal class game
    {
        private readonly int planeWidht;
        private readonly double planeHeight;
        private readonly int diskRadius;
        public List<CurlingRock> disksList { get; set; }
        public game(int planewidht, double planeheight, int diskradius, List<CurlingRock> diskslist)
        { 
            planeWidht = planewidht;   
            planeHeight = planeheight; 
            diskRadius = diskradius;   
            disksList = diskslist;
        }

        public void PlayGame()
        {
            foreach (CurlingRock disk in disksList)
            {
                disk.DoMove(SlideToTopAndCheck());
            }
        }

        private Coords SlideToTopAndCheck()
        {
            Coords result = new(0, 0);

            return result;
        }
    }
}
