using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Firestore
{
    public class FirestoreDataService
    {
        private FirestoreDb _firestoreDb { get; }
        protected CollectionReference _collection { get; }

        public FirestoreDataService(string collectionName)
        {
            _firestoreDb = FirestoreConnection.GetIntance();
            _collection = _firestoreDb.Collection(collectionName);
        }

        // CRUD de documento

        protected async Task<string> CreateDocumentAsync<T>(T entity, string docId)
        {
            try
            {
                DocumentReference documentReference = null;

                if (!string.IsNullOrEmpty(docId))
                {
                    documentReference = _collection.Document(docId);
                    await documentReference.SetAsync(entity);
                }
                else
                {
                    documentReference = await _collection.AddAsync(entity);
                }

                return documentReference.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el documento: " + ex.Message);
                return null;
            }
        }

        protected async Task UpdateDocumentAsync<T>(T entity, string docId)
        {
            try
            {
                if (!string.IsNullOrEmpty(docId))
                {
                    DocumentReference docReference = _collection.Document(docId);
                    await docReference.SetAsync(entity);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el documento: " + ex.Message);
            }
        }

        protected async Task DeleteDocumentAsync(string docId)
        {
            try
            {
                if(!string.IsNullOrEmpty(docId))
                {
                    DocumentReference docReference = _collection.Document(docId);
                    await docReference.DeleteAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar el documento: " + ex.Message);
            }
        }

        protected async Task<DocumentSnapshot> GetDocumentAsync(string docId)
        {
            try
            {
                DocumentReference documentReference = _collection.Document(docId);
                return await documentReference.GetSnapshotAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar el documento: " + ex.Message);
                return null;
            }
        }

        protected async Task<bool> DocumentExistsAsync(string docId)
        {
            try
            {
                var documentReference = await GetDocumentAsync(docId);
                return documentReference.Exists;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar la existencia el documento: " + ex.Message);
                return false;
            }
        }

        // CRUD de entidad
        protected async Task<bool> CreateEntityAsync<T>(T entity, string id)
        {
            try
            {
                if (!await DocumentExistsAsync(id))
                {
                    await CreateDocumentAsync(entity, id);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la entidad: " + ex.Message);
                return false;
            }
        }

        protected virtual async Task<bool> UpdateEntityAsync<T>(T entity, string id)
        {
            try
            {
                if (await DocumentExistsAsync(id))
                {
                    await UpdateDocumentAsync(entity, id);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la entidad: " + ex.Message);
                return false;
            }
        }

        protected virtual async Task<bool> DeleteEntityAsync(string id)
        {
            try
            {
                if (await DocumentExistsAsync(id))
                {
                    await DeleteDocumentAsync(id);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar la entidad: " + ex.Message);
                return false;
            }
        }

        protected async Task<T> GetEntityAsync<T>(string docId) where T : class
        {
            try
            { 
                DocumentSnapshot documentSnapshot = await GetDocumentAsync(docId);
                if(documentSnapshot.Exists)
                {
                    return documentSnapshot.ConvertTo<T>();
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la entidad: " + ex.Message);
                return null;
            }
        }

        protected virtual async Task<List<T>> GetAllEntitiesAsync<T>()
        {
            try
            {
                var EntitySnapshot = await _collection.GetSnapshotAsync();
                var entityList = new List<T>();

                foreach (var entidad in EntitySnapshot)
                {
                    var entityDictionary = entidad.ToDictionary();
                    var json = JsonConvert.SerializeObject(entityDictionary);
                    var entityObject = JsonConvert.DeserializeObject<T>(json);
                    entityList.Add(entityObject!);
                }

                return entityList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las entidades: " + ex.Message);
                return null;
            }
        }

        protected async Task<bool> FieldExistsAsync(string field, string value)
        {
            try
            {
                var query = _collection.WhereEqualTo(field, value).Limit(1);
                var querySnapshot = await query.GetSnapshotAsync();
                return querySnapshot.Documents.Count > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al obtener el campo existente: " + ex.Message);
                return false;
            }
        }

        protected async Task<T> GetEntityByFieldAsync<T>(string field, string value) where T : class
        {
            try
            {
                var query = _collection.WhereEqualTo(field, value).Limit(1);
                var querySnapshot = await query.GetSnapshotAsync();
                var documentSnapshot = querySnapshot.Documents.FirstOrDefault();

                if (documentSnapshot != null)
                {
                    T entity = documentSnapshot.ConvertTo<T>();
                    return entity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el campo existente: " + ex.Message);
                return null;
            }
        }
    }
}