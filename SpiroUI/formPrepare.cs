using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Spirograph
{
    public partial class formPrepare : Form
    {
        private Graphics canvas;
        private Bitmap bmp;
        private List<Quill> quills;
        private formMain main;

        public formPrepare()
        {
            InitializeComponent();
            quills = new List<Quill>();
            #region Event handlers
            this.Load += FormPrepare_Load;
            this.Enter += UpdatePreview;
            txtFixedInnerR.TextChanged += UpdatePreview;
            txtFixedOuterR.TextChanged += UpdatePreview;
            txtMovingInnerR.TextChanged += UpdatePreview;
            txtMovingOuterR.TextChanged += UpdatePreview;
            cboFixedTouch.SelectedIndexChanged += UpdatePreview;
            cboMovingTouch.SelectedIndexChanged += UpdatePreview;
            btnRemoveQuill.Click += BtnRemoveQuill_Click;
            btnAddQuill.Click += BtnAddQuill_Click;
            btnRefresh.Click += UpdatePreview;
            btnClose.Click += BtnClose_Click;
            #endregion
        }

        private void BtnAddQuill_Click(object sender, EventArgs e)
        {
            Quill q;
            dlgNewQuill dlg = new dlgNewQuill();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                q = new Quill();
                q.AngularPosition = dlg.AngularPosition;
                q.RadialPosition = dlg.RadialPosition;
                q.Pen = new Pen(dlg.PenColor);
                quills.Add(q);
                lstQuills.Update();
                UpdatePreview(sender, e);
            }
        }

        private void BtnRemoveQuill_Click(object sender, EventArgs e)
        {
            if (lstQuills.SelectedIndex < 0)
                return;
            quills.RemoveAt(lstQuills.SelectedIndex);
            UpdatePreview(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            double startAngle;
            if (!double.TryParse(txtStartAngle.Text, out startAngle))
            {
                MessageBox.Show(Localization.GetString("ErrorWrongNumber") +
                    Localization.GetString("StartAngle"),
                    Localization.GetString("ErrorTitle"),
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            main.S.FixedRing = new Ring((int)txtFixedInnerR.Value, (int)txtFixedOuterR.Value);
            main.S.FixedRing.Touch = cboFixedTouch.SelectedIndex == 0 ? Edges.Outer : Edges.Inner;
            main.S.MovingRing = new Ring((int)txtMovingInnerR.Value, (int)txtMovingOuterR.Value);
            main.S.MovingRing.Touch = cboMovingTouch.SelectedIndex == 0 ? Edges.Outer : Edges.Inner;
            main.S.MovingRing.Quills.AddRange(quills);
            main.S.Loops = (int)txtLoopsCount.Value;
            main.S.StartAngle = startAngle;
            this.Close();
        }

        private void UpdatePreview(object sender, EventArgs e)
        {
            int fixedR, movingR;
            fixedR = cboFixedTouch.SelectedIndex == 0 ? (int)txtFixedOuterR.Value : (int)txtFixedInnerR.Value;
            movingR = cboMovingTouch.SelectedIndex == 0 ? (int)txtMovingOuterR.Value : (int)txtMovingInnerR.Value;
            txtLoopsToClose.Text = Utils.CountLoops(fixedR, movingR).ToString();
            lstQuills.Items.Clear();
            lstQuills.Items.AddRange(quills.Select(q => q.ToString()).ToArray());
            DrawPrewiew();
        }

        private void FormPrepare_Load(object sender, EventArgs e)
        {
            main = (formMain)this.Owner;
            Left = Owner.ClientRectangle.Left;
            Top = Owner.ClientRectangle.Top;
            Height = Owner.ClientRectangle.Height;
            Width = Owner.ClientRectangle.Width;
            bmp = new Bitmap(picPreview.Width, picPreview.Height);
            canvas = Graphics.FromImage(bmp);
            Text = Localization.GetString("PrepareWindowTitle");
            lblFixedElement.Text = Localization.GetString("FixedElement");
            lblFixedOuterR.Text = Localization.GetString("OuterRadius");
            lblFixedInnerR.Text = Localization.GetString("InnerRadius");
            lblFixedTouch.Text = Localization.GetString("TouchBy");
            cboFixedTouch.Items.Add(Localization.GetString("TouchByOuter"));
            cboFixedTouch.Items.Add(Localization.GetString("TouchByInner"));
            cboFixedTouch.SelectedIndex = 1;
            lblMovingElement.Text = Localization.GetString("MovingElement");
            lblMovingOuterR.Text = Localization.GetString("OuterRadius");
            lblMovingInnerR.Text = Localization.GetString("InnerRadius");
            lblMovingTouch.Text = Localization.GetString("TouchBy");
            cboMovingTouch.Items.Add(Localization.GetString("TouchByOuter"));
            cboMovingTouch.Items.Add(Localization.GetString("TouchByInner"));
            cboMovingTouch.SelectedIndex = 0;
            lblQuills.Text = Localization.GetString("PensList");
            lblStartAngle.Text = Localization.GetString("StartAngle");
            lblCurveWillClose.Text = Localization.GetString("CurveWillClose");
            lblLoops1.Text = Localization.GetString("Loops");
            btnClose.Text = Localization.GetString("CloseButton");
            // Load defaults from Main form
            txtFixedOuterR.Value = main.S.FixedRing.OuterRadius;
            txtFixedInnerR.Value = main.S.FixedRing.InnerRadius;
            txtMovingOuterR.Value = main.S.MovingRing.OuterRadius;
            txtMovingInnerR.Value = main.S.MovingRing.InnerRadius;
            cboFixedTouch.SelectedIndex = main.S.FixedRing.Touch == Edges.Outer ? 0 : 1;
            cboMovingTouch.SelectedIndex = main.S.MovingRing.Touch == Edges.Outer ? 0 : 1;
            txtStartAngle.Text = main.S.StartAngle.ToString();
            txtLoopsCount.Value = main.S.Loops;
            quills.Clear();
            quills = new List<Quill>(main.S.MovingRing.Quills);
            UpdatePreview(this, new EventArgs());
        }

        private void DrawPrewiew()
        {
            int fixedOuterR, fixedInnerR, movingOuterR, movingInnerR;
            PointF fixedCenter, movingCenter, quillCenter;
            fixedCenter = new PointF();
            movingCenter = new PointF();
            quillCenter = new PointF();
            #region Read parameters

            fixedOuterR = (int)txtFixedOuterR.Value;
            fixedInnerR = (int)txtFixedInnerR.Value;
            movingOuterR = (int)txtMovingOuterR.Value;
            movingInnerR = (int)txtMovingInnerR.Value;
            fixedCenter.X = movingCenter.X = picPreview.Width / 2;
            if (cboFixedTouch.Text == Localization.GetString("TouchByOuter"))
            {
                if (cboMovingTouch.Text == Localization.GetString("TouchByOuter"))
                {
                    fixedCenter.Y = picPreview.Height / 2 + movingOuterR;
                    movingCenter.Y = picPreview.Height / 2 - fixedOuterR;
                }
                else
                {
                    fixedCenter.Y = (picPreview.Height + movingOuterR - movingInnerR) / 2;
                    movingCenter.Y = (picPreview.Height - 2 * fixedOuterR + movingOuterR + movingInnerR) / 2;
                }
            }
            else
            {
                fixedCenter.Y = picPreview.Height / 2;
                if (cboMovingTouch.Text == Localization.GetString("TouchByOuter"))
                    movingCenter.Y = fixedCenter.Y - fixedInnerR + movingOuterR;
                else
                    movingCenter.Y = fixedCenter.Y - fixedInnerR + movingInnerR;
            }
            #endregion
            canvas.Clear(picPreview.BackColor);
            canvas.DrawEllipse(Pens.Blue, fixedCenter.X - fixedOuterR,
                                        fixedCenter.Y - fixedOuterR,
                                        2 * fixedOuterR,
                                        2 * fixedOuterR);
            canvas.DrawEllipse(Pens.Blue, fixedCenter.X - fixedInnerR,
                                        fixedCenter.Y - fixedInnerR,
                                        2 * fixedInnerR,
                                        2 * fixedInnerR);
            canvas.DrawEllipse(Pens.Red, movingCenter.X - movingOuterR,
                                        movingCenter.Y - movingOuterR,
                                        2 * movingOuterR,
                                        2 * movingOuterR);
            canvas.DrawEllipse(Pens.Red, movingCenter.X - movingInnerR,
                                        movingCenter.Y - movingInnerR,
                                        2 * movingInnerR,
                                        2 * movingInnerR);
            foreach (Quill quill in quills)
            {
                quillCenter.X = (float)(movingCenter.X +
                    (quill.RadialPosition * (movingOuterR - movingInnerR) / 100 + movingInnerR) *
                    Math.Cos(Utils.Degrees2Radians(quill.AngularPosition)));
                quillCenter.Y = (float)(movingCenter.Y +
                    (quill.RadialPosition * (movingOuterR - movingInnerR) / 100 + movingInnerR) *
                    Math.Sin(Utils.Degrees2Radians(quill.AngularPosition)));
                canvas.DrawEllipse(quill.Pen, quillCenter.X - 2,
                                        quillCenter.Y - 2,
                                        4, 4);
            }
            picPreview.Image = bmp;
        }
    }
}
