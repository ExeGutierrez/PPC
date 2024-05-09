using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PPC
{
    public partial class Form1 : Form
    {
        private Button printButton = new Button();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        public Form1()
        {
            InitializeComponent();

            printButton.Text = "Vista previa de impresión";
           // printButton.Size = new Size();
            printButton.Click += new EventHandler(printButton_Click);
            this.Controls.Add(printButton);
        }

        void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = "Hola, este es un texto de prueba para la vista previa de impresión.";
            e.Graphics.DrawString(text, new Font("Arial", 20), Brushes.Black, 10, 10);
        }
    }
}
