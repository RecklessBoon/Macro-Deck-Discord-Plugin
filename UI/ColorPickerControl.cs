using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class ColorPickerControl : UserControl
    {
        private bool _isSet = false;
        public bool IsSet
        {
            get { return _isSet; }
        }

        public Color Color
        {
            get { return colorDialog1.Color; }
            set { colorDialog1.Color = value; _isSet = true; panel1.BackColor = value; }
        }

        public ColorPickerControl()
        {
            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                _isSet = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            colorDialog1.Color = default;
            _isSet = false;
        }
    }
}
