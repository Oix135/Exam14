namespace Exam14
{
    internal class Work
    {
        private List<Contact> phoneBook;
        public Work()
        {
            SetData();
        }

        private void SetData()
        {
            phoneBook =
            [
                // добавляем контакты
                new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new Contact("Сергей", "Брин", 799900000013, "serg@google.com"),
                new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"),
                new Contact("Ларри", "Пейдж", 799900000013, "larry@google.com"),
            ];

        }

        internal IEnumerable<Contact> GetContacts(int pageNumber, int countRecords)
        {
            var pageContent = phoneBook.OrderBy(a=>a.Name).ThenBy(a=>a.LastName).Skip((pageNumber - 1) * 2).Take(countRecords);
            return pageContent;
        }
        
    }
    internal class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string LastName { get; }
        public long PhoneNumber { get; }
        public string Email { get; }
    }
}
