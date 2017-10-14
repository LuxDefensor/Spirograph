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
using System.Globalization;

namespace Spirograph
{
    public partial class formMain : Form
    {

        // TODO: 3) Выбор размеров холста, масштабирование, панарамирование
        // TODO: 4) Сохранение результата в файл jpg, bmp или png
        // TODO: 5) Сохранение процесса в файл анимации (видео или gif)

        private ResourceManager r = new ResourceManager(typeof(String));
        private Spirograph s = null;
        private Bitmap bmp;
        

        #region Default values
        private int defaultFixedOuterR = 210;
        private int defaultFixedInnerR = 162;
        private int defaultMovingOuterR = 90;
        private int defaultMovingInnerR = 12;
        private Edges defaultFixedTouch = Edges.Inner;
        private Edges defaultMovingTouch = Edges.Outer;
        private int defaultStartAngle = 0;
        private double defaultDelta = 1;
        private int defaultLoops = 5;
        private int defaultDelay = 3;
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
            btnOpenParams.Click += BtnOpenParams_Click;
            #endregion
        }

        private void BtnOpenParams_Click(object sender, EventArgs e)
        {
            string buffer;
            openFileDialog1.Title = Localization.GetString("OpenParams");
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "All files|*.*|Parameter sets|*.xml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.AddExtension = true;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                #region XML Reading
                NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
                XmlDocument xml = new XmlDocument();
                xml.Load(openFileDialog1.FileName);
                try
                {
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/Loops").InnerText;
                    s.Loops = int.Parse(buffer);
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/StartAngle").InnerText;
                    s.StartAngle = double.Parse(buffer, numberFormat);
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/DeltaAngle").InnerText;
                    s.DeltaAngle = double.Parse(buffer, numberFormat);
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/Delay").InnerText;
                    s.Delay = int.Parse(buffer);
                    nudDelay.Value = s.Delay;
                    float w, h;
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/BoundsWidth").InnerText;
                    w = float.Parse(buffer, numberFormat);
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/BoundsHeight").InnerText;
                    h = float.Parse(buffer, numberFormat);
                    s.Bounds = new RectangleF(s.Bounds.X, s.Bounds.Y, w, h);
                    int w1, h1;
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/CanvasSizeWidth").InnerText;
                    w1 = int.Parse(buffer);
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/CanvasSizeHeight").InnerText;
                    h1 = int.Parse(buffer);
                    s.CanvasSize = new Size(w1, h1);
                    buffer = xml.SelectSingleNode("//ParametersSet/Spirograph/BackColor").InnerText;
                    if (buffer.Substring(0, 2) == "ff")
                        s.BackColor = Color.FromArgb(int.Parse(buffer, NumberStyles.AllowHexSpecifier));
                    else
                        s.BackColor = Color.FromName(buffer);
                    picBackColor.BackColor = s.BackColor;
                    int inner, outer;
                    buffer = xml.SelectSingleNode("//ParametersSet/FixedRing/OuterRadius").InnerText;
                    outer = int.Parse(buffer);
                    buffer = xml.SelectSingleNode("//ParametersSet/FixedRing/InnerRadius").InnerText;
                    inner = int.Parse(buffer);
                    s.FixedRing.EditRing(inner, outer);
                    buffer = xml.SelectSingleNode("//ParametersSet/FixedRing/Touch").InnerText;
                    s.FixedRing.Touch = (Edges)Enum.Parse(typeof(Edges), buffer);
                    buffer = xml.SelectSingleNode("//ParametersSet/MovingRing/OuterRadius").InnerText;
                    outer = int.Parse(buffer);
                    buffer = xml.SelectSingleNode("//ParametersSet/MovingRing/InnerRadius").InnerText;
                    inner = int.Parse(buffer);
                    s.MovingRing.EditRing(inner, outer);
                    buffer = xml.SelectSingleNode("//ParametersSet/MovingRing/Touch").InnerText;
                    s.MovingRing.Touch = (Edges)Enum.Parse(typeof(Edges), buffer);
                    XmlNodeList quills = xml.SelectNodes("//ParametersSet/MovingRing/Quills/Quill");
                    XmlNodeList elements;
                    double angularPosition, radialPosition;
                    Color penColor;
                    angularPosition = 0;
                    radialPosition = 0;
                    penColor = Color.Black;
                    s.MovingRing.Quills.Clear();
                    foreach (XmlNode q in quills)
                    {
                        elements = q.ChildNodes;
                        foreach (XmlNode element in elements)
                        {
                            switch (element.Name)
                            {
                                case "AngularPosition":
                                    angularPosition = double.Parse(element.InnerText, numberFormat);
                                    break;
                                case "RadialPosition":
                                    radialPosition = double.Parse(element.InnerText, numberFormat);
                                    break;
                                case "Pen":
                                    penColor = Color.FromName(element.InnerText);
                                    break;
                                default:
                                    throw new Exception(Localization.GetString("ErrorBadQuillDescriptionInXML"));
                            }
                        }
                        s.MovingRing.AddQuill(angularPosition, radialPosition, new Pen(penColor));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Localization.GetString("ErrorReadXML") + Environment.NewLine + 
                        ex.Message, Localization.GetString("ErrorTitle"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }

        private void BtnSaveParams_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = Localization.GetString("SaveParams");
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "All files|*.*|Parameter sets|*.xml";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                #region XML writing

                NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
                XmlWriter xml = XmlWriter.Create(saveFileDialog1.FileName);
                xml.WriteStartDocument();
                xml.WriteStartElement("ParametersSet");
                    xml.WriteStartElement("Created");
                        xml.WriteString(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    xml.WriteEndElement();
                    xml.WriteStartElement("Spirograph");
                        xml.WriteStartElement("Loops");
                            xml.WriteString(s.Loops.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("StartAngle");
                            xml.WriteString(s.StartAngle.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("DeltaAngle");
                            xml.WriteString(s.DeltaAngle.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("Delay");
                            xml.WriteString(s.Delay.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("BoundsWidth");
                            xml.WriteString(s.Bounds.Width.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("BoundsHeight");
                            xml.WriteString(s.Bounds.Height.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("CanvasSizeWidth");
                            xml.WriteString(s.CanvasSize.Width.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("CanvasSizeHeight");
                            xml.WriteString(s.CanvasSize.Height.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("BackColor");
                            xml.WriteString(s.BackColor.Name);
                        xml.WriteEndElement();
                    xml.WriteEndElement();
                    xml.WriteStartElement("FixedRing");
                        xml.WriteStartElement("OuterRadius");
                            xml.WriteString(s.FixedRing.OuterRadius.ToString(numberFormat));            
                        xml.WriteEndElement();
                        xml.WriteStartElement("InnerRadius");
                            xml.WriteString(s.FixedRing.InnerRadius.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("Touch");
                            xml.WriteString(s.FixedRing.Touch.ToString());
                        xml.WriteEndElement();
                    xml.WriteEndElement();
                    xml.WriteStartElement("MovingRing");
                        xml.WriteStartElement("OuterRadius");
                            xml.WriteString(s.MovingRing.OuterRadius.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("InnerRadius");
                            xml.WriteString(s.MovingRing.InnerRadius.ToString(numberFormat));
                        xml.WriteEndElement();
                        xml.WriteStartElement("Touch");
                            xml.WriteString(s.MovingRing.Touch.ToString());
                        xml.WriteEndElement();
                        xml.WriteStartElement("Quills");
                            foreach (Quill quill in s.MovingRing.Quills)
                            {
                                xml.WriteStartElement("Quill");
                                    xml.WriteStartElement("AngularPosition");
                                        xml.WriteString(quill.AngularPosition.ToString(numberFormat));
                                    xml.WriteEndElement();
                                    xml.WriteStartElement("RadialPosition");
                                        xml.WriteString(quill.RadialPosition.ToString(numberFormat));
                                    xml.WriteEndElement();
                                    xml.WriteStartElement("Pen");
                                        xml.WriteString(quill.Pen.Color.Name);
                                    xml.WriteEndElement();
                                xml.WriteEndElement();
                            }
                        xml.WriteEndElement();
                    xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
                #endregion
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
            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = ">>>";
            s.Draw();
            picCanvas.Image = s.Bmp;
            lblStatus.Text = string.Empty;
            this.Cursor = Cursors.Default;
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
