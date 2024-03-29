﻿using System.ComponentModel.DataAnnotations;

namespace CafeDAL.Models.Base
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}