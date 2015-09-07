using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    using MultiplicationTable;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int selectedTable = Convert.ToInt32(comboBox.SelectedItem);

            Multiplication multi = new Multiplication();
            string timesTable = multi.FormatTable(multi.Generate(selectedTable));

            this.richTextBox1.Text = timesTable;
        }
    }
}
