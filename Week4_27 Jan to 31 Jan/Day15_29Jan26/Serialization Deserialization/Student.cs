using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization_Deserialization
{
    [Serializable]
    public class Student
    {
        public int id {  get; set; }
        public string ?name { get; set; }
    }
}
