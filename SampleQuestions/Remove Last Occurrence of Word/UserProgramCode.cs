using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Last_Occurrence_of_Word
{
    internal class UserProgramCode
    {
        public static string Remove(string str,string dlt)
        {
            if (str == null || str.Length == 0 || dlt.Length == 0 || dlt.Length > str.Length)
                return str;
            int idx = str.LastIndexOf(dlt);
            if(idx==-1)
                return str;
            str = str.Remove(idx,dlt.Length);
            return str;
        }
    }
}
