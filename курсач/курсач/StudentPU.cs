using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class StudentPU : basicForm
    {
        public StudentPU()
        {
            InitializeComponent();
        }

        private void StudentPU_Load(object sender, EventArgs e)
        {
            object readOnly = true;
            object visible = true;
            object fileName = path + selectedItem+".docx";
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word.Document document;
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            document = application.Documents.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing,
                missing, missing, visible, missing, missing, missing, missing);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            IDataObject dataObject = Clipboard.GetDataObject();
            richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            application.Quit(missing, missing, missing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(path + selectedItem+".docx");
        }
    }
}
