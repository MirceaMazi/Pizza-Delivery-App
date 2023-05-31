using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery.Forms
{
    public partial class FormFeedback : Form
    {
        private PrintDocument printDocument;
        private StringBuilder documentContent;
        public FormFeedback()
        {
            InitializeComponent();
            
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            btnprint.Click += btnPrint_Click;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            documentContent = new StringBuilder();

            string firstOption = getSelection(gbPizza);
            string secondOption = getSelection(gbRecomandare);
            string text = textBox1.Text;

            documentContent.AppendLine("Optiunea Pizza:");
            documentContent.AppendLine(firstOption);
            documentContent.AppendLine();
            documentContent.AppendLine("Optiunea recomandare:");
            documentContent.AppendLine(secondOption);
            documentContent.AppendLine();
            documentContent.AppendLine("Text:");
            documentContent.AppendLine(text);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private string getSelection(GroupBox groupBox)
        {
            foreach(RadioButton radioButton in groupBox.Controls)
            {
                if(radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return string.Empty;
        }

        private int currentPageIndex = 0;
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            float currentY = e.MarginBounds.Top;
            int linesPerPage = (int)(e.MarginBounds.Height / lineHeight);

            string[] lines = documentContent.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            int startIndex = currentPageIndex * linesPerPage;

            for (int lineIndex = startIndex; lineIndex < lines.Length; lineIndex++)
            {
                if (currentY + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    currentPageIndex++;
                    return;
                }

                e.Graphics.DrawString(lines[lineIndex], font, Brushes.Black, e.MarginBounds.Left, currentY, new StringFormat());
                currentY += lineHeight;
            }

            e.HasMorePages = false;
            currentPageIndex = 0;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text).ToString();
            textBox1.AppendText(droppedText);
        }

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
