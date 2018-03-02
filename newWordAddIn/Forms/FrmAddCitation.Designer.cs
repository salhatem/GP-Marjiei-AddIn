namespace newWordAddIn.Forms
{
    partial class FrmAddCitation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCitation));
            this.lv = new BrightIdeasSoftware.ObjectListView();
            this.colItem = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ilTypes = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lv)).BeginInit();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.AllColumns.Add(this.colItem);
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.CellEditUseWholeCell = false;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItem});
            this.lv.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv.FullRowSelect = true;
            this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv.Location = new System.Drawing.Point(12, 12);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.ShowGroups = false;
            this.lv.ShowHeaderInAllViews = false;
            this.lv.Size = new System.Drawing.Size(541, 212);
            this.lv.TabIndex = 0;
            this.lv.TileSize = new System.Drawing.Size(32, 32);
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.UseFiltering = true;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // colItem
            // 
            this.colItem.AspectName = "Title";
            this.colItem.FillsFreeSpace = true;
            // 
            // ilTypes
            // 
            this.ilTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTypes.ImageStream")));
            this.ilTypes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTypes.Images.SetKeyName(0, "book");
            this.ilTypes.Images.SetKeyName(1, "conferenceproceeding");
            this.ilTypes.Images.SetKeyName(2, "journalarticle");
            this.ilTypes.Images.SetKeyName(3, "magazinearticle");
            this.ilTypes.Images.SetKeyName(4, "webpage");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(56, 240);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(497, 22);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // FrmAddCitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 276);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FrmAddCitation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marjiei Prototype";
            this.Shown += new System.EventHandler(this.FrmAddCitation_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView lv;
        private BrightIdeasSoftware.OLVColumn colItem;
        private System.Windows.Forms.ImageList ilTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
    }
}