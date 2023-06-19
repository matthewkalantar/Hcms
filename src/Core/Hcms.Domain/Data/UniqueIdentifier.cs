using MongoDB.Bson;

namespace Hcms.Domain.Data
{
    public static class UniqueIdentifier
    {
        public static string New => ObjectId.GenerateNewId().ToString();
    }
}
