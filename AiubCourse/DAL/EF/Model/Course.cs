﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Course
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int StudentCount { set; get; }

    }
}
