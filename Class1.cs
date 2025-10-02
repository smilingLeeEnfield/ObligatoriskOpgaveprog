using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public abstract class Vhehicle
    {
          
        public string LicencePlate { get; set; }
        public DateTime Date{ get; set; }
        
        public bool brobizz { get; set; }
        /// <summary>
        /// Constructor for Vhehicle checks if the licence plate is to long and throws an exception if it is. also updates the date and sets brobizz to true or false
        /// </summary>
        /// <param name="LP"></param>
        /// <param name="biz"></param>
        /// <exception cref="LicencePlateLengthException"></exception>
        public Vhehicle(string LP, bool biz)
        {
            Date = DateTime.Now;
            if (LP.Count() > 7) throw new LicencePlateLengthException("your plate is to long idiot");
            LicencePlate = LP;
            brobizz = biz;
        }
        /// <summary>
        /// overridable method for calculating the price of a ticket    
        /// </summary>
        /// <returns></returns>
        public virtual double Price() 
        {
            return 0;
        }
        /// <summary>
        /// overridable method for returning the type of vehicle    
        /// </summary>
        /// <returns></returns>
        public virtual string Vehicle()
        {
            return "no";
        }
    }
}
