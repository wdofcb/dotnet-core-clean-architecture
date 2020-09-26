﻿using System;

namespace Domain.Common
{
    public abstract class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
