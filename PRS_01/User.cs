﻿using System.ComponentModel.DataAnnotations;

namespace PRS_01
{
    public class User
    {
        [Key]
        public int User_Id { get; set; } 
        public string? User_Name { get; set; }
        public string? Password { get; set; }
    }
}