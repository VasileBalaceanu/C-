namespace HangmanInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.butontrimite = new System.Windows.Forms.Button();
            this.literatrimisa = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.rezultat1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.meniuToolStripMenuItem.Text = "&Meniu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangman";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(151, 145);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(106, 124);
            this.pb.TabIndex = 3;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // butontrimite
            // 
            this.butontrimite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butontrimite.Location = new System.Drawing.Point(441, 286);
            this.butontrimite.Name = "butontrimite";
            this.butontrimite.Size = new System.Drawing.Size(75, 23);
            this.butontrimite.TabIndex = 1;
            this.butontrimite.TabStop = false;
            this.butontrimite.Text = "Send";
            this.butontrimite.UseVisualStyleBackColor = true;
            this.butontrimite.Click += new System.EventHandler(this.Send_Click);
            // 
            // literatrimisa
            // 
            this.literatrimisa.Location = new System.Drawing.Point(455, 235);
            this.literatrimisa.MaxLength = 1;
            this.literatrimisa.Name = "literatrimisa";
            this.literatrimisa.Size = new System.Drawing.Size(44, 20);
            this.literatrimisa.TabIndex = 1;
            this.literatrimisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.literatrimisa.TextChanged += new System.EventHandler(this.literatrimisa_TextChanged);
            // 
            // rezultat
            // 
            this.rezultat.BackColor = System.Drawing.Color.White;
            this.rezultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezultat.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat.Location = new System.Drawing.Point(330, 145);
            this.rezultat.Multiline = true;
            this.rezultat.Name = "rezultat";
            this.rezultat.ReadOnly = true;
            this.rezultat.Size = new System.Drawing.Size(297, 44);
            this.rezultat.TabIndex = 7;
            this.rezultat.TabStop = false;
            this.rezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rezultat1
            // 
            this.rezultat1.Enabled = false;
            this.rezultat1.Location = new System.Drawing.Point(416, 92);
            this.rezultat1.Name = "rezultat1";
            this.rezultat1.Size = new System.Drawing.Size(100, 20);
            this.rezultat1.TabIndex = 8;
            this.rezultat1.TabStop = false;
            this.rezultat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rezultat1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(639, 355);
            this.Controls.Add(this.rezultat1);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.literatrimisa);
            this.Controls.Add(this.butontrimite);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hangman                                                   ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button butontrimite;
        private System.Windows.Forms.TextBox literatrimisa;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.TextBox rezultat1;
    }
}

