namespace Spirograph
{
    partial class formMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblDelay = new System.Windows.Forms.Label();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.lblCanvasSize = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnSaveParams = new System.Windows.Forms.ToolStripButton();
            this.picBackColor = new System.Windows.Forms.PictureBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnOpenParams = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveParams,
            this.btnOpenParams});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnPrepare
            // 
            this.btnPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrepare.Location = new System.Drawing.Point(625, 28);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(90, 23);
            this.btnPrepare.TabIndex = 3;
            this.btnPrepare.Text = "Приготовить";
            this.btnPrepare.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(625, 549);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblBackColor
            // 
            this.lblBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(583, 65);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(61, 13);
            this.lblBackColor.TabIndex = 5;
            this.lblBackColor.Text = "Цвет фона";
            // 
            // lblDelay
            // 
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(583, 233);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(78, 13);
            this.lblDelay.TabIndex = 7;
            this.lblDelay.Text = "Задержка, мс";
            // 
            // nudDelay
            // 
            this.nudDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDelay.Location = new System.Drawing.Point(668, 231);
            this.nudDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(47, 20);
            this.nudDelay.TabIndex = 8;
            this.nudDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblCanvasSize
            // 
            this.lblCanvasSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanvasSize.AutoSize = true;
            this.lblCanvasSize.Location = new System.Drawing.Point(583, 108);
            this.lblCanvasSize.Name = "lblCanvasSize";
            this.lblCanvasSize.Size = new System.Drawing.Size(83, 13);
            this.lblCanvasSize.TabIndex = 9;
            this.lblCanvasSize.Text = "Размер холста";
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(583, 130);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 13);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Ширина";
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWidth.Location = new System.Drawing.Point(647, 127);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(68, 20);
            this.txtWidth.TabIndex = 11;
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeight.Location = new System.Drawing.Point(647, 153);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 20);
            this.txtHeight.TabIndex = 13;
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(583, 156);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(45, 13);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Высота";
            // 
            // btnSaveParams
            // 
            this.btnSaveParams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveParams.Image = global::Spirograph.Properties.Resources.saveHS;
            this.btnSaveParams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveParams.Name = "btnSaveParams";
            this.btnSaveParams.Size = new System.Drawing.Size(23, 22);
            this.btnSaveParams.Text = "toolStripButton1";
            // 
            // picBackColor
            // 
            this.picBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackColor.Location = new System.Drawing.Point(668, 61);
            this.picBackColor.Name = "picBackColor";
            this.picBackColor.Size = new System.Drawing.Size(47, 25);
            this.picBackColor.TabIndex = 6;
            this.picBackColor.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(0, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(577, 544);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            // 
            // btnOpenParams
            // 
            this.btnOpenParams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenParams.Image = global::Spirograph.Properties.Resources.OpenSelectedItemHS;
            this.btnOpenParams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenParams.Name = "btnOpenParams";
            this.btnOpenParams.Size = new System.Drawing.Size(23, 22);
            this.btnOpenParams.Text = "toolStripButton2";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 597);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblCanvasSize);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.picBackColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPrepare);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "formMain";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.PictureBox picBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Label lblCanvasSize;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.ToolStripButton btnSaveParams;
        private System.Windows.Forms.ToolStripButton btnOpenParams;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

