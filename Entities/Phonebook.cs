using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApp.Entities
{
    internal class Phonebook
    {
        private List<Contact> _contacts { get; set; }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails (List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }


        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found !");

            }
            else
            {
                DisplayContactDetails(contact);
            }

        }

        public void DisplayAllContact()
        {
            foreach (var contact in _contacts)
            {
                DisplayContactsDetails(_contacts);
            }
        }

        // By using this method you can search a contact that contains de searchPhrase.
        // Ex.: When writing "Jh", y'll get Jhonny and so on.
        
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
          
                DisplayContactsDetails(matchingContacts);
            

        }


    }
}
