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
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;



namespace Windward
{
    public partial class editTagForm : Form
    {
        public editTagForm()
        {
            InitializeComponent();
        }

        private void editTagForm_Load(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection Sel = Globals.ThisAddIn.Application.Selection;
            if (Sel.Information[Word.WdInformation.wdInFieldResult] == true)
            {
                Word.Field FirstField = doc.Range().Fields[1];
                Regex rx = new Regex(" \"(.*?)\" ");
                if (rx.Match(FirstField.Code.Text).Success)
                {
                    string stringifyXML = rx.Match(FirstField.Code.Text).Groups[0].Value.Trim();
                    stringifyXML = stringifyXML.Substring(1, stringifyXML.Length - 2);
                    XmlSerializer serializer = new XmlSerializer(typeof(Tag));
                    StringReader stringReader = new StringReader(stringifyXML);
                    Tag tag = (Tag)serializer.Deserialize(stringReader);

                    tagTypeValue.Text = tag.tagType;
                    queryTabValue.Text = tag.query;
                    nicknameValue.Text = tag.nickname;
                }
            }
        }

        private void queryAndProp_Click(object sender, EventArgs e)
        {

        }

        private void saveTag_Click(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection Sel = Globals.ThisAddIn.Application.Selection;
            if (Sel.Information[Word.WdInformation.wdInFieldResult] == true)
            {
                Word.Field FirstField = doc.Range().Fields[1];
                Regex rx = new Regex(" \"(.*?)\" ");
                if (rx.Match(FirstField.Code.Text).Success)
                {   
                    // updating the fields to the newly updated nickname or query
                    object fieldType = FirstField.Type;
                    object text = $" [{tagTypeValue.Text.ToLower()}] \\t \"<Tag nickname='{nicknameValue.Text}' type='{tagTypeValue.Text}' query='{queryTabValue.Text}'/>\" ";
                    object preserve = false;
                    doc.Range().Text = "";  // removing the previous tag
                    Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
                    doc.Fields.Add(currentRange, fieldType, text, preserve);  // updating with the new updated tag
                }
                // closing the editTagForm
                this.Close();
            }
        }

        [XmlRoot("Tag")]
        public class Tag
        {
            [XmlAttribute("type")]
            public String tagType { get; set; }
            [XmlAttribute("nickname")]
            public String nickname { get; set; }
            [XmlAttribute("query")]
            public String query { get; set; }
            [XmlAttribute("varname")]
            public String varname { get; set; }
        }
    }


}
