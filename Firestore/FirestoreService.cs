using Google.Cloud.Firestore;

namespace Firestore
{
    public class FirestoreService
    {
        private FirestoreDb _firestoreDb { get; }
        protected CollectionReference _collection { get; }

        public FirestoreService(string collectionName)
        {
            _firestoreDb = FirestoreConnection.GetIntance();
            _collection = _firestoreDb.Collection(collectionName);
        }

        // CRUD de documento


        //nuevo para git


        // CRUD de entidad
        protected async Task<bool> CreateEntityAsync<T>(T entity, string id)
        {
            await _collection.AddAsync(entity);
            return true;
        }
    }
}