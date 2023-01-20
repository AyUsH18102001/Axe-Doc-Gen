using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using form = System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Windward
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            this.Application.WindowBeforeDoubleClick += new Word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(Application_WindowDoubleClick);
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }


        internal void Application_WindowDoubleClick(Word.Selection Sel, ref bool Cancel)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            if (Sel.Information[Word.WdInformation.wdInFieldResult] == true)
            {
                Word.Field FirstField = doc.Range().Fields[1];
                Regex rx = new Regex("\"(.*?)\"");
                if (rx.Match(FirstField.Code.Text).Success)
                {
                    //Enabling the edit Tag button
                    Globals.Ribbons.Ribbon1.editTag.Enabled = true;

                    // Opening the editTag form
                    editTagForm form = new editTagForm();
                    form.Show();
                }
            }
            Cancel = true;
            //Disabliing the edit Tag button
            Globals.Ribbons.Ribbon1.editTag.Enabled = false;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }

}
