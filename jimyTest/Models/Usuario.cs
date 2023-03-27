using System;
using System.ComponentModel.DataAnnotations;

namespace jimyTest.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }
        public string Password { get; set; } = string.Empty;
        public int RecoveryPassword { get; set; }
        public int Active { get; set; } = 1;
    }
}

