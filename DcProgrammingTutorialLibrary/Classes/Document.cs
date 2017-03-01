// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Document.cs" company="Data Communication">
//   
// </copyright>
// <summary>
//   The document.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DcProgrammingTutorialLibrary
{
    using System;

    /// <summary>
    /// The document.
    /// </summary>
    public class Document : IEntity
    {
        /// <summary>
        /// The create dummy document.
        /// </summary>
        public static Document CreateDummyDocument
            => new Document
                   {
                       Id = 0, Code = "A", Name = "Delegates", CreationDate = DateTime.Now, Balance = 19
                   };

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public static int Count { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime CreationDate { get; set; }
        
        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        public float Balance { get; set; }

        /// <summary>
        /// Gets or sets the my company.
        /// </summary>
        public Company MyCompany { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        public string CompanyName => this.MyCompany?.Name ?? string.Empty;
    }
}
