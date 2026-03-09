using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Vehicle
    {
        public string v_name;
        public int v_no;
        public int v_charge;
        public string v_type;

        public string Vehicle_name
        {
            get
            {
                return v_name;
            }
            set
            {
                v_name = value;
            }
        }
        public int Vehicle_charge
        {
            get
            {
                return v_charge;
            }
            set
            {
                v_charge = value;
            }
        }
        public string Vehicle_type
        {
            get
            {
                return v_type;
            }
            set
            {
                v_type = value;
            }
        }
        public int Vehicle_No
        {
            get
            {
                return v_no;
            }
            set
            {
                value= v_no;
            }
        }

    }
}
