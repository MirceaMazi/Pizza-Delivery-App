namespace PizzaDelivery.Forms
{
    partial class FormComanda
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
            this.labelTip = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.tipCb = new System.Windows.Forms.ComboBox();
            this.counterCantitate = new System.Windows.Forms.NumericUpDown();
            this.lvPizza = new System.Windows.Forms.ListView();
            this.butonAdaugare = new System.Windows.Forms.Button();
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.counterCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.ForeColor = System.Drawing.Color.Gold;
            this.labelTip.Location = new System.Drawing.Point(12, 9);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(122, 29);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "Tip pizza:";
            this.labelTip.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantitate.ForeColor = System.Drawing.Color.Gold;
            this.labelCantitate.Location = new System.Drawing.Point(13, 65);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(121, 29);
            this.labelCantitate.TabIndex = 3;
            this.labelCantitate.Text = "Cantitate:";
            this.labelCantitate.Click += new System.EventHandler(this.label4_Click);
            // 
            // tipCb
            // 
            this.tipCb.BackColor = System.Drawing.SystemColors.Window;
            this.tipCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipCb.ForeColor = System.Drawing.Color.Transparent;
            this.tipCb.FormattingEnabled = true;
            this.tipCb.Location = new System.Drawing.Point(151, 13);
            this.tipCb.Name = "tipCb";
            this.tipCb.Size = new System.Drawing.Size(121, 24);
            this.tipCb.TabIndex = 5;
            this.tipCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // counterCantitate
            // 
            this.counterCantitate.Location = new System.Drawing.Point(151, 72);
            this.counterCantitate.Name = "counterCantitate";
            this.counterCantitate.Size = new System.Drawing.Size(121, 22);
            this.counterCantitate.TabIndex = 6;
            this.counterCantitate.ValueChanged += new System.EventHandler(this.counterCantitate_ValueChanged);
            this.counterCantitate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.counterCantitate_KeyDown);
            // 
            // lvPizza
            // 
            this.lvPizza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Comanda,
            this.Tip,
            this.Cantitate});
            this.lvPizza.HideSelection = false;
            this.lvPizza.Location = new System.Drawing.Point(12, 129);
            this.lvPizza.Name = "lvPizza";
            this.lvPizza.Size = new System.Drawing.Size(604, 287);
            this.lvPizza.TabIndex = 7;
            this.lvPizza.UseCompatibleStateImageBehavior = false;
            this.lvPizza.View = System.Windows.Forms.View.Details;
            // 
            // butonAdaugare
            // 
            this.butonAdaugare.BackColor = System.Drawing.Color.DarkRed;
            this.butonAdaugare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butonAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAdaugare.ForeColor = System.Drawing.Color.Gold;
            this.butonAdaugare.Location = new System.Drawing.Point(305, 13);
            this.butonAdaugare.Name = "butonAdaugare";
            this.butonAdaugare.Size = new System.Drawing.Size(172, 82);
            this.butonAdaugare.TabIndex = 8;
            this.butonAdaugare.Text = "Adauga comanda";
            this.butonAdaugare.UseVisualStyleBackColor = false;
            this.butonAdaugare.Click += new System.EventHandler(this.butonAdaugare_Click);
            // 
            // Tip
            // 
            this.Tip.Text = "Tip Pizza";
            this.Tip.Width = 196;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.Width = 209;
            // 
            // Comanda
            // 
            this.Comanda.DisplayIndex = 2;
            this.Comanda.Text = "NrComanda";
            this.Comanda.Width = 193;
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(634, 428);
            this.Controls.Add(this.butonAdaugare);
            this.Controls.Add(this.lvPizza);
            this.Controls.Add(this.counterCantitate);
            this.Controls.Add(this.tipCb);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComanda";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.counterCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.ComboBox tipCb;
        private System.Windows.Forms.NumericUpDown counterCantitate;
        private System.Windows.Forms.ListView lvPizza;
        private System.Windows.Forms.Button butonAdaugare;
        private System.Windows.Forms.ColumnHeader Comanda;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader Cantitate;
    }
}