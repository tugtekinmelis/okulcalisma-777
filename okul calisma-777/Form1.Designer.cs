namespace okul_calisma_777
{
    partial class Form1
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
            this.btnOgrenciEkleForm = new System.Windows.Forms.Button();
            this.btnOgrenciListeleForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciEkleForm
            // 
            this.btnOgrenciEkleForm.Location = new System.Drawing.Point(76, 207);
            this.btnOgrenciEkleForm.Name = "btnOgrenciEkleForm";
            this.btnOgrenciEkleForm.Size = new System.Drawing.Size(126, 50);
            this.btnOgrenciEkleForm.TabIndex = 9;
            this.btnOgrenciEkleForm.Text = "Öğrenci Ekle ";
            this.btnOgrenciEkleForm.UseVisualStyleBackColor = true;
            this.btnOgrenciEkleForm.Click += new System.EventHandler(this.btnOgrenciEkleForm_Click);
            // 
            // btnOgrenciListeleForm
            // 
            this.btnOgrenciListeleForm.Location = new System.Drawing.Point(261, 207);
            this.btnOgrenciListeleForm.Name = "btnOgrenciListeleForm";
            this.btnOgrenciListeleForm.Size = new System.Drawing.Size(126, 50);
            this.btnOgrenciListeleForm.TabIndex = 10;
            this.btnOgrenciListeleForm.Text = "Tüm Öğrenciler ";
            this.btnOgrenciListeleForm.UseVisualStyleBackColor = true;
            this.btnOgrenciListeleForm.Click += new System.EventHandler(this.btnOgrenciListeleForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOgrenciListeleForm);
            this.Controls.Add(this.btnOgrenciEkleForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkleForm;
        private System.Windows.Forms.Button btnOgrenciListeleForm;
    }
}

