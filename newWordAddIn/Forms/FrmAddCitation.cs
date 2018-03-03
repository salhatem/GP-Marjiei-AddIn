using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using newWordAddIn.DataModels;

namespace newWordAddIn.Forms
{
    public partial class FrmAddCitation : Form
    {
        // iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
        public int SelectedId = 0;

        public FrmAddCitation()
        {
            InitializeComponent();
            SetListHandlers();
        }

        private void FrmAddCitation_Shown(object sender, EventArgs e)
        {
            using (var db = new MarjieiDb())
            {
                var docs = db.ReferenceDocuments.OrderBy(d => d.Title).ToList();
                lv.SetObjects(docs);
            }
        }


        private void SetListHandlers()
        {
            lv.View = View.Details;
            lv.RowHeight = 60;

            colItem.CellPadding = new Rectangle(4, 2, 4, 2);
            colItem.Renderer = new DescribedTaskRenderer
            {
                // Give the renderer its own collection of images.
                // If this isn't set, the renderer will use the SmallImageList from the ObjectListView.
                // (this is standard Renderer behaviour, not specific to DescribedTaskRenderer).
                ImageList = ilTypes,
                // Tell the renderer which property holds the text to be used as a description
                DescriptionAspectName = "LongDescription",
                // Change the formatting slightly
                TitleFont = new Font("Segoe UI", 9, FontStyle.Bold),
                DescriptionFont = new Font("Segoe UI", 7),
                ImageTextSpace = 8,
                TitleDescriptionSpace = 1,
                // Use older Gdi renderering, since most people think the text looks clearer
                UseGdiTextRendering = false,
                // If you like colours other than black and grey, you could uncomment these
                TitleColor = Color.Black, // Color.FromArgb(128, 170, 169, 175),
                DescriptionColor = Color.DarkSlateGray,
            };
            colItem.AspectName = "Title";
            colItem.ImageAspectName = "DocumentType";


            lv.EmptyListMsg = @"NO DOCUMENTS";
            if (lv.EmptyListMsgOverlay is TextOverlay lvOver)
            {
                lvOver.TextColor = Color.Firebrick;
                lvOver.BackColor = Color.AntiqueWhite;
                lvOver.BorderColor = Color.DarkRed;
                lvOver.BorderWidth = 4.0f;
                //tvOver.Font = new Font("Chiller", 36);
                lvOver.Rotation = -10;
            }
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            if (lv.SelectedObject is ReferenceDocument item)
            {
                SelectedId = item.DocumentId;
                Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lv.ModelFilter = string.IsNullOrEmpty(txtFilter.Text) ? null : new TextMatchFilter(lv, txtFilter.Text);
        }
    }
}
