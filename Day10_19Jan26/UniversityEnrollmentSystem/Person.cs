using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Person
    {
        string p_name;
        string p_email;
        int p_id;
        public int Person_Id
        {
            get
            {
                return p_id;
            }
            set
            {
                p_id = value;
            }

        }
        public string Person_name
        {
            get
            {
                return p_name;
            }
            set
            {
                p_name = value;
            }
        }
        public string Person_email
        {
            get
            {
                return p_email;
            }
            set
            {
                p_email = value;
            }
        }
    }
}
