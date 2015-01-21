namespace RunMongoMigrations.MigrationScripts
{
    using MongoDB.Bson;

    using MongoMigrations;

    public class RenameTest2CollectionToTest3 : MigrationScript
    {
        public RenameTest2CollectionToTest3()
            : base("0.0.2")
        {
            this.Description = "This will change the name of test collection to test2 if the database version is 0.0.2";
        }

        public override void Update()
        {
            Database.Eval(new BsonJavaScript("db.test2.renameCollection('test3');"));
        }
    }
}
