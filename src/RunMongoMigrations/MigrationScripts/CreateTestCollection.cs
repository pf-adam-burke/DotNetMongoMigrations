namespace RunMongoMigrations.MigrationScripts
{
    using MongoDB.Bson;

    using MongoMigrations;

    public class CreateTestCollection : Migration
    {
        public CreateTestCollection()
            : base("0.0.0")
        {
        }

        public override void Update()
        {
            Database.Eval(new BsonJavaScript("db.createCollection('test');"));
        }
    }
}
