// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Props.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Props type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DcProgrammingTutorial
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Windows.Forms;

    using DcProgrammingTutorialLibrary;

    /// <summary>
    /// The props.
    /// </summary>
    public partial class DocumentDetailForm : Form
    {
        /// <summary>
        /// The document.
        /// </summary>
        private Document localDocument;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetailForm"/> class.
        /// </summary>
        /// <param name="document">
        ///     The document.
        /// </param>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1614:ElementParameterDocumentationMustHaveText", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:ElementParametersMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "Reviewed. Suppression is OK here.")]
        public DocumentDetailForm(Document document)
        {
            this.localDocument = document;
            this.InitializeComponent();
            this.companyNameTextBox.Text = document.MyCompany.Name;
            this.companyCodeTextbox.Text = document.MyCompany.Code;
            this.creationDateTextbox.Text = document.CreationDate.ToString(CultureInfo.CurrentCulture);
            this.documentNameTextbox.Text = document.Name;
            this.balanceTextbox.Text = document.Balance.ToString(CultureInfo.InvariantCulture);
            this.documentIdTextbox.Text = document.Id.ToString();
            this.documentCodeTextbox.Text = document.Code;
           
        }

        /// <summary>
        /// The controller.
        /// </summary>
        public readonly DocumentControler Controller = new DocumentControler();

        /// <summary>
        /// The ok button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OkButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The button 1_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Button1Click(object sender, EventArgs e)
        {
            var tax = this.Controller.TaxCalculator(this.localDocument.Balance);
            this.textBox9.Text = tax.ToString(CultureInfo.InvariantCulture);
        }
    }
}
