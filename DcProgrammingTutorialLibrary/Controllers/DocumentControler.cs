// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DocumentControler.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DocumentControler type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DcProgrammingTutorialLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// The document controler.
    /// </summary>
    public class DocumentControler
    {
        /// <summary>
        /// The tax.
        /// </summary>
        private const double Tax = 0.2;

        /// <summary>
        /// The create new document.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="lastId">
        /// The last id.
        /// </param>
        /// <returns>
        /// The <see cref="Document"/>.
        /// </returns>
        public static Document CreateNewDocument(string name, int lastId)
        =>

        new Document
            {
                Id = lastId,
                Code = lastId.ToString(),
                Name = name,
                CreationDate = DateTime.Now,
                Balance = 19
            };

        /// <summary>
        /// The add new document to list.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <returns>
        /// The <see cref="BindingList"/>.
        /// </returns>
        public BindingList<Document> AddNewDocumentToList(BindingList<Document> list, Document document)
        {
            list.Add(document);
            return list;
        }

        /// <summary>
        /// The remove row.
        /// </summary>
        /// <param name="row">
        /// The row.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int RemoveRow(int row) => row;

        /// <summary>
        /// The remove document from list.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <returns>
        /// The <see cref="BindingList"/>.
        /// </returns>
        public BindingList<Document> RemoveDocumentFromList(BindingList<Document> list, Document document)
        {
            return list.Remove(document) ? list : null;
        }

        /// <summary>
        /// The remove document from list.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <param name="documentId">
        /// The document id.
        /// </param>
        /// <returns>
        /// The <see cref="BindingList"/>.
        /// </returns>
        public BindingList<Document> RemoveDocumentFromList(BindingList<Document> list, int documentId)
        {
            var document = list.SingleOrDefault(doc => doc.Id == documentId);
            return list.Remove(document) ? list : null;
        }

        /// <summary>
        /// The tax calculator.
        /// </summary>
        /// <param name="balance">
        /// The balance.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public double TaxCalculator(float balance)
        {
            return balance * Tax;
        }

        /// <summary>
        /// The calculate average balance.
        /// </summary>
        /// <param name="balances">
        /// The balances.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public double CalculateAverageBalance(List<Document> balances)
        {
            return balances.Average(document => document.Balance);
        }
    }
}
