namespace PizzaDelivery
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.butonComanda = new System.Windows.Forms.Button();
            this.butonFormular = new System.Windows.Forms.Button();
            this.butonGrafic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butonComanda
            // 
            this.butonComanda.BackColor = System.Drawing.Color.DarkRed;
            this.butonComanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonComanda.ForeColor = System.Drawing.Color.Gold;
            this.butonComanda.Location = new System.Drawing.Point(547, 336);
            this.butonComanda.Name = "butonComanda";
            this.butonComanda.Size = new System.Drawing.Size(415, 184);
            this.butonComanda.TabIndex = 0;
            this.butonComanda.Text = "Plaseaza comanda";
            this.butonComanda.UseVisualStyleBackColor = false;
            this.butonComanda.Click += new System.EventHandler(this.button1_Click);
            // 
            // butonFormular
            // 
            this.butonFormular.BackColor = System.Drawing.Color.DarkRed;
            this.butonFormular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonFormular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonFormular.ForeColor = System.Drawing.Color.Gold;
            this.butonFormular.Location = new System.Drawing.Point(547, 156);
            this.butonFormular.Name = "butonFormular";
            this.butonFormular.Size = new System.Drawing.Size(415, 191);
            this.butonFormular.TabIndex = 1;
            this.butonFormular.Text = "Formular feedback";
            this.butonFormular.UseVisualStyleBackColor = false;
            // 
            // butonGrafic
            // 
            this.butonGrafic.BackColor = System.Drawing.Color.DarkRed;
            this.butonGrafic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonGrafic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonGrafic.ForeColor = System.Drawing.Color.Gold;
            this.butonGrafic.Location = new System.Drawing.Point(547, -12);
            this.butonGrafic.Name = "butonGrafic";
            this.butonGrafic.Size = new System.Drawing.Size(415, 177);
            this.butonGrafic.TabIndex = 2;
            this.butonGrafic.Text = "Grafic vanzari";
            this.butonGrafic.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(951, 506);
            this.Controls.Add(this.butonGrafic);
            this.Controls.Add(this.butonFormular);
            this.Controls.Add(this.butonComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonComanda;
        private System.Windows.Forms.Button butonFormular;
        private System.Windows.Forms.Button butonGrafic;
    }
}

