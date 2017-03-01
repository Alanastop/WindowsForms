// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEntity.cs" company="Data Communication">
//  DcProgrammingTutorial 
// </copyright>
// <summary>
//   The Entity interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DcProgrammingTutorialLibrary
{
    /// <summary>
    /// The Entity interface.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        string Code { get; set; }
    }
}