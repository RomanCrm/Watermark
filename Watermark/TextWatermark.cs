using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    public partial class TextWatermark : Form
    {
        private string text;
        public string TextBox
        {
            get => text;
            set => text = textBox1.Text;
        }

        public TextWatermark()
        {
            InitializeComponent();
        }

        private void Apply_Clicked(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                TextBox = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Watermark is an empty");
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
