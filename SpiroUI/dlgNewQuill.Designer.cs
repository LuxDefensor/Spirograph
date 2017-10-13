namespace Spirograph
{
    partial class dlgNewQuill
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
            this.lblAngularPosition = new System.Windows.Forms.Label();
            this.lblRadialPosition = new System.Windows.Forms.Label();
            this.txtRadialPosition = new System.Windows.Forms.NumericUpDown();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picPenColor = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAngularPosition = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadialPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngularPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAngularPosition
            // 
            this.lblAngularPosition.Location = new System.Drawing.Point(12, 20);
            this.lblAngularPosition.Name = "lblAngularPosition";
            this.lblAngularPosition.Size = new System.Drawing.Size(200, 23);
            this.lblAngularPosition.TabIndex = 0;
            this.lblAngularPosition.Text = "Угловое отклонение";
            // 
            // lblRadialPosition
            // 
            this.lblRadialPosition.Location = new System.Drawing.Point(12, 43);
            this.lblRadialPosition.Name = "lblRadialPosition";
            this.lblRadialPosition.Size = new System.Drawing.Size(200, 23);
            this.lblRadialPosition.TabIndex = 2;
            this.lblRadialPosition.Text = "Смещение по радиусу";
            // 
            // txtRadialPosition
            // 
            this.txtRadialPosition.Location = new System.Drawing.Point(255, 41);
            this.txtRadialPosition.Name = "txtRadialPosition";
            this.txtRadialPosition.Size = new System.Drawing.Size(100, 20);
            this.txtRadialPosition.TabIndex = 3;
            this.txtRadialPosition.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblPenColor
            // 
            this.lblPenColor.Location = new System.Drawing.Point(12, 66);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(200, 23);
            this.lblPenColor.TabIndex = 4;
            this.lblPenColor.Text = "Цвет пера";
            // 
            // picPenColor
            // 
            this.picPenColor.BackColor = System.Drawing.Color.Red;
            this.picPenColor.Location = new System.Drawing.Point(255, 67);
            this.picPenColor.Name = "picPenColor";
            this.picPenColor.Size = new System.Drawing.Size(100, 22);
            this.picPenColor.TabIndex = 5;
            this.picPenColor.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(199, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtAngularPosition
            // 
            this.txtAngularPosition.Location = new System.Drawing.Point(255, 18);
            this.txtAngularPosition.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.txtAngularPosition.Name = "txtAngularPosition";
            this.txtAngularPosition.Size = new System.Drawing.Size(100, 20);
            this.txtAngularPosition.TabIndex = 8;
            // 
            // dlgNewQuill
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(371, 156);
            this.ControlBox = false;
            this.Controls.Add(this.txtAngularPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.picPenColor);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.txtRadialPosition);
            this.Controls.Add(this.lblRadialPosition);
            this.Controls.Add(this.lblAngularPosition);
            this.Name = "dlgNewQuill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dlgNewQuill";
            ((System.ComponentModel.ISupportInitialize)(this.txtRadialPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngularPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAngularPosition;
        private System.Windows.Forms.Label lblRadialPosition;
        private System.Windows.Forms.NumericUpDown txtRadialPosition;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picPenColor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown txtAngularPosition;
    }
}