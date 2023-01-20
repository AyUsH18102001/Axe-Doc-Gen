using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using form = System.Windows.Forms;


namespace Windward
{
    public partial class Ribbon1
    {
        public static editTagForm editTagForm = new editTagForm();
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            editTag.Enabled = false;
        }

        private void dataSource_ItemsLoading(object sender, RibbonControlEventArgs e)
        {

        }

        private void inputParameters_Click(object sender, RibbonControlEventArgs e)
        {
            inputParameterForm form = new inputParameterForm();
            form.Show();
        }

        private void output_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            if (output.SelectedItem.Label == "PDF")
            {
                Random random = new Random();
                int num1 = random.Next();
                int num2 = random.Next();
                string docName = doc.Name;
                string tempPath = System.IO.Path.GetTempPath();
                string sFullpath_pdf = tempPath + '_' + docName + '_' + (num1+num2) + ".pdf";
                doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
                return;
            }

            if (string.IsNullOrEmpty(doc.Path))
            {
                form.MessageBox.Show("The Document file is empty");
                return;
            }
        }

        private void output_ItemsLoading(object sender, RibbonControlEventArgs e)
        {
            output.SelectedItemIndex = 0;
        }

        private void tags_ItemsLoading(object sender, RibbonControlEventArgs e)
        {
            tags.SelectedItemIndex = 0;
        }

        private void tags_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;

            if (tags.SelectedItem.Label == "Out")
            {
                object fieldType = Word.WdFieldType.wdFieldAutoTextList;
                object text = " [out] \\t \"<Tag type='out'/>\" ";
                object preserve = false;
                doc.Fields.Add(currentRange, fieldType, text, preserve);
            }
            if (tags.SelectedItem.Label == "Query")
            {
                currentRange.Text = "[query]";
                object text = " [query] \\t \"<Tag type='query' varname=''/>\" ";
            }
            if (tags.SelectedItem.Label == "IF")
            {
                currentRange.Text = "[if]";
            }
            if (tags.SelectedItem.Label == "End If")
            {
                currentRange.Text = "[end if]";
            }
        }

        private void editTag_Click(object sender, RibbonControlEventArgs e)
        {
            editTagForm.Show();
        }

        private void text_selected(object sender, RibbonControlEventArgs e)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            if (Word.WdFieldType.wdFieldAutoTextList.Equals(currentRange))
            {
                editTag.Enabled = true;
                return;
            }
            editTag.Enabled = false;
        }

    }
}
