namespace RunMongoMigrations.MigrationScripts
{
    using MongoDB.Bson;

    using MongoMigrations;

    public class CreateTestCollection : MigrationScript
    {
        public CreateTestCollection()
            : base("0.0.0")
        {
            this.Description = "This will create a collection called test if the database is brand new (no migrations yet)";
        }

        public override void Update()
        {
            Database.Eval(new BsonJavaScript("db.createCollection('test');"));
        }
    }
}
