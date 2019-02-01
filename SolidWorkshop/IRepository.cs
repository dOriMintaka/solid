namespace SolidWorkshop
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides methods to read and save <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Type of the items to store.</typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Saves the <see cref="TEntity"/> to the repository.
        /// </summary>
        /// <param name="entity">Item to be saved.</param>
        /// <returns>An <see cref="TEntity"/></returns>
        TEntity Save(TEntity entity);

        /// <summary>
        /// Reads all the <see cref="TEntity"/> from the repository.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{TEntity}"/>.</returns>
        IEnumerable<TEntity> ReadAll();
    }
}