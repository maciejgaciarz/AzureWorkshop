using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Warsztaty.ViewModel
{
    public class ContactViewModel
    {
        public string name { get; set; }
        public int number { get; set; }
        public string email  { get; set; }
        public string phone { get; set; }
    }
}
