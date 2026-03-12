  class Customer
{
        private string firstname;
        private string lastname;
        private string email;

        public Customer(string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public string GetFirstname()
        {
            return firstname;
        }
        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }
        public string GetLastname()
        {
            return lastname;
        }
        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

}