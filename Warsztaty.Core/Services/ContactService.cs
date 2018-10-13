using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Warsztaty.ViewModel;

namespace Warsztaty.Core.Services
{
    public class ContactService
    {
        public void Add(ContactViewModel contact)
        {
            var toSave = new ContactModel()
            {
                CreatedDate = DateTime.Now,
                email = contact.email,
                name = contact.name,
                number = contact.number,
                phone = contact.phone
            };
            var db = new DataContext();
            db.Add<ContactModel>(toSave);
            db.SaveChanges();
        }
    }
}