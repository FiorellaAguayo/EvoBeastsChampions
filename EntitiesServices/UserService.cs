using Firestore;
using Entities;

namespace EntitiesServices
{
    public class UserService : FirestoreService<User>
    {
        public UserService() : base("Users")
        {

        }

        public async Task CreateUser(User user, string alias) => await Create(user, alias);
        public async Task UpdateUser(User user, string alias) => await Update(user, alias);
        public async Task DeleteUser(User user) => await Delete(user.Alias);
        public async Task GetUser<User>(string alias) => await GetById(alias);
        public async Task<List<User>> GetAllUsers() => await GetAll();

        public async Task<bool> AliasExists(string id)
        {
            var user = await GetById(id);
            return user != null ? true : false;
        }

        public async Task<bool> FieldExists(string field, string value) => await IFieldExists(field, value);
        public async Task GetUserByField<User>(string field, string value) => await GetUserByField(field, value);
    }
}