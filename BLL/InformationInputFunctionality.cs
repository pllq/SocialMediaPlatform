namespace BLL
{
    public static class InformationInputFunctionality
    {
        public static void SaveData(string id, string name, string username,
            string email, string date_of_birth, string profile_picture)
        {
            DataLayer.DataLayerClass.ID = id;
            DataLayer.DataLayerClass.Name = name;
            DataLayer.DataLayerClass.Username = username;
            DataLayer.DataLayerClass.Email = email;
            DataLayer.DataLayerClass.Date_of_birth = date_of_birth;
            DataLayer.DataLayerClass.Profile_picture = profile_picture;
        }
    }
}
