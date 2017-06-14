﻿using System.Collections.Generic;

namespace TasksManagementMVCApp.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }

        //Navigation Property
        public virtual List<Vote> Votes { get; set; }
    }
}