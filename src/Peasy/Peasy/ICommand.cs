﻿using System.Threading.Tasks;

namespace Peasy
{
    /// <summary>
    /// Represents a logical unit of work.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Synchronously orchestrates command initialization, rule execution, and application logic.
        /// </summary>
        /// <returns>
        /// An <see cref="ExecutionResult"/>.
        /// </returns>
        ExecutionResult Execute();

        /// <summary>
        /// Asynchronously orchestrates command initialization, rule execution, and application logic.
        /// </summary>
        /// <returns>
        /// An awaitable <see cref="ExecutionResult"/>.
        /// </returns>
        Task<ExecutionResult> ExecuteAsync();
    }

    /// <summary>
    /// Represents a logical unit of work.
    /// </summary>
    public interface ICommand<T>
    {
        /// <summary>
        /// Synchronously orchestrates command initialization, rule execution, and application logic.
        /// </summary>
        /// <returns>
        /// An <see cref="ExecutionResult{T}"/>.
        /// </returns>
        ExecutionResult<T> Execute();

        /// <summary>
        /// Asynchronously orchestrates command initialization, rule execution, and application logic.
        /// </summary>
        /// <returns>
        /// An awaitable <see cref="ExecutionResult{T}"/>.
        /// </returns>
        Task<ExecutionResult<T>> ExecuteAsync();
    }
}
