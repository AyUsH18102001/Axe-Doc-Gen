using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Text.Json;

namespace Windward
{
    public partial class inputParameterForm : Form
    {
        public inputParameterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            dynamic properties = Globals.ThisAddIn.Application.ActiveDocument.CustomDocumentProperties;
            if (properties.Count == 0)
                return;

            int i = 1;
            int paramCount = int.Parse(properties["paramCount"].Value.ToString());
            while (i <= paramCount)
            {
                if (properties[$"param{i}"].Value.ToString() == "")
                    return;
                Parameter param = JsonSerializer.Deserialize<Parameter>(properties[$"param{i}"].Value.ToString());
                ListViewItem item = new ListViewItem(param.id);
                item.SubItems.Add(param.required);
                item.SubItems.Add(param.type);
                item.SubItems.Add(param.defaultValue);
                parametersList.Items.Add(item);
                i++;
            }
        }


        private void addParameter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idValue.Text) || string.IsNullOrEmpty(defaultValue.Text) ||
                string.IsNullOrEmpty(typeValue.Text))
                return;
            ListViewItem item = new ListViewItem(idValue.Text);
            if (requiredValue.Checked)
            {
                item.SubItems.Add("True");
            }
            else
            {
                item.SubItems.Add("False");
            }
            item.SubItems.Add(typeValue.Text);
            item.SubItems.Add(defaultValue.Text);
            parametersList.Items.Add(item);

            // Adding string JSON as parameters to CustomProperties
            dynamic properties = Globals.ThisAddIn.Application.ActiveDocument.CustomDocumentProperties;

            string paramsList = $"{{\"id\": \"{idValue.Text}\",\"required\":\"{requiredValue.Checked}\",\"type\": \"{typeValue.Text}\",\"defaultValue\":\"{defaultValue.Text}\" }}";
            if (properties.Count == 0)
            {
                properties.Add("paramCount",false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString,"1");
                properties.Add("param1", false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, paramsList);
            }
            else
            {
                int paramCount = int.Parse(properties["paramCount"].Value.ToString())+1;
                properties.Add($"param{paramCount}", false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, paramsList);
                properties["paramCount"].Value = paramCount;
            }
            resetFields();
        }

        private void removeParameter_Click(object sender, EventArgs e)
        {
            if (parametersList.Items.Count > 0)
            {
                int index = parametersList.SelectedItems[0].Index;
                parametersList.Items.Remove(parametersList.SelectedItems[0]);
                // Updating custom properties after removing
                removeCustomProperty(index);
            }
        }

        private void replaceParameter_Click(object sender, EventArgs e)
        {
            int index = parametersList.SelectedItems[0].Index;
            parametersList.Items.RemoveAt(index);

            if (string.IsNullOrEmpty(idValue.Text) || string.IsNullOrEmpty(defaultValue.Text) ||
                string.IsNullOrEmpty(typeValue.Text))
                return;
            ListViewItem item = new ListViewItem(idValue.Text);
            if (requiredValue.Checked)
                item.SubItems.Add("True");
            else
                item.SubItems.Add("False");
            item.SubItems.Add(typeValue.Text);
            item.SubItems.Add(defaultValue.Text);

            parametersList.Items.Insert(index, item);

            // Updating custom properties after replacing
            replaceCustomProperty(index);
        }

        private void parametersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idValue.Text) || string.IsNullOrEmpty(defaultValue.Text) ||
                string.IsNullOrEmpty(typeValue.Text))
            {
                ListViewItem selectedItem = parametersList.SelectedItems[0];
                idValue.Text = selectedItem.SubItems[0].Text;
                typeValue.Text = selectedItem.SubItems[2].Text;
                defaultValue.Text = selectedItem.SubItems[3].Text;
                if (selectedItem.SubItems[1].Text == "True")
                {
                    requiredValue.Checked = true;
                }
                else
                {
                    requiredValue.Checked = false;
                }
            }
        }

        private void resetFields()
        {
            requiredValue.Checked = false;
            typeValue.Text = "";
            idValue.Clear();
            defaultValue.Clear();
        }

        public class Parameter
        {
            public String id { get; set; }
            public String required { get; set; }
            public String type { get; set; }
            public String defaultValue { get; set; }
        }

        private void replaceCustomProperty(int index)
        {
            dynamic properties = Globals.ThisAddIn.Application.ActiveDocument.CustomDocumentProperties;
            if (properties.Count == 0)
                return;

            string paramsList = $"{{\"id\": \"{idValue.Text}\",\"required\":\"{requiredValue.Checked}\",\"type\": \"{typeValue.Text}\",\"defaultValue\":\"{defaultValue.Text}\" }}";
            properties[$"param{index+1}"].Value = paramsList;
            resetFields();
        }

        private void removeCustomProperty(int index)
        {
            dynamic properties = Globals.ThisAddIn.Application.ActiveDocument.CustomDocumentProperties;
            if (properties.Count == 0)
                return;
            properties[$"param{index+1}"].Value = "";
            resetFields();
        }
    }
}
