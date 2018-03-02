using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LinqToDB;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using MySql.Data.MySqlClient;
using newWordAddIn.DataModels;
using newWordAddIn.Forms;

namespace newWordAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            #region Checking database connection

            try
            {
                using (var db = new MarjieiDb())
                {
                    var b = db.Books.FirstOrDefault();
                }

                btnAddReference.Enabled = true;

#if DEBUG
                AddSampleData();
#endif
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Can't access local database:\n{ex.Message}", @"CITATION",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddReference.Enabled = false;
            }

            #endregion
        }

        private void AddSampleData()
        {
            using (var db = new MarjieiDb())
            {
                if (db.ReferenceDocuments.Any()) return;

                foreach (var file in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)))
                {
                    var fi = new FileInfo(file);
                    if (fi.Extension == ".docx" || fi.Extension == ".pdf")
                    {
                        var doc = new ReferenceDocument
                        {
                            Title = file,
                            DocumentType = DocumentType.Book.ToString(),
                            Author = Environment.UserName,
                            //ReferenceFile = File.ReadAllBytes(file),
                        };
                        doc.DocumentId = Convert.ToInt32(db.InsertWithIdentity(doc));
                    }
                }
            }
        }

        private void btnAddReference_Click(object sender, RibbonControlEventArgs e)
        {
            using (var frm = new FrmAddCitation())
            {
                frm.ShowDialog();
                var id = frm.SelectedId;
                if (id > 0)
                {
                    using (var db = new MarjieiDb())
                    {
                        var item = (from doc in db.ReferenceDocuments
                                    where doc.DocumentId == id
                                    select doc).FirstOrDefault();
                        //MessageBox.Show($"Selected document:\n[{b?.DocumentId}] {b?.Title}", @"DOCUMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (item == null) return;

                        var wdoc = Globals.ThisAddIn.Application.ActiveDocument;
                        var tag = "Cit01";
                        var strXml =
                            $"<b:Source xmlns:b=\"http://schemas.microsoft.com/office/word/2004/10/bibliography\">" +
                            $"<b:Tag>{tag}</b:Tag>" +
                            $"<b:SourceType>{item.DocumentType}</b:SourceType>" +
                            $"<b:Author><b:Author><b:NameList><b:Person><b:Last>{item.Author}</b:Last><b:First></b:First></b:Person></b:NameList></b:Author></b:Author>" +
                            $"<b:Title>{item.Title}</b:Title>" +
                            $"<b:Year>{item.PublishYear}</b:Year>" +
                            $"<b:City></b:City>" +
                            $"<b:Publisher>{item.Publisher}</b:Publisher>" +
                            $"</b:Source>";
                        wdoc.Bibliography.Sources.Add(strXml); // Here is a problem
                        wdoc.Fields.Add(wdoc.Range(), WdFieldType.wdFieldCitation, tag);

                        var citation = new Citation
                        {
                            CitationIndex = 0,
                            Style = cboStyle.SelectedItem.Label,
                        };
                        citation.WordFileId = Convert.ToInt32(db.InsertWithIdentity(citation));
                    }
                }
            }
        }
    }
}
