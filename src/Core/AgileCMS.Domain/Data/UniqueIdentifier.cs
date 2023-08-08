using MongoDB.Bson;

namespace AgileCMS.Domain.Data
{
    public static class UniqueIdentifier
    {
        public static string New => ObjectId.GenerateNewId().ToString();
    }
}
