using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Warsztaty.Core
{
    [Table("Contact")]
    public class ContactModel
    {
        [Key]
        public virtual int Id { get; set; }

        [MaxLength(25)]
        public virtual string name { get; set; }
        public virtual int number { get; set; }
        public virtual string email { get; set; }
        public virtual string phone { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
