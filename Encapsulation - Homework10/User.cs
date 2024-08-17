namespace Encapsulation___Homework10
{
    internal class User
    {
        private static string _userName;
        private string _password;

        public bool HasDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasLower(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLower(s[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if(value.Length >= 6 && value.Length <= 25)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("UserName must be between 6 and 25 characters");
                }
            }
        }
        
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length >= 8 && value.Length <= 25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password must be between 8 and 25 characters, and must contain at least one digit, one uppercase letter, and one lowercase letter");
                }
            }
        }

        
    }
}
