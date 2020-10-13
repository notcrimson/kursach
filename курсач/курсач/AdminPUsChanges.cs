using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace курсач
{
    public partial class AdminPUsChanges : basicForm
    {
        public string contentOfPuString;
        public string fileNameString;
        public AdminPUsChanges()
        {
            InitializeComponent();
        }

        private void PUPDFfile_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(openFileDialog1.FileName.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = path;
            openFileDialog1.Filter = "Word Document|*.doc; *.docx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName.ToString());
                object readOnly = true;
                object visible = true;
                object fileName = openFileDialog1.FileName.ToString();
                fileNameString = openFileDialog1.FileName.ToString();
                object missing = Type.Missing;
                Microsoft.Office.Interop.Word.Document document;
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                document = application.Documents.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing,
                    missing, missing, visible, missing, missing, missing, missing);
                document.ActiveWindow.Selection.WholeStory();
                document.ActiveWindow.Selection.Copy();
                IDataObject dataObject = Clipboard.GetDataObject();
                richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                contentOfPuString = dataObject.GetData(DataFormats.Rtf).ToString();
                application.Quit(missing, missing, missing);
            }
        }

        private void addPU_Click(object sender, EventArgs e)
        {
            if (contentOfPuString != null)
            {
                byte[] contentOfPuBytearray = Encoding.ASCII.GetBytes(contentOfPuString);

                Professional_unit pu = new Professional_unit();
                pu.Name_of_PU = fileNameString;

            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
    }
}
