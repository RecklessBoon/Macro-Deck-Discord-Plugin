using System;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class PeekablePassword : UserControl
    {
        public override string Text
        {
            get
            {
                return password.Text;
            }
            set
            {
                password.Text = value;
            }
        }

        public void ToggleText()
        {
            btnShow.BackgroundImage = getBtnShowUrlToggleImage();
            btnShow.Tag = getBtnShowUrlToggleTag();
            password.PasswordChar = !password.PasswordChar;

            tmpButtonImage = null;
        }

        public PeekablePassword()
        {
            InitializeComponent();
        }

        private System.Drawing.Image tmpButtonImage;

        private void btnShow_Click(object sender, EventArgs e)
        {
            ToggleText();
        }

        private void btnShow_MouseEnter(object sender, EventArgs e)
        {
            tmpButtonImage = btnShow.BackgroundImage;
            btnShow.BackgroundImage = getBtnShowUrlToggleImage();
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            if (tmpButtonImage != null)
            {
                btnShow.BackgroundImage = tmpButtonImage;
                tmpButtonImage = null;
            }
        }

        private System.Drawing.Image getBtnShowUrlToggleImage()
        {
            if (btnShow.Tag.ToString() == "ToShow")
            {
                return Properties.Resources.eye;
            }
            else
            {
                return Properties.Resources.eye_outline;
            }
        }

        private string getBtnShowUrlToggleTag()
        {
            if (btnShow.Tag.ToString() == "ToShow")
            {
                return "ToHide";
            }
            else
            {
                return "ToShow";
            }
        }
    }
}
