namespace RunMongoMigrations.MigrationScripts
{
    using MongoMigrations;

    /// <summary>
    /// The Migration interface.
    /// </summary>
    public abstract class MigrationScript : Migration
    {
        public MigrationScript(MigrationVersion version)
            : base(version)
        {
        }
    }
}
