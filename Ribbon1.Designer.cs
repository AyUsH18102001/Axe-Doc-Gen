
namespace Windward
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.Edit = this.Factory.CreateRibbonGroup();
            this.dataSource = this.Factory.CreateRibbonMenu();
            this.inputParameters = this.Factory.CreateRibbonButton();
            this.tags = this.Factory.CreateRibbonGallery();
            this.output = this.Factory.CreateRibbonGallery();
            this.button4 = this.Factory.CreateRibbonButton();
            this.editTag = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.Edit);
            this.tab1.Label = "Windward";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.dataSource);
            this.group1.Items.Add(this.inputParameters);
            this.group1.Label = "Data";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.tags);
            this.group2.Label = "Tags";
            this.group2.Name = "group2";
            // 
            // group3
            // 
            this.group3.Items.Add(this.output);
            this.group3.Items.Add(this.button4);
            this.group3.Label = "Output";
            this.group3.Name = "group3";
            // 
            // Edit
            // 
            this.Edit.Items.Add(this.editTag);
            this.Edit.Label = "Edit";
            this.Edit.Name = "Edit";
            // 
            // dataSource
            // 
            this.dataSource.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.dataSource.Label = "Data Source";
            this.dataSource.Name = "dataSource";
            this.dataSource.OfficeImageId = "DatabaseCopyDatabaseFile";
            this.dataSource.ShowImage = true;
            this.dataSource.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dataSource_ItemsLoading);
            // 
            // inputParameters
            // 
            this.inputParameters.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.inputParameters.Label = "Input Parameters";
            this.inputParameters.Name = "inputParameters";
            this.inputParameters.OfficeImageId = "ExchangeFolder";
            this.inputParameters.ShowImage = true;
            this.inputParameters.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.inputParameters_Click);
            // 
            // tags
            // 
            this.tags.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.tags.Image = global::Windward.Properties.Resources.tags;
            this.tags.ItemImageSize = new System.Drawing.Size(40, 40);
            ribbonDropDownItemImpl2.Image = global::Windward.Properties.Resources._out;
            ribbonDropDownItemImpl2.Label = "Out";
            ribbonDropDownItemImpl2.ScreenTip = "Tag used to display the query tag output";
            ribbonDropDownItemImpl3.Image = global::Windward.Properties.Resources.query;
            ribbonDropDownItemImpl3.Label = "Query";
            ribbonDropDownItemImpl3.ScreenTip = "Tag used to insert a query";
            ribbonDropDownItemImpl4.Image = global::Windward.Properties.Resources._if;
            ribbonDropDownItemImpl4.Label = "IF";
            ribbonDropDownItemImpl4.ScreenTip = "Tag used to insert a If clause";
            ribbonDropDownItemImpl5.Image = global::Windward.Properties.Resources.endif;
            ribbonDropDownItemImpl5.Label = "End If";
            ribbonDropDownItemImpl5.ScreenTip = "Tag used to close the If clause";
            this.tags.Items.Add(ribbonDropDownItemImpl1);
            this.tags.Items.Add(ribbonDropDownItemImpl2);
            this.tags.Items.Add(ribbonDropDownItemImpl3);
            this.tags.Items.Add(ribbonDropDownItemImpl4);
            this.tags.Items.Add(ribbonDropDownItemImpl5);
            this.tags.Label = "Tags";
            this.tags.Name = "tags";
            this.tags.OfficeImageId = "AdpOutputOperationsTableRemove";
            this.tags.ShowImage = true;
            this.tags.ShowItemSelection = true;
            this.tags.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tags_Click);
            this.tags.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tags_ItemsLoading);
            // 
            // output
            // 
            this.output.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.output.ItemImageSize = new System.Drawing.Size(40, 40);
            ribbonDropDownItemImpl8.Image = global::Windward.Properties.Resources.docs;
            ribbonDropDownItemImpl8.Label = "Word";
            ribbonDropDownItemImpl8.OfficeImageId = "FileSaveAsWordDocx\t";
            ribbonDropDownItemImpl8.ScreenTip = "Output wil be stored as Docx file";
            ribbonDropDownItemImpl9.Image = global::Windward.Properties.Resources.pdf;
            ribbonDropDownItemImpl9.Label = "PDF";
            ribbonDropDownItemImpl9.OfficeImageId = "FileSaveAsPdfOrXps\t";
            ribbonDropDownItemImpl9.ScreenTip = "Output will be stored as PDF file";
            this.output.Items.Add(ribbonDropDownItemImpl6);
            this.output.Items.Add(ribbonDropDownItemImpl7);
            this.output.Items.Add(ribbonDropDownItemImpl8);
            this.output.Items.Add(ribbonDropDownItemImpl9);
            this.output.Label = "Output";
            this.output.Name = "output";
            this.output.OfficeImageId = "AdpOutputOperationsTableRemove";
            this.output.ShowImage = true;
            this.output.ShowItemSelection = true;
            this.output.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.output_Click);
            this.output.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.output_ItemsLoading);
            // 
            // button4
            // 
            this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button4.Label = "Help";
            this.button4.Name = "button4";
            this.button4.OfficeImageId = "Help";
            this.button4.ShowImage = true;
            // 
            // editTag
            // 
            this.editTag.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.editTag.Label = "Edit Tag";
            this.editTag.Name = "editTag";
            this.editTag.OfficeImageId = "EditComposePage";
            this.editTag.ShowImage = true;
            this.editTag.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editTag_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu dataSource;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton inputParameters;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery output;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery tags;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Edit;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton editTag;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
