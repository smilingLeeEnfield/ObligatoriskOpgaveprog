using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class MC:Vhehicle
    {
        /// <summary>
        /// Constructor for MC passes parameters to base class Vhehicle
        /// </summary>
        /// <param name="LP"></param>
        /// <param name="biz"></param>
        public MC(string LP, bool biz) : base(LP,biz)
        {
        }

        /// <summary>
        /// Calculates the price of an MC ticket, with a discount if brobizz is used currently hardcoded might need updating
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 120 * (brobizz ? 1 : 0.9);
        }
        /// <summary>
        /// Returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public override string Vehicle()
        {
            return "MC";
        }
    }
}
