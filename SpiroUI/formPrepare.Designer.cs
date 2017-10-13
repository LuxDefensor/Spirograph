namespace Spirograph
{
    partial class formPrepare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFixedElement = new System.Windows.Forms.Label();
            this.lblFixedOuterR = new System.Windows.Forms.Label();
            this.lblFixedInnerR = new System.Windows.Forms.Label();
            this.lblFixedTouch = new System.Windows.Forms.Label();
            this.cboFixedTouch = new System.Windows.Forms.ComboBox();
            this.lblMovingElement = new System.Windows.Forms.Label();
            this.cboMovingTouch = new System.Windows.Forms.ComboBox();
            this.lblMovingTouch = new System.Windows.Forms.Label();
            this.lblMovingInnerR = new System.Windows.Forms.Label();
            this.lblMovingOuterR = new System.Windows.Forms.Label();
            this.lblQuills = new System.Windows.Forms.Label();
            this.lstQuills = new System.Windows.Forms.ListBox();
            this.btnAddQuill = new System.Windows.Forms.Button();
            this.btnRemoveQuill = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtStartAngle = new System.Windows.Forms.TextBox();
            this.lblStartAngle = new System.Windows.Forms.Label();
            this.txtLoopsToClose = new System.Windows.Forms.TextBox();
            this.lblCurveWillClose = new System.Windows.Forms.Label();
            this.lblLoops1 = new System.Windows.Forms.Label();
            this.lblLoopCount = new System.Windows.Forms.Label();
            this.txtFixedOuterR = new System.Windows.Forms.NumericUpDown();
            this.txtFixedInnerR = new System.Windows.Forms.NumericUpDown();
            this.txtMovingInnerR = new System.Windows.Forms.NumericUpDown();
            this.txtMovingOuterR = new System.Windows.Forms.NumericUpDown();
            this.txtLoopsCount = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixedOuterR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixedInnerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovingInnerR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovingOuterR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoopsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.picPreview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 609);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(3, 3);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(501, 603);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtLoopsCount);
            this.panel1.Controls.Add(this.txtMovingInnerR);
            this.panel1.Controls.Add(this.txtMovingOuterR);
            this.panel1.Controls.Add(this.txtFixedInnerR);
            this.panel1.Controls.Add(this.txtFixedOuterR);
            this.panel1.Controls.Add(this.lblLoopCount);
            this.panel1.Controls.Add(this.lblLoops1);
            this.panel1.Controls.Add(this.txtLoopsToClose);
            this.panel1.Controls.Add(this.lblCurveWillClose);
            this.panel1.Controls.Add(this.txtStartAngle);
            this.panel1.Controls.Add(this.lblStartAngle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRemoveQuill);
            this.panel1.Controls.Add(this.btnAddQuill);
            this.panel1.Controls.Add(this.lstQuills);
            this.panel1.Controls.Add(this.lblQuills);
            this.panel1.Controls.Add(this.cboMovingTouch);
            this.panel1.Controls.Add(this.lblMovingTouch);
            this.panel1.Controls.Add(this.lblMovingInnerR);
            this.panel1.Controls.Add(this.lblMovingOuterR);
            this.panel1.Controls.Add(this.lblMovingElement);
            this.panel1.Controls.Add(this.cboFixedTouch);
            this.panel1.Controls.Add(this.lblFixedTouch);
            this.panel1.Controls.Add(this.lblFixedInnerR);
            this.panel1.Controls.Add(this.lblFixedOuterR);
            this.panel1.Controls.Add(this.lblFixedElement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(510, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 603);
            this.panel1.TabIndex = 1;
            // 
            // lblFixedElement
            // 
            this.lblFixedElement.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFixedElement.ForeColor = System.Drawing.Color.Blue;
            this.lblFixedElement.Location = new System.Drawing.Point(3, 6);
            this.lblFixedElement.Name = "lblFixedElement";
            this.lblFixedElement.Size = new System.Drawing.Size(288, 23);
            this.lblFixedElement.TabIndex = 0;
            this.lblFixedElement.Text = "Неподвижный элемент";
            this.lblFixedElement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFixedOuterR
            // 
            this.lblFixedOuterR.ForeColor = System.Drawing.Color.Blue;
            this.lblFixedOuterR.Location = new System.Drawing.Point(3, 29);
            this.lblFixedOuterR.Name = "lblFixedOuterR";
            this.lblFixedOuterR.Size = new System.Drawing.Size(159, 23);
            this.lblFixedOuterR.TabIndex = 1;
            this.lblFixedOuterR.Text = "Внешний радиус";
            this.lblFixedOuterR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFixedInnerR
            // 
            this.lblFixedInnerR.ForeColor = System.Drawing.Color.Blue;
            this.lblFixedInnerR.Location = new System.Drawing.Point(3, 52);
            this.lblFixedInnerR.Name = "lblFixedInnerR";
            this.lblFixedInnerR.Size = new System.Drawing.Size(159, 23);
            this.lblFixedInnerR.TabIndex = 3;
            this.lblFixedInnerR.Text = "Внутренний радиус";
            this.lblFixedInnerR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFixedTouch
            // 
            this.lblFixedTouch.ForeColor = System.Drawing.Color.Blue;
            this.lblFixedTouch.Location = new System.Drawing.Point(3, 75);
            this.lblFixedTouch.Name = "lblFixedTouch";
            this.lblFixedTouch.Size = new System.Drawing.Size(121, 23);
            this.lblFixedTouch.TabIndex = 5;
            this.lblFixedTouch.Text = "Касание краем";
            this.lblFixedTouch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFixedTouch
            // 
            this.cboFixedTouch.ForeColor = System.Drawing.Color.Blue;
            this.cboFixedTouch.FormattingEnabled = true;
            this.cboFixedTouch.Location = new System.Drawing.Point(130, 77);
            this.cboFixedTouch.Name = "cboFixedTouch";
            this.cboFixedTouch.Size = new System.Drawing.Size(155, 21);
            this.cboFixedTouch.TabIndex = 6;
            // 
            // lblMovingElement
            // 
            this.lblMovingElement.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMovingElement.ForeColor = System.Drawing.Color.Red;
            this.lblMovingElement.Location = new System.Drawing.Point(3, 118);
            this.lblMovingElement.Name = "lblMovingElement";
            this.lblMovingElement.Size = new System.Drawing.Size(288, 23);
            this.lblMovingElement.TabIndex = 7;
            this.lblMovingElement.Text = "Подвижный элемент";
            this.lblMovingElement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMovingTouch
            // 
            this.cboMovingTouch.ForeColor = System.Drawing.Color.Red;
            this.cboMovingTouch.FormattingEnabled = true;
            this.cboMovingTouch.Location = new System.Drawing.Point(130, 189);
            this.cboMovingTouch.Name = "cboMovingTouch";
            this.cboMovingTouch.Size = new System.Drawing.Size(155, 21);
            this.cboMovingTouch.TabIndex = 13;
            // 
            // lblMovingTouch
            // 
            this.lblMovingTouch.ForeColor = System.Drawing.Color.Red;
            this.lblMovingTouch.Location = new System.Drawing.Point(3, 187);
            this.lblMovingTouch.Name = "lblMovingTouch";
            this.lblMovingTouch.Size = new System.Drawing.Size(121, 23);
            this.lblMovingTouch.TabIndex = 12;
            this.lblMovingTouch.Text = "Касание краем";
            this.lblMovingTouch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovingInnerR
            // 
            this.lblMovingInnerR.ForeColor = System.Drawing.Color.Red;
            this.lblMovingInnerR.Location = new System.Drawing.Point(3, 164);
            this.lblMovingInnerR.Name = "lblMovingInnerR";
            this.lblMovingInnerR.Size = new System.Drawing.Size(159, 23);
            this.lblMovingInnerR.TabIndex = 10;
            this.lblMovingInnerR.Text = "Внутренний радиус";
            this.lblMovingInnerR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovingOuterR
            // 
            this.lblMovingOuterR.ForeColor = System.Drawing.Color.Red;
            this.lblMovingOuterR.Location = new System.Drawing.Point(3, 141);
            this.lblMovingOuterR.Name = "lblMovingOuterR";
            this.lblMovingOuterR.Size = new System.Drawing.Size(159, 23);
            this.lblMovingOuterR.TabIndex = 8;
            this.lblMovingOuterR.Text = "Внешний радиус";
            this.lblMovingOuterR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuills
            // 
            this.lblQuills.ForeColor = System.Drawing.Color.Red;
            this.lblQuills.Location = new System.Drawing.Point(3, 220);
            this.lblQuills.Name = "lblQuills";
            this.lblQuills.Size = new System.Drawing.Size(121, 23);
            this.lblQuills.TabIndex = 14;
            this.lblQuills.Text = "Список перьев";
            this.lblQuills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstQuills
            // 
            this.lstQuills.FormattingEnabled = true;
            this.lstQuills.Location = new System.Drawing.Point(6, 242);
            this.lstQuills.Name = "lstQuills";
            this.lstQuills.Size = new System.Drawing.Size(238, 134);
            this.lstQuills.TabIndex = 15;
            // 
            // btnAddQuill
            // 
            this.btnAddQuill.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddQuill.ForeColor = System.Drawing.Color.Green;
            this.btnAddQuill.Location = new System.Drawing.Point(250, 242);
            this.btnAddQuill.Name = "btnAddQuill";
            this.btnAddQuill.Size = new System.Drawing.Size(24, 23);
            this.btnAddQuill.TabIndex = 16;
            this.btnAddQuill.Text = "+";
            this.btnAddQuill.UseVisualStyleBackColor = true;
            // 
            // btnRemoveQuill
            // 
            this.btnRemoveQuill.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveQuill.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveQuill.Location = new System.Drawing.Point(250, 271);
            this.btnRemoveQuill.Name = "btnRemoveQuill";
            this.btnRemoveQuill.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveQuill.TabIndex = 17;
            this.btnRemoveQuill.Text = "–";
            this.btnRemoveQuill.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(210, 571);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.ForeColor = System.Drawing.Color.Red;
            this.txtStartAngle.Location = new System.Drawing.Point(168, 391);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(117, 20);
            this.txtStartAngle.TabIndex = 20;
            this.txtStartAngle.Text = "0";
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.ForeColor = System.Drawing.Color.Red;
            this.lblStartAngle.Location = new System.Drawing.Point(3, 389);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(159, 23);
            this.lblStartAngle.TabIndex = 19;
            this.lblStartAngle.Text = "Начальный угол";
            this.lblStartAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoopsToClose
            // 
            this.txtLoopsToClose.ForeColor = System.Drawing.Color.Red;
            this.txtLoopsToClose.Location = new System.Drawing.Point(152, 414);
            this.txtLoopsToClose.Name = "txtLoopsToClose";
            this.txtLoopsToClose.ReadOnly = true;
            this.txtLoopsToClose.Size = new System.Drawing.Size(69, 20);
            this.txtLoopsToClose.TabIndex = 22;
            // 
            // lblCurveWillClose
            // 
            this.lblCurveWillClose.ForeColor = System.Drawing.Color.Red;
            this.lblCurveWillClose.Location = new System.Drawing.Point(3, 412);
            this.lblCurveWillClose.Name = "lblCurveWillClose";
            this.lblCurveWillClose.Size = new System.Drawing.Size(143, 23);
            this.lblCurveWillClose.TabIndex = 21;
            this.lblCurveWillClose.Text = "Кривая замкнётся через";
            this.lblCurveWillClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoops1
            // 
            this.lblLoops1.ForeColor = System.Drawing.Color.Red;
            this.lblLoops1.Location = new System.Drawing.Point(237, 412);
            this.lblLoops1.Name = "lblLoops1";
            this.lblLoops1.Size = new System.Drawing.Size(48, 23);
            this.lblLoops1.TabIndex = 23;
            this.lblLoops1.Text = "кругов";
            this.lblLoops1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoopCount
            // 
            this.lblLoopCount.ForeColor = System.Drawing.Color.Red;
            this.lblLoopCount.Location = new System.Drawing.Point(3, 435);
            this.lblLoopCount.Name = "lblLoopCount";
            this.lblLoopCount.Size = new System.Drawing.Size(143, 23);
            this.lblLoopCount.TabIndex = 24;
            this.lblLoopCount.Text = "Количество кругов";
            this.lblLoopCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFixedOuterR
            // 
            this.txtFixedOuterR.Location = new System.Drawing.Point(168, 31);
            this.txtFixedOuterR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtFixedOuterR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFixedOuterR.Name = "txtFixedOuterR";
            this.txtFixedOuterR.Size = new System.Drawing.Size(116, 20);
            this.txtFixedOuterR.TabIndex = 26;
            this.txtFixedOuterR.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtFixedInnerR
            // 
            this.txtFixedInnerR.Location = new System.Drawing.Point(168, 54);
            this.txtFixedInnerR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtFixedInnerR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFixedInnerR.Name = "txtFixedInnerR";
            this.txtFixedInnerR.Size = new System.Drawing.Size(116, 20);
            this.txtFixedInnerR.TabIndex = 27;
            this.txtFixedInnerR.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // txtMovingInnerR
            // 
            this.txtMovingInnerR.Location = new System.Drawing.Point(168, 164);
            this.txtMovingInnerR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtMovingInnerR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMovingInnerR.Name = "txtMovingInnerR";
            this.txtMovingInnerR.Size = new System.Drawing.Size(116, 20);
            this.txtMovingInnerR.TabIndex = 29;
            this.txtMovingInnerR.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtMovingOuterR
            // 
            this.txtMovingOuterR.Location = new System.Drawing.Point(168, 141);
            this.txtMovingOuterR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtMovingOuterR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMovingOuterR.Name = "txtMovingOuterR";
            this.txtMovingOuterR.Size = new System.Drawing.Size(116, 20);
            this.txtMovingOuterR.TabIndex = 28;
            this.txtMovingOuterR.Value = new decimal(new int[] {
            63,
            0,
            0,
            0});
            // 
            // txtLoopsCount
            // 
            this.txtLoopsCount.Location = new System.Drawing.Point(168, 438);
            this.txtLoopsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLoopsCount.Name = "txtLoopsCount";
            this.txtLoopsCount.Size = new System.Drawing.Size(116, 20);
            this.txtLoopsCount.TabIndex = 30;
            this.txtLoopsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 480);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // formPrepare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 609);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formPrepare";
            this.ShowInTaskbar = false;
            this.Text = "formPrepare";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixedOuterR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFixedInnerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovingInnerR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovingOuterR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoopsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFixedElement;
        private System.Windows.Forms.Label lblFixedOuterR;
        private System.Windows.Forms.Label lblFixedInnerR;
        private System.Windows.Forms.Label lblFixedTouch;
        private System.Windows.Forms.ComboBox cboFixedTouch;
        private System.Windows.Forms.Label lblMovingElement;
        private System.Windows.Forms.ComboBox cboMovingTouch;
        private System.Windows.Forms.Label lblMovingTouch;
        private System.Windows.Forms.Label lblMovingInnerR;
        private System.Windows.Forms.Label lblMovingOuterR;
        private System.Windows.Forms.Label lblQuills;
        private System.Windows.Forms.ListBox lstQuills;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemoveQuill;
        private System.Windows.Forms.Button btnAddQuill;
        private System.Windows.Forms.TextBox txtStartAngle;
        private System.Windows.Forms.Label lblStartAngle;
        private System.Windows.Forms.Label lblLoopCount;
        private System.Windows.Forms.Label lblLoops1;
        private System.Windows.Forms.TextBox txtLoopsToClose;
        private System.Windows.Forms.Label lblCurveWillClose;
        private System.Windows.Forms.NumericUpDown txtFixedInnerR;
        private System.Windows.Forms.NumericUpDown txtFixedOuterR;
        private System.Windows.Forms.NumericUpDown txtMovingInnerR;
        private System.Windows.Forms.NumericUpDown txtMovingOuterR;
        private System.Windows.Forms.NumericUpDown txtLoopsCount;
        private System.Windows.Forms.Button btnRefresh;
    }
}