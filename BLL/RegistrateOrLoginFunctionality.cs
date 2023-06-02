using DataLayer;

namespace BLL
{
    public static class RegistrateOrLoginFunctionality
    {
        static public bool LogIn(ref string LoginTextBox, ref string PasswordTextBox)
        {
            IsWhiteSpace(ref LoginTextBox, ref PasswordTextBox);

            switch (IfContains(LoginTextBox, PasswordTextBox))
            {
                case true:
                    return true;

                case false:
                    return false;
            }
        }
        static public bool SignUp(ref string LoginTextBox, ref string PasswordTextBox)
        {
            IsWhiteSpace(ref LoginTextBox, ref PasswordTextBox);

            switch (IfContains(LoginTextBox, PasswordTextBox))
            {
                case true:
                    return false;

                case false:
                    DataLayerClass.Login.Add(LoginTextBox);
                    DataLayerClass.Password.Add(PasswordTextBox);
                    return true;
            }
        }

        static public int NullOrEmpty(string LoginTextBox, string PasswordTextBox)
        {
            if (String.IsNullOrEmpty(LoginTextBox) || String.IsNullOrWhiteSpace(LoginTextBox))
            {
                return 0;
            }
            if (String.IsNullOrEmpty(PasswordTextBox) || String.IsNullOrWhiteSpace(PasswordTextBox))
            {
                return 1;
            }
            return 2;
        }
        static public void IsWhiteSpace(ref string LoginTextBox, ref string PasswordTextBox)
        {
            if (LoginTextBox.Any(Char.IsWhiteSpace))
            {
                LoginTextBox = LoginTextBox.Replace(" ", "");
            }
            if (PasswordTextBox.Any(Char.IsWhiteSpace))
            {
                PasswordTextBox = PasswordTextBox.Replace(" ", "");
            }
        }
        static public bool IfContains(string LoginTextBox, string PasswordTextBox)
        {
            for (int i = 0; i < DataLayer.DataLayerClass.Login.Count; i++)
            {
                if (DataLayer.DataLayerClass.Login[i] == LoginTextBox && DataLayer.DataLayerClass.Password[i] == PasswordTextBox)
                {
                    return true;
                }
            }
            return false;
        }
    }
}