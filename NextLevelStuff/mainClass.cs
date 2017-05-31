using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLevelStuff
{
    public class mainClass
    {
        public string testME1(string val1, string val2, int val3)
        {
            if (val1 != "" || val2 != "" || val3 != 0)
            {
                if (val1 != "" && val2 != "")
                {
                    return val1 + "  " + val2;
                }
                else if (val3 != 0)
                {
                    return val3.ToString();
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }

        }
        string testME2(string val1, string val2, int val3)
        {
            return "";
        }
        int testME3(string val1, string val2, int val3)
        {
            return 0;
        }
        bool testME4(string val1, string val2, int val3)
        {
            return false;
        }
        

        public mainClass()
        {
            // Constructor
                        
        }
        
    }
}
