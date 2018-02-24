﻿using System;
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

        public bool CheckInformation()
        {
            if (!this.Overskrift.Equals("Write here") || !this.Overskrift.Equals(""))
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
