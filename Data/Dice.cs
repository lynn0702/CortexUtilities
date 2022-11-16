using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Die
    {
        //traits for polyhedral dice    
        public int Id { get; set; }
        public int Size { get; set; }
        public int Value { get; set; }

    }

    public class DicePool
    {
        public bool HasDread { get; set; }

        private int Dread => HasDread ? 1 : 0;
        public List<Die> Dice { get; set; }

        public int? Total { get; set; }

        public int? Effect { get; set; }

        //function to set total from best 2 dice
        public void BestTotal()
        {
            Total = Dice.Where(d => d.Value > (1 + Dread)
            ).OrderBy(d => d.Value).Take(2).Sum(d => d.Value);
        }

    }
}
