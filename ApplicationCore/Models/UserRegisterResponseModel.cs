﻿using System;
namespace ApplicationCore.Models
{
    public class UserRegisterResponseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
