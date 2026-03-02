using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace BankManagementSystem
{
    internal class BankAccount
    {
        int acc_no;
        string acc_name;
        protected double ExistingBalance=0;
        public int Account_no
        {
            get
            {
                return acc_no;
            }
            set
            {
                acc_no = value;
            }
        }
        public string Account_name
        {
            get
            {
                return acc_name;
            }
            set
            {
                acc_name = value;
            }
        }
    }
}
