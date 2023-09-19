using Google.Cloud.Firestore;

namespace Entities
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string Alias { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string Password { get; set; }

        [FirestoreProperty]
        public string ProfilePicture { get; set; }

        public User()
        {

        }

        public User(string alias, string password)
        {
            Alias = alias;
            Password = password;
        }

        public User(string alias, string email, string password) : this(alias, password)
        {
            Email = email;
        }

        public User(string alias, string email, string password, string profilePicture) : this(alias, email, password)
        {
            ProfilePicture = profilePicture;
        }
    }
}