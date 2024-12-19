﻿namespace Resume.DAL.Model
{
    public class User
    {
        public int Id{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Mobile{ get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
        public bool IsActive{ get; set; }
        public DateTime RegisterDate{ get; set; }
    }
}
