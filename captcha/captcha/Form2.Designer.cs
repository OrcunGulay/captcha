namespace captcha
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.Giriş = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(212, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(306, 25);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(284, 32);
            this.textEdit1.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(306, 106);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(284, 32);
            this.textEdit2.TabIndex = 2;
            // 
            // Giriş
            // 
            this.Giriş.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giriş.Location = new System.Drawing.Point(331, 186);
            this.Giriş.Name = "Giriş";
            this.Giriş.Size = new System.Drawing.Size(143, 46);
            this.Giriş.TabIndex = 3;
            this.Giriş.Text = "Giriş";
            this.Giriş.UseVisualStyleBackColor = true;
            this.Giriş.Click += new System.EventHandler(this.Giriş_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.Giriş);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Button Giriş;
    }
}