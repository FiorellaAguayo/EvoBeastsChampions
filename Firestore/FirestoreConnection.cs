﻿using Google.Cloud.Firestore;

namespace Firestore
{
    public class FirestoreConnection
    {
        private static FirestoreDb _connection;

        public static FirestoreDb GetIntance()
        {
            if (_connection == null)
            {
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}evobeastchampions-firebase-adminsdk-92905-1a0b84768d.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                _connection = FirestoreDb.Create("evobeastchampions");
            }
            return _connection;
        }
    }
}