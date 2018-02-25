using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MTnew.Models
{
    public class Recipes
    {
        public int Rid { get; set; }
        public string Overskrift { get; set; }
        public string Indhold { get; set; }
        public int Uid { get; set; }

        public Recipes()
        {}
        public Recipes (string overskrift, string indhold, int uid)
        {
            this.Overskrift = overskrift;
            this.Indhold = indhold;
            this.Uid = uid;
        }

        //If the placeholder isnt null, witch its return to a string, when there is nothing in it.
        public bool CheckInformation()
        {
            if (this.Overskrift != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
