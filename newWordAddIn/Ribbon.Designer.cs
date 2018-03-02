namespace newWordAddIn
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.cboStyle = this.Factory.CreateRibbonDropDown();
            this.btnInsertIndex = this.Factory.CreateRibbonButton();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.btnAddReference = this.Factory.CreateRibbonButton();
            this.btnEditReference = this.Factory.CreateRibbonButton();
            this.btnDelReference = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.cboStyle);
            this.group1.Items.Add(this.btnInsertIndex);
            this.group1.Items.Add(this.label1);
            this.group1.Items.Add(this.btnAddReference);
            this.group1.Items.Add(this.btnEditReference);
            this.group1.Items.Add(this.btnDelReference);
            this.group1.Label = "مرجعي";
            this.group1.Name = "group1";
            // 
            // cboStyle
            // 
            ribbonDropDownItemImpl1.Label = "IEEE";
            ribbonDropDownItemImpl2.Label = "APA";
            ribbonDropDownItemImpl3.Label = "MLA";
            this.cboStyle.Items.Add(ribbonDropDownItemImpl1);
            this.cboStyle.Items.Add(ribbonDropDownItemImpl2);
            this.cboStyle.Items.Add(ribbonDropDownItemImpl3);
            this.cboStyle.Label = "النمط";
            this.cboStyle.Name = "cboStyle";
            // 
            // btnInsertIndex
            // 
            this.btnInsertIndex.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertIndex.Image")));
            this.btnInsertIndex.Label = "إدراج فهرس";
            this.btnInsertIndex.Name = "btnInsertIndex";
            this.btnInsertIndex.ShowImage = true;
            // 
            // label1
            // 
            this.label1.Label = "   ";
            this.label1.Name = "label1";
            // 
            // btnAddReference
            // 
            this.btnAddReference.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReference.Image")));
            this.btnAddReference.Label = "إضافة مرجع";
            this.btnAddReference.Name = "btnAddReference";
            this.btnAddReference.ShowImage = true;
            this.btnAddReference.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddReference_Click);
            // 
            // btnEditReference
            // 
            this.btnEditReference.Enabled = false;
            this.btnEditReference.Image = ((System.Drawing.Image)(resources.GetObject("btnEditReference.Image")));
            this.btnEditReference.Label = "تعديل مرجع";
            this.btnEditReference.Name = "btnEditReference";
            this.btnEditReference.ShowImage = true;
            // 
            // btnDelReference
            // 
            this.btnDelReference.Enabled = false;
            this.btnDelReference.Image = ((System.Drawing.Image)(resources.GetObject("btnDelReference.Image")));
            this.btnDelReference.Label = "حذف مرجع";
            this.btnDelReference.Name = "btnDelReference";
            this.btnDelReference.ShowImage = true;
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown cboStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertIndex;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddReference;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnEditReference;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDelReference;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
