using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Car : Vhehicle
    {
        /// <summary>
        /// Constructor for Car passes parameters to base class Vhehicle
        /// </summary>
        /// <param name="LP"></param>
        /// <param name="biz"></param>
        public Car(string LP, bool biz) : base(LP,biz)
        {
            
        }
        /// <summary>
        /// Calculates the price of a car ticket, with a discount if brobizz is used currently hardcoded might need updating
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 230* (brobizz ? 0.9 : 1);
        }
        /// <summary>
        /// Returns the type of vehicle
        /// </summary>
        /// <returns></returns>
        public override string Vehicle()
        {
            return "Car";
        }
    }
}
