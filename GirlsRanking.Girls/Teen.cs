﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GirlsRanking.Girls
{
    public class Teen
    {
       
        public int TeenId { get; set; } 
        [Required]
        public int Number { get; set; }        
        public string Id { get; set; }

        [Required(ErrorMessage = "FirstName is mandatory")]
        [MinLength(2)]
        public string Name { get; set; }
        
        public string Img { get; set; }
        
        public string ImgName { get; set; }
        
    }
}
