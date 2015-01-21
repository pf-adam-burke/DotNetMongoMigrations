namespace RunMongoMigrations.MigrationScripts
{
    using MongoDB.Bson;

    using MongoMigrations;

    [Experimental]
    class RenameCustomerProductsToNavigationItems : MigrationScript
    {
        public RenameCustomerProductsToNavigationItems()
            : base("0.0.0")
        {
            Description = "This script will change the name of the CustomerProducts collection to NavigationItems";
        }

        public override void Update()
        {
            Database.Eval(new BsonJavaScript("db.CustomerProduct.renameCollection('NavigationItem');"));
        }

    }
}
