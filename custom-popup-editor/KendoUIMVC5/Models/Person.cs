﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KendoUIMVC5.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Designation { get; set; } 
    }
}