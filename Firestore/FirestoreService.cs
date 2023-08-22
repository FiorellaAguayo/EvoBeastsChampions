
namespace Firestore
{
    public class FirestoreService<T> : FirestoreDataService, InterfaceCrud<T> where T : class
    {
        public FirestoreService(string collection) : base(collection)
        {

        }

        public async Task Create(T entity, string id) => await CreateEntityAsync(entity, id);

        public async Task Update(T entity, string id) => await UpdateEntityAsync(entity, id);

        public async Task Delete(string id) => await DeleteEntityAsync(id);

        public async Task<T> GetById(string id) => await GetEntityAsync<T>(id);

        public async Task<List<T>> GetAll() => await GetAllEntitiesAsync<T>();

        public async Task<bool> IFieldExists(string field, string value) => await FieldExistsAsync(field, value);

        public async Task<T> GetUserByField(string field, string value) => await GetEntityByFieldAsync<T>(field, value);
    }
}