﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Skill
	{
        [Key]
        public int SkillID { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
    }
}

