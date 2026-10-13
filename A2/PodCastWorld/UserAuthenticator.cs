namespace PodCastWorld
{
    public static class UserAuthentication
    {
        public static bool Authenticate(User user, string email, string password)
        {
            return user.GetEmail() == email &&
                   user.GetPassword() == password;
        }
    }
}