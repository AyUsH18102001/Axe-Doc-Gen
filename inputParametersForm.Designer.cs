
namespace Windward
{
    partial class inputParameterForm
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
            this.parametersList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Required = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Default = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addParameter = new System.Windows.Forms.Button();
            this.defaultValue = new System.Windows.Forms.TextBox();
            this.typeValue = new System.Windows.Forms.ComboBox();
            this.requiredValue = new System.Windows.Forms.CheckBox();
            this.idValue = new System.Windows.Forms.TextBox();
            this.removeParameter = new System.Windows.Forms.Button();
            this.replaceParameter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parametersList
            // 
            this.parametersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Required,
            this.Type,
            this.Default});
            this.parametersList.FullRowSelect = true;
            this.parametersList.GridLines = true;
            this.parametersList.HideSelection = false;
            this.parametersList.Location = new System.Drawing.Point(12, 110);
            this.parametersList.Name = "parametersList";
            this.parametersList.Size = new System.Drawing.Size(427, 257);
            this.parametersList.TabIndex = 6;
            this.parametersList.UseCompatibleStateImageBehavior = false;
            this.parametersList.View = System.Windows.Forms.View.Details;
            this.parametersList.SelectedIndexChanged += new System.EventHandler(this.parametersList_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Required
            // 
            this.Required.Text = "Required";
            this.Required.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 150;
            // 
            // Default
            // 
            this.Default.Text = "Default";
            this.Default.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Default.Width = 150;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = global::Windward.Properties.Resources.help;
            this.button3.Location = new System.Drawing.Point(286, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 86);
            this.button3.TabIndex = 14;
            this.button3.Text = "Help";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = global::Windward.Properties.Resources.cancel;
            this.button4.Location = new System.Drawing.Point(221, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 86);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cancel";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::Windward.Properties.Resources.save;
            this.button2.Location = new System.Drawing.Point(156, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 86);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::Windward.Properties.Resources.rename;
            this.button1.Location = new System.Drawing.Point(77, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 86);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rename";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Image = global::Windward.Properties.Resources.add;
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 86);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Default";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Required";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addParameter
            // 
            this.addParameter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addParameter.Location = new System.Drawing.Point(510, 251);
            this.addParameter.Name = "addParameter";
            this.addParameter.Size = new System.Drawing.Size(102, 38);
            this.addParameter.TabIndex = 16;
            this.addParameter.Text = "Add Parameter";
            this.addParameter.UseVisualStyleBackColor = false;
            this.addParameter.Click += new System.EventHandler(this.addParameter_Click);
            // 
            // defaultValue
            // 
            this.defaultValue.Location = new System.Drawing.Point(510, 209);
            this.defaultValue.Name = "defaultValue";
            this.defaultValue.Size = new System.Drawing.Size(121, 20);
            this.defaultValue.TabIndex = 3;
            // 
            // typeValue
            // 
            this.typeValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.typeValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeValue.FormattingEnabled = true;
            this.typeValue.Items.AddRange(new object[] {
            "Text",
            "Number"});
            this.typeValue.Location = new System.Drawing.Point(510, 177);
            this.typeValue.Name = "typeValue";
            this.typeValue.Size = new System.Drawing.Size(121, 21);
            this.typeValue.TabIndex = 2;
            // 
            // requiredValue
            // 
            this.requiredValue.AutoSize = true;
            this.requiredValue.Location = new System.Drawing.Point(510, 151);
            this.requiredValue.Name = "requiredValue";
            this.requiredValue.Size = new System.Drawing.Size(15, 14);
            this.requiredValue.TabIndex = 1;
            this.requiredValue.UseVisualStyleBackColor = true;
            // 
            // idValue
            // 
            this.idValue.Location = new System.Drawing.Point(510, 118);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(69, 20);
            this.idValue.TabIndex = 0;
            // 
            // removeParameter
            // 
            this.removeParameter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeParameter.Location = new System.Drawing.Point(510, 339);
            this.removeParameter.Name = "removeParameter";
            this.removeParameter.Size = new System.Drawing.Size(69, 38);
            this.removeParameter.TabIndex = 17;
            this.removeParameter.Text = "Remove Parameter";
            this.removeParameter.UseVisualStyleBackColor = false;
            this.removeParameter.Click += new System.EventHandler(this.removeParameter_Click);
            // 
            // replaceParameter
            // 
            this.replaceParameter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.replaceParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceParameter.Location = new System.Drawing.Point(510, 295);
            this.replaceParameter.Name = "replaceParameter";
            this.replaceParameter.Size = new System.Drawing.Size(69, 38);
            this.replaceParameter.TabIndex = 18;
            this.replaceParameter.Text = "Replace Parameter";
            this.replaceParameter.UseVisualStyleBackColor = false;
            this.replaceParameter.Click += new System.EventHandler(this.replaceParameter_Click);
            // 
            // inputParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(663, 379);
            this.Controls.Add(this.replaceParameter);
            this.Controls.Add(this.removeParameter);
            this.Controls.Add(this.addParameter);
            this.Controls.Add(this.typeValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.requiredValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.defaultValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parametersList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputParameterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Parameters";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView parametersList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Required;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Default;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addParameter;
        private System.Windows.Forms.TextBox defaultValue;
        private System.Windows.Forms.ComboBox typeValue;
        private System.Windows.Forms.CheckBox requiredValue;
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.Button removeParameter;
        private System.Windows.Forms.Button replaceParameter;
    }
}