namespace SolidWorkshop
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides methods to save and read <see cref="Entity"/>
    /// </summary>
    public class Service
    {
        private readonly IRepository<Entity> entityRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class.  
        /// </summary>
        /// <param name="repository">
        /// An <see cref="IRepository{Entity}"/> to store entities.
        /// </param>
        public Service(IRepository<Entity> repository)
        {
            this.entityRepository = repository ?? throw new ArgumentNullException(nameof(repository), "Null repository.");
        }

        /// <summary>
        /// Saves an entity to the repository.
        /// </summary>
        /// <param name="entity">An <see cref="Entity"/>.</param>
        /// <returns>An <see cref="Entity"/>.</returns>
        public Entity Save(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Null entity.");
            }

            try
            {
                this.entityRepository.Save(entity);
                return entity;
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while saving.", e);
            }
        }

        /// <summary>
        /// Reads all entities from the repository.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{Entity}"/></returns>
        public IEnumerable<Entity> ReadAll()
        {
            try
            {
                return this.entityRepository.ReadAll();
            }
            catch (Exception e)
            {
                throw new Exception("An error occured while retrieving items.", e);
            }
        }
    }
}
