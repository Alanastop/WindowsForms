// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="">
//   
// </copyright>
// <summary>
//   The company.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DcProgrammingTutorialLibrary
{
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The company.
    /// </summary>
    public class Company : IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.GetSetDocuments = new BindingList<Document>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        public Company(Document document)
        {
            document.MyCompany = this;
           this.GetSetDocuments = new BindingList<Document> {document};
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1624:PropertySummaryDocumentationMustOmitSetAccessorWithRestrictedAccess", Justification = "Reviewed. Suppression is OK here.")]
        public BindingList<Document> GetSetDocuments { get; private set; } 

       /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
      
    }
}
