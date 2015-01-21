namespace RunMongoMigrations.MigrationScripts
{
    using MongoDB.Bson;
    using MongoMigrations;

    public class CreateTest2Collection : MigrationScript
    {
        public CreateTest2Collection()
            : base("0.0.1")
        {
            this.Description = "This will create a collection called test2 when db version is 0.0.0";
        }

        public override void Update()
        {
            Database.Eval(new BsonJavaScript("db.createCollection('test2');"));
        }
    }
}
