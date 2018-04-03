using LibTrainning.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LibTrainning.CodeFirst
{
    public class User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        //[Required]
        public string Username { get; set; }
        public string PasswordHash { get; protected set; } 

        public void SetPassword(string newPassword)
        {
            PasswordHash = PasswordHasher.CreateHash(newPassword);
        }

        public bool VerifyPassword(string passwordCandidate)
        {
            return PasswordHasher.Verify(PasswordHash, passwordCandidate);
        }
    }
}
