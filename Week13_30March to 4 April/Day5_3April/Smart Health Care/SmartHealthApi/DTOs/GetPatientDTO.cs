using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHealthApi.DTOs
{
    public class GetPatientDTO
    {
        public int Id {get; set;}

        public string? Name {get; set;}

        public string? Problem {get; set;}
    }
}