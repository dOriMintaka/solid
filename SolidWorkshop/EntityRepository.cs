namespace SolidWorkshop
{
    using System.Collections.Generic;
    using System.Data.SqlClient;

    /// <inheritdoc/>
    public class EntityRepository : IRepository<Entity>
    {
        private const string _connectionString = "[connectionString]";

        private readonly SqlConnection _sqlConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepository"/> class. 
        /// </summary>
        public EntityRepository()
        {
            this._sqlConnection = new SqlConnection(_connectionString);
        }

        /// <inheritdoc/>
        public Entity Save(Entity entity)
        {
            this._sqlConnection.Open();

            // perform saving
            this._sqlConnection.Close();
            return entity;
        }

        /// <inheritdoc/>
        public IEnumerable<Entity> ReadAll()
        {
            this._sqlConnection.Open();

            // perform saving
            this._sqlConnection.Close();
            return new List<Entity>();
        }
    }
}