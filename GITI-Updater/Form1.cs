using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;


//this app was made by Bill Strait. He's pretty cool.

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait while we inspect the files. You will be notified when done.");

            //this is to go through the garget directory and pull the files.
            string[] files = Directory.GetFiles(@txtTgt.Text,"*.doc");

            foreach (string item in files)
            {
                try
                {
                    //this block is prepairing our word object.
                    Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

                    object fileName = item;
                    object readOnly = false;
                    object isVisible = false;
                    object missing = System.Reflection.Missing.Value;
                    //this one tells the find command to replace everything.
                    object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
                    object matchCase = false;

                    //this block is setting up the string we're looking for and the string we're replacing it with
                    doc = word.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
                    doc.Activate();
                    word.Selection.Find.ClearFormatting();
                    word.Selection.Find.Text = txtOldStr.Text;
                    word.Selection.Find.Replacement.ClearFormatting();
                    word.Selection.Find.Replacement.Text = txtNewStr.Text;
                    if (!word.Selection.Find.Execute(ref missing, ref matchCase, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing))
                    {
                        txtFailed.Text += item + "\n";
                    }
                    doc.Save();
                    doc.Close(ref missing, ref missing, ref missing);
                    word.Application.Quit(ref missing, ref missing, ref missing);
                }
                catch
                {
                    txtFailed.Text += item + "\n";
                }
            }
            MessageBox.Show("Work Complete!");
        }
    }
}
