﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Setting
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "درباره ما")]
        public string AboutDes { get; set; }

    }
}
