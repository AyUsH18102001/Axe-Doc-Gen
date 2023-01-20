
namespace Windward
{
    partial class editTagForm
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Child 1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Child 2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Parent", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.queryControl = new System.Windows.Forms.TabControl();
            this.queryAndProp = new System.Windows.Forms.TabPage();
            this.queryTabValue = new System.Windows.Forms.RichTextBox();
            this.propertiesTab = new System.Windows.Forms.TabPage();
            this.saveTag = new System.Windows.Forms.Button();
            this.previewTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagTypeValue = new System.Windows.Forms.TextBox();
            this.nicknameValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.queryControl.SuspendLayout();
            this.queryAndProp.SuspendLayout();
            this.propertiesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 109);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Child 1";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Child 2";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Parent";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(235, 338);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // queryControl
            // 
            this.queryControl.Controls.Add(this.queryAndProp);
            this.queryControl.Controls.Add(this.propertiesTab);
            this.queryControl.Location = new System.Drawing.Point(253, 109);
            this.queryControl.Name = "queryControl";
            this.queryControl.SelectedIndex = 0;
            this.queryControl.Size = new System.Drawing.Size(535, 182);
            this.queryControl.TabIndex = 2;
            // 
            // queryAndProp
            // 
            this.queryAndProp.Controls.Add(this.queryTabValue);
            this.queryAndProp.Location = new System.Drawing.Point(4, 22);
            this.queryAndProp.Name = "queryAndProp";
            this.queryAndProp.Padding = new System.Windows.Forms.Padding(3);
            this.queryAndProp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.queryAndProp.Size = new System.Drawing.Size(527, 156);
            this.queryAndProp.TabIndex = 0;
            this.queryAndProp.Text = "Query";
            this.queryAndProp.UseVisualStyleBackColor = true;
            this.queryAndProp.Click += new System.EventHandler(this.queryAndProp_Click);
            // 
            // queryTabValue
            // 
            this.queryTabValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTabValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.queryTabValue.EnableAutoDragDrop = true;
            this.queryTabValue.Location = new System.Drawing.Point(6, 6);
            this.queryTabValue.Name = "queryTabValue";
            this.queryTabValue.ShortcutsEnabled = false;
            this.queryTabValue.Size = new System.Drawing.Size(515, 144);
            this.queryTabValue.TabIndex = 1;
            this.queryTabValue.Text = "";
            // 
            // propertiesTab
            // 
            this.propertiesTab.Controls.Add(this.nicknameValue);
            this.propertiesTab.Controls.Add(this.tagTypeValue);
            this.propertiesTab.Controls.Add(this.label3);
            this.propertiesTab.Controls.Add(this.label2);
            this.propertiesTab.Controls.Add(this.label1);
            this.propertiesTab.Location = new System.Drawing.Point(4, 22);
            this.propertiesTab.Name = "propertiesTab";
            this.propertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.propertiesTab.Size = new System.Drawing.Size(527, 169);
            this.propertiesTab.TabIndex = 1;
            this.propertiesTab.Text = "Properties";
            this.propertiesTab.UseVisualStyleBackColor = true;
            // 
            // saveTag
            // 
            this.saveTag.BackColor = System.Drawing.SystemColors.Window;
            this.saveTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveTag.Image = global::Windward.Properties.Resources.save_tag;
            this.saveTag.Location = new System.Drawing.Point(86, 12);
            this.saveTag.Name = "saveTag";
            this.saveTag.Size = new System.Drawing.Size(68, 78);
            this.saveTag.TabIndex = 4;
            this.saveTag.Text = "Save Tag";
            this.saveTag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveTag.UseVisualStyleBackColor = false;
            this.saveTag.Click += new System.EventHandler(this.saveTag_Click);
            // 
            // previewTag
            // 
            this.previewTag.BackColor = System.Drawing.SystemColors.Window;
            this.previewTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewTag.Image = global::Windward.Properties.Resources.preview;
            this.previewTag.Location = new System.Drawing.Point(12, 12);
            this.previewTag.Name = "previewTag";
            this.previewTag.Size = new System.Drawing.Size(68, 78);
            this.previewTag.TabIndex = 3;
            this.previewTag.Text = "Preview";
            this.previewTag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.previewTag.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // tagTypeValue
            // 
            this.tagTypeValue.Location = new System.Drawing.Point(113, 29);
            this.tagTypeValue.Name = "tagTypeValue";
            this.tagTypeValue.Size = new System.Drawing.Size(118, 20);
            this.tagTypeValue.TabIndex = 3;
            // 
            // nicknameValue
            // 
            this.nicknameValue.Location = new System.Drawing.Point(113, 65);
            this.nicknameValue.Name = "nicknameValue";
            this.nicknameValue.Size = new System.Drawing.Size(118, 20);
            this.nicknameValue.TabIndex = 4;
            // 
            // editTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveTag);
            this.Controls.Add(this.previewTag);
            this.Controls.Add(this.queryControl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.Name = "editTagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Tag";
            this.Load += new System.EventHandler(this.editTagForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.queryControl.ResumeLayout(false);
            this.queryAndProp.ResumeLayout(false);
            this.propertiesTab.ResumeLayout(false);
            this.propertiesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl queryControl;
        private System.Windows.Forms.TabPage queryAndProp;
        private System.Windows.Forms.TabPage propertiesTab;
        private System.Windows.Forms.Button previewTag;
        private System.Windows.Forms.Button saveTag;
        private System.Windows.Forms.RichTextBox queryTabValue;
        private System.Windows.Forms.TextBox nicknameValue;
        private System.Windows.Forms.TextBox tagTypeValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}