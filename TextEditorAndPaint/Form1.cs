using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorAndPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofile = new OpenFileDialog();
                ofile.Filter = "txt files (*.txt)|*.txt";

                ofile.ShowDialog();

                if (ofile.FileName != "")
                {
                    string lines = File.ReadAllText(ofile.FileName);
                    rtxtEditor.Text = lines;

                }
                else
                {
                    MessageBox.Show("No seleccionó ningún archivo.");
                }
            }
            catch (Exception ex) 
            {
            
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfile = new SaveFileDialog();
                sfile.Filter = "txt files (*.txt)|*.txt";
                sfile.ShowDialog();
                File.WriteAllText(sfile.FileName, rtxtEditor.Text);
            }
            catch (Exception ex) 
            {
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            TabPaint.BackColor = color.Color;
        }
    }
}
