namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Field = new System.Windows.Forms.Panel();
            this.pictureBox_StickToCatch = new System.Windows.Forms.PictureBox();
            this.pictureBox_ElementForCatch = new System.Windows.Forms.PictureBox();
            this.Field.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StickToCatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ElementForCatch)).BeginInit();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Controls.Add(this.pictureBox_ElementForCatch);
            this.Field.Controls.Add(this.pictureBox_StickToCatch);
            this.Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field.Location = new System.Drawing.Point(0, 0);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(800, 450);
            this.Field.TabIndex = 0;
            // 
            // pictureBox_StickToCatch
            // 
            this.pictureBox_StickToCatch.BackColor = System.Drawing.Color.Red;
            this.pictureBox_StickToCatch.Location = new System.Drawing.Point(226, 402);
            this.pictureBox_StickToCatch.Name = "pictureBox_StickToCatch";
            this.pictureBox_StickToCatch.Size = new System.Drawing.Size(329, 21);
            this.pictureBox_StickToCatch.TabIndex = 0;
            this.pictureBox_StickToCatch.TabStop = false;
            // 
            // pictureBox_ElementForCatch
            // 
            this.pictureBox_ElementForCatch.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_ElementForCatch.Location = new System.Drawing.Point(121, 97);
            this.pictureBox_ElementForCatch.Name = "pictureBox_ElementForCatch";
            this.pictureBox_ElementForCatch.Size = new System.Drawing.Size(70, 63);
            this.pictureBox_ElementForCatch.TabIndex = 1;
            this.pictureBox_ElementForCatch.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Field.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StickToCatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ElementForCatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.PictureBox pictureBox_StickToCatch;
        private System.Windows.Forms.PictureBox pictureBox_ElementForCatch;
    }
}

