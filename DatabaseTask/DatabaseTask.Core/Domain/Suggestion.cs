﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Suggestion
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime SentTime { get; set; }
        public string Content { get; set; }

        public BranchOffice BranchOffice { get; set; }
    }
}