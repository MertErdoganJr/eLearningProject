﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eLearningProject.DAL.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

    }
}