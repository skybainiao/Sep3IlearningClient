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
            return DateTime.Now.ToString("hh:mm:ss");
        }


        public string getNowTime()
        {
            return getDate() + "/" + getTime();
        }
        
        
    }
}