using System;

namespace LoginExample.Extra
{
    public class Time
    {

        public string getDate()
        {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }

        public string getTime()
        {
            return DateTime.Now.ToString("hh:mm:ss t z");
        }


        public string getNowTime()
        {
            return getDate() + " at " + getTime();
        }
        
        
    }
}