﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GirlsRanking.Girls
{
    public class Teen
    {
        [Key]
        public int TeenId { get; set; }
        public int Number { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string ImgName { get; set; }
        
    }
}
