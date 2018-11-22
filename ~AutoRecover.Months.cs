using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MET_Office
{
    class Months
    {
        //Varibles 
        private int monthID;
        private int maximumtemp;
        private int mimimumtemp;
        private int airfrost;
        private int millimetersrain;
        private int hourssunshine;
        //constructor 
        public Months(int themonthID, int themaximumtemp, int themimimumtemp,
                      int theairfrost, int themillmetersofrain,
                      int thehoursofsunshine)
        {
            monthID = themonthID;
            maximumtemp = themaximumtemp;
            mimimumtemp = themimimumtemp;
            airfrost = theairfrost;
            millimetersrain = themillmetersofrain;
            hourssunshine = thehoursofsunshine;
        }
        //Setters
        public void setmonth(int inmonth)
        {
            monthID = inmonth;
        }


        public void setmaxtemp(int inmaxtemp)
        {
         maximumtemp = inmaxtemp;
        }

        public void setmintemp(int inmintemp)
        {
            mimimumtemp = inmintemp;
        }
                
        public void numofdayairfrost(int inairfrost)
        {
            airfrost = inairfrost;
        }
       public void millimetersofrain(int inmillimetersofrain)
       {
         millimetersrain = inmillimetersofrain;
        }
        public void hoursofsunshine(int inhoursofsunshine)
        {
            hourssunshine = inhoursofsunshine;
        }

        //getters

        public string getmonth()
        {
            return monthID.ToString();
        }

        public string getmaxtemp()
        {
            return maximumtemp.ToString();
        }

        public string getmaxtemperture()
        {
            return maximumtemp.ToString();
        }

        public string getmintemp()
        {
            return mimimumtemp.ToString();
        }

        public string getairfrost()
        {
            return airfrost.ToString();
        }

        public string getmillimetersofrain()
        {
            return millimetersrain.ToString();
        }

        public string gethoursofsunshine()
        {
            return hourssunshine.ToString();
        }
    }

}
