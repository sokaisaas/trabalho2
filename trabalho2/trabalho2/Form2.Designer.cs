namespace trabalho2
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
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btngrafico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpdf
            // 
            this.btnpdf.BackColor = System.Drawing.Color.HotPink;
            this.btnpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.ForeColor = System.Drawing.Color.Cyan;
            this.btnpdf.Location = new System.Drawing.Point(291, 234);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(172, 72);
            this.btnpdf.TabIndex = 0;
            this.btnpdf.Text = "Gerar PDF";
            this.btnpdf.UseVisualStyleBackColor = false;
            this.btnpdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.HotPink;
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.Cyan;
            this.btnexcel.Location = new System.Drawing.Point(580, 234);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(172, 72);
            this.btnexcel.TabIndex = 0;
            this.btnexcel.Text = "Gerar Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btngrafico
            // 
            this.btngrafico.BackColor = System.Drawing.Color.HotPink;
            this.btngrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrafico.ForeColor = System.Drawing.Color.Cyan;
            this.btngrafico.Location = new System.Drawing.Point(862, 234);
            this.btngrafico.Name = "btngrafico";
            this.btngrafico.Size = new System.Drawing.Size(172, 72);
            this.btngrafico.TabIndex = 0;
            this.btngrafico.Text = "Gerar Gráfico";
            this.btngrafico.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1363, 598);
            this.Controls.Add(this.btngrafico);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnpdf);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btngrafico;
    }
}