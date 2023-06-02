using BLL;
using SocialMediaPlatform;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Check_number_of_accounts_after_creating_one_account()
        {

            //Assign
            string login = "login";
            string password = "password";

            //Act
            RegistrateOrLoginFunctionality.SignUp(ref login, ref password);

            //Assert
            Assert.AreEqual(1, DataLayer.DataLayerClass.Login.Count());
        }

        [Test]
        public void Check_if_contains_login_and_password_after_creating_an_account()
        {

            //Assign
            string login = "login";
            string password = "password";

            //Act
            RegistrateOrLoginFunctionality.SignUp(ref login, ref password);

            bool IfContains = RegistrateOrLoginFunctionality.IfContains(login, password);

            //Assert
            Assert.True(IfContains);
        }
    }
}