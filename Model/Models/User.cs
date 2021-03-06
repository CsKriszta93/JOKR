﻿using System;

namespace Entities.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public DateTime Registration { get; set; }
        public string BankAccount { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime lastLogin { get; set; }

        /// <summary>
        /// idegen kulcs a Configuraton táblához
        /// </summary>
        public Guid ConfigId { get; set; }
    }
}
