// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//   
// </copyright>
// <summary>
//   The form 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DcProgrammingTutorial
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    using DcProgrammingTutorial.Properties;

    using DcProgrammingTutorialLibrary;

    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class MainListForm : Form
    {
        /// <summary>
        /// The last id.
        /// </summary>
        private static int lastId = 0;

        /// <summary>
        /// The my company.
        /// </summary>
        private Company myCompany;

        /// <summary>
        /// The controler.
        /// </summary>
        private DocumentControler myDocumentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainListForm"/> class.
        /// </summary>
        public MainListForm()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// The form 1_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Form1Load(object sender , EventArgs e)
        {
            var myDoc = Document.CreateDummyDocument;
            this.myCompany = new Company(myDoc) { Name = "Data Communication", Code = "ABC", Id = 123 };
            
            this.myDocumentController = new DocumentControler();

            this.dataGridView1.DataSource = this.myCompany.GetSetDocuments;
        }

        /// <summary>
        /// The crete document button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CreteDocumentButtonClick(object sender , EventArgs e)
        {

            this.nameTextBox.Visible = true;
            this.enterButton.Visible = true;


        }

        /// <summary>
        /// The delete document button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DeleteDocumentButtonClick(object sender, EventArgs e)
        {
            var currentDocument = this.dataGridView1.CurrentRow?.DataBoundItem as Document;
            if (currentDocument != null)
            {
                this.myDocumentController.RemoveDocumentFromList(this.myCompany.GetSetDocuments, currentDocument);
            }
            else
            {
                MessageBox.Show(Resources.Form1_DeleteDocumentButton_Click_First_row_must_not_be_empty);
            }
        }

        /// <summary>
        /// The enter button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EnterButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.nameTextBox.Text))
            {
                lastId++;
                var doc = DocumentControler.CreateNewDocument(this.nameTextBox.Text, lastId);
                doc.MyCompany = this.myCompany;
                this.dataGridView1.DataSource = this.myDocumentController.AddNewDocumentToList(this.myCompany.GetSetDocuments, doc);

                this.nameTextBox.Visible = false;
                this.enterButton.Visible = false;
                this.nameTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(Resources.Form1_enterButton_Click_Give_a_valid_name);
            }
        }

        /// <summary>
        /// The calculate balance button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CalculateTaxButtonClick(object sender, EventArgs e)
        {
            var currentDocument = this.dataGridView1.CurrentRow?.DataBoundItem as Document;
            Debug.Assert(currentDocument != null, "currentDocument != null");

            var tax = this.myDocumentController.TaxCalculator(currentDocument.Balance);
            this.balanceTextBox.Text = tax.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// The average balance button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AverageBalanceButtonClick(object sender, EventArgs e)
        {
            var averageBalance = this.myDocumentController.CalculateAverageBalance(this.myCompany.GetSetDocuments.ToList());
            this.averageBalanceTextBox.Text = averageBalance.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// The data grid view 1_ cell mouse double click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DataGridView1CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.dataGridView1.CurrentCell.Value.ToString()))
            {
                var currentDocument = this.dataGridView1.CurrentRow?.DataBoundItem as Document;

                var check = new DocumentDetailForm(currentDocument);
                check.Show();
            }
            else
            {
                MessageBox.Show(Resources.Form1_dataGridView1_CellDoubleClick_The_selected_cell_must_have_a_value);
            }
        }

        /// <summary>
        /// The asfdsf tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
