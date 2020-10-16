using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApp.Models
{
    public class Employee
    {
        public int id { get; set; }

        public string Fullname { get; set; }

        public string Department { get; set; }
    }
}
