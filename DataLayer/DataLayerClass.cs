using System.Xml.Linq;

namespace DataLayer
{
    public static class DataLayerClass
    {
        static private List<string> login = new List<string>();
        static public List<string> Login // property
        {
            get => login;
            set => login = value;
        }

        static private List<string> password = new List<string>();
        static public List<string> Password // property
        {
            get => password;
            set => password = value;
        }

        private static string id;
        public static string ID 
        {
            get => id;
            set => id = value;
        }

        private static string name;
        public static string Name
        {
            get => name;
            set => name = value;
        }

        private static string username;
        public static string Username 
        {
            get => username;
            set => username = value;
        }

        private static string email;
        public static string Email 
        {
            get => email;
            set => email = value;
        }

        private static string date_of_birth;
        public static string Date_of_birth 
        {
            get => date_of_birth; 
            set => date_of_birth = value;
        }

        private static string profile_picture;
        public static string Profile_picture 
        {
            get => profile_picture; 
            set => profile_picture = value;
        }
    }
}