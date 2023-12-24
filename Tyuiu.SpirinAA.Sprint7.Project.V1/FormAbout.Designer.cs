namespace Tyuiu.SpirinAA.Sprint7.Project.V1
{
    partial class FormAbout
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_SAA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_SAA = new System.Windows.Forms.Label();
            this.textBoxInfo_SAA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SAA
            // 
            this.buttonOK_SAA.Location = new System.Drawing.Point(345, 130);
            this.buttonOK_SAA.Name = "buttonOK_SAA";
            this.buttonOK_SAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SAA.TabIndex = 1;
            this.buttonOK_SAA.Text = "Ок";
            this.buttonOK_SAA.UseVisualStyleBackColor = true;
            this.buttonOK_SAA.Click += new System.EventHandler(this.buttonOK_SAA_Click);
            // 
            // pictureBoxAvatar_SAA
            // 
            this.pictureBoxAvatar_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SAA.Image")));
            this.pictureBoxAvatar_SAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SAA.Name = "pictureBoxAvatar_SAA";
            this.pictureBoxAvatar_SAA.Size = new System.Drawing.Size(162, 141);
            this.pictureBoxAvatar_SAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_SAA.TabIndex = 2;
            this.pictureBoxAvatar_SAA.TabStop = false;
            // 
            // labelInfo_SAA
            // 
            this.labelInfo_SAA.AutoSize = true;
            this.labelInfo_SAA.Location = new System.Drawing.Point(136, 9);
            this.labelInfo_SAA.Name = "labelInfo_SAA";
            this.labelInfo_SAA.Size = new System.Drawing.Size(0, 13);
            this.labelInfo_SAA.TabIndex = 3;
            // 
            // textBoxInfo_SAA
            // 
            this.textBoxInfo_SAA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_SAA.Location = new System.Drawing.Point(180, 12);
            this.textBoxInfo_SAA.Multiline = true;
            this.textBoxInfo_SAA.Name = "textBoxInfo_SAA";
            this.textBoxInfo_SAA.Size = new System.Drawing.Size(240, 112);
            this.textBoxInfo_SAA.TabIndex = 4;
            this.textBoxInfo_SAA.Text = "Разработчик: Спирин Александр Алексеевич\r\nСпринт 7\r\nТема: Авторемонтные Мастерски" +
    "е\r\nВариант 1\r\n\r\n";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 165);
            this.Controls.Add(this.textBoxInfo_SAA);
            this.Controls.Add(this.labelInfo_SAA);
            this.Controls.Add(this.pictureBoxAvatar_SAA);
            this.Controls.Add(this.buttonOK_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonOK_SAA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAA;
        private System.Windows.Forms.Label labelInfo_SAA;
        private System.Windows.Forms.TextBox textBoxInfo_SAA;
    }
}