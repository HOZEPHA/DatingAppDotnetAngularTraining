using API.DTOs;
using API.Entities;

namespace API.Interface
{
    /// <summary>
    /// Interface for user repository to handle user-related data operations.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Asynchronously retrieves all users.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains an enumerable collection of users.</returns>
        Task<IEnumerable<AppUser>> GetUsersAsync();

        /// <summary>
        /// Updates the state of the specified user entity in the context.
        /// </summary>
        /// <param name="appUser">The user entity to update.</param>

        void Update(AppUser appUser);

        /// <summary>
        /// Asynchronously retrieves a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the user with the specified ID.</returns>
        Task<AppUser?> GetUserByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the user with the specified ID.</returns>
        Task<AppUser?> GetUserByUserNameAsync(string username);

                /// <summary>
        /// Asynchronously retrieves a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the user with the specified ID.</returns>
        Task<IEnumerable<MemberDto>> GetMembersAsync();

                /// Asynchronously retrieves a user by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the user with the specified ID.</returns>
        Task<MemberDto?> GetMemberAsync(string username);

        /// <summary>
        /// Asynchronously saves all changes made in the context to the database.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating whether the changes were successfully saved.</returns>
        Task<bool> SaveAllAsync();

        /// <summary>
        /// Adds a new entity to the context.
        /// </summary>
        /// <typeparam name="T">The type of the entity to add.</typeparam>
        /// <param name="entity">The entity to add.</param>
        void Add<T>(T entity) where T : class;

        /// <summary>
        /// Deletes an entity from the context.
        /// </summary>
        /// <typeparam name="T">The type of the entity to delete.</typeparam>
        /// <param name="entity">The entity to delete.</param>
        void Delete<T>(T entity) where T : class;
    }
}
