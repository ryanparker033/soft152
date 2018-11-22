using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MET_Office
{
    class Years
    {
        //varibles for the year class
        private int yearID;
        private string yeardescription;
        private int allmonths;
        Years[] months;

        //two constuctors for the year class
        public Years(int theyearID, string theyeardescripion, int theallmonths)
        {
            yearID = theyearID;
            yeardescription = theyeardescripion;
            allmonths = theallmonths;
            months = null;
        }

        public Years(int theyearID, string theyearsecription, int theallmonths, Years[] themonths)
        {
            yearID = theyearID;
            yeardescription = theyearsecription;
            allmonths = theallmonths;
            months = themonths;
        }
        //get the details for each of the years
        //public string getDetails()
        {
           // string output;
           // output = String.Format("Year is {0} which was {1} and had {2}",
                     //yearID, yeardescription, months.Length);
           // return output;
        }
        //getter
        public Years[] getallmonths()
        {
            return months;
        }
        //setter
        public void setallmonths(Years[] themonths)
        {
            months = themonths;
        }
    }
            
    
}
