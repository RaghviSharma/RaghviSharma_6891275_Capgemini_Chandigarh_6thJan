using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class AssignCourse
    {
        public string C_name;
        public string C_id;
        public int p_id;
        public string p_name;

        public string Proff_name
        {
            get
            {
                return this.p_name;
            }
            set
            {
                this.p_name = value;
            }
        }
        public int Proffesor_id
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
        public string Course_name
        {
            get
            {
                return C_name; 
            }
            set
            {
                C_name=value;
            }
        }
        public string Course_id
        {
            get
            {
                return C_id;
            }
            set
            {
                C_id=value;
            }
        }
    }
}
