using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spirograph
{
    public partial class dlgNewQuill : Form
    {
        public dlgNewQuill()
        {
            InitializeComponent();
            this.Load += DlgNewQuill_Load;
            picPenColor.Click += PicPenColor_Click;
        }

        private void PicPenColor_Click(object sender, EventArgs e)
        {            
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                picPenColor.BackColor = colorDialog1.Color;
            }
        }

        private void DlgNewQuill_Load(object sender, EventArgs e)
        {
            Text = Localization.GetString("NewQuillWindowTitle");
            btnOK.Text = Localization.GetString("OKButton");
            btnCancel.Text = Localization.GetString("CancelButton");
        }

        public int AngularPosition
        {
        get
            {
                return (int)txtAngularPosition.Value;
            }
        }

        public int RadialPosition
        {
        get
            {
                return (int)txtRadialPosition.Value;
            }
        }

        public Color PenColor
        {
        get
            {
                return picPenColor.BackColor;
            }
        }
    }
}
