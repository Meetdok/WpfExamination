﻿using System;
using System.Collections.Generic;

namespace WpfExamination.Models
{
    public partial class Post
    {
        public Post()
        {
            Users = new HashSet<User>();
        }

        public int PostId { get; set; }
        public string? PostName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
