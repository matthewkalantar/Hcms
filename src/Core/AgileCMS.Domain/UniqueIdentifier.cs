using MongoDB.Bson;

namespace AgileCMS.Domain
{
    public static class UniqueIdentifier
    {
        public static string New => ObjectId.GenerateNewId().ToString();
    }
}
