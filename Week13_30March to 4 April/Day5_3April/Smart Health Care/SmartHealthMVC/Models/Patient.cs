using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHealthMVC.Models
{
    public class Patient
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Problem {get; set;}
    }
}