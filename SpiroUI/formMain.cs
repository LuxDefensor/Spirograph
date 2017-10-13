using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Xml;

namespace Spirograph
{
    public partial class formMain : Form
    {

        // TODO: 2) Сохранение удачных наборов параметров (которые дают красивую картинку в текстовый файл (или xml)
        // TODO: 3) Выбор размеров холста, масштабирование, панарамирование
        // TODO: 4) Сохранение результата в файл jpg, bmp или png
        // TODO: 5) Сохранение процесса в файл анимации (видео или gif)

        private ResourceManager r = new ResourceManager(typeof(String));
        private Spirograph s = null;
        private Bitmap bmp;
        

        #region Default values
        private int defaultFixedOuterR = 210;
        private int defaultFixedInnerR = 175;
        private int defaultMovingOuterR = 90;
        private int defaultMovingInnerR = 12;
        private Edges defaultFixedTouch = Edges.Inner;
        private Edges defaultMovingTouch = Edges.Outer;
        private int defaultStartAngle = 0;
        private double defaultDelta = 1;
        private int defaultLoops = 1;
        private int defaultDelay = 5;
        private Color defaultQuillColor = Color.Red;
        private int defaultQuillAngular = 0;
        private int defaultQuillRadial = 50;
        private Size defaultCanvasSize = new Size(1920, 1080);
        #endregion

        public formMain()
        {
            InitializeComponent();
            #region Event handlers
            this.Load += Form1_Load;
            btnStart.Click += BtnStart_Click;
            btnPrepare.Click += BtnPrepare_Click;
            picBackColor.Click += PicBackColor_Click;
            nudDelay.ValueChanged += NudDelay_ValueChanged;
            btnSaveParams.Click += BtnSaveParams_Click;
            #endregion
        }

        private void BtnSaveParams_Click(object sender, EventArgs e)
        {
            XmlDocument xml;
            XmlText currentNode, prevousNode;
            saveFileDialog1.Title = Localization.GetString("SaveParams");
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "*|All files|*.xml|Parameter sets";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xml = new XmlDocument();
                currentNode = xml.CreateTextNode("Parameter set");
                xml.AppendChild(currentNode);
                prevousNode = currentNode;
                currentNode = xml.CreateTextNode("Created on " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                prevousNode.AppendChild(currentNode);
                prevousNode = currentNode;
                currentNode = xml.CreateTextNode("FixedRing");
                prevousNode.AppendChild(currentNode);
                prevousNode = currentNode;
                xml.Save(saveFileDialog1.FileName);
            }
        }

        private void NudDelay_ValueChanged(object sender, EventArgs e)
        {
            s.Delay = (int)nudDelay.Value;
        }

        private void PicBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                picBackColor.BackColor = colorDialog1.Color;
                picCanvas.BackColor = colorDialog1.Color;
                s.BackColor = colorDialog1.Color;
            }
        }

        private void BtnPrepare_Click(object sender, EventArgs e)
        {
            formPrepare frm = new formPrepare();
            frm.ShowDialog(this);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (s == null)
            {
                MessageBox.Show(Localization.GetString("ErrorNotPrepared"),
                                Localization.GetString("ErrorTitle"),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            statusStrip1.Text = ">>>";
            s.Draw();
            picCanvas.Image = s.Bmp;
            statusStrip1.Text = string.Empty;
        }

        public Spirograph S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picBackColor.BackColor = picCanvas.BackColor;
            s = new Spirograph();
            s.CanvasSize = defaultCanvasSize;
            s.Canvas = picCanvas.CreateGraphics();
            picCanvas.Image = bmp;
            s.Bounds = picCanvas.Bounds;
            s.BackColor = picBackColor.BackColor;
            s.DeltaAngle = defaultDelta;
            s.StartAngle = defaultStartAngle;
            s.Loops = defaultLoops;
            s.Delay = defaultDelay;
            nudDelay.Value = defaultDelay;
            s.FixedRing = new Ring(defaultFixedInnerR, defaultFixedOuterR);
            s.MovingRing = new Ring(defaultMovingInnerR, defaultMovingOuterR);
            s.FixedRing.Touch = defaultFixedTouch;
            s.MovingRing.Touch = defaultMovingTouch;
            s.MovingRing.Quills.Add(new Quill()
            {
                AngularPosition = defaultQuillAngular,
                RadialPosition = defaultQuillRadial,
                Pen = new Pen(defaultQuillColor)
            });
            Text = Localization.GetString("ApplicationTitle");
            btnPrepare.Text = Localization.GetString("PrepareButton");
            lblBackColor.Text = Localization.GetString("BackColor");
            lblDelay.Text = Localization.GetString("Delay");
            btnStart.Text = Localization.GetString("StartButton");
            lblCanvasSize.Text = Localization.GetString("CanvasSize");
            lblWidth.Text = Localization.GetString("Width");
            lblHeight.Text = Localization.GetString("Height");
            btnOpenParams.ToolTipText = Localization.GetString("OpenParams");
            btnSaveParams.ToolTipText = Localization.GetString("SaveParams");
        }
    }
}
