﻿using CafeDAL.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace CafeDAL.Models
{
    public partial class Roles : EntityBase
    {
        [Required, StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
