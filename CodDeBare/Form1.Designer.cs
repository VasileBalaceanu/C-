namespace CodDeBare
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
            this.ButonGenereaza = new System.Windows.Forms.Button();
            this.ButonSalveaza = new System.Windows.Forms.Button();
            this.valintrodusa = new System.Windows.Forms.TextBox();
            this.valoare = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.coddeafisat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aparechenar = new System.Windows.Forms.CheckBox();
            this.butonopenfile = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonGenereaza
            // 
            this.ButonGenereaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButonGenereaza.Location = new System.Drawing.Point(77, 284);
            this.ButonGenereaza.Name = "ButonGenereaza";
            this.ButonGenereaza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButonGenereaza.Size = new System.Drawing.Size(120, 45);
            this.ButonGenereaza.TabIndex = 2;
            this.ButonGenereaza.Text = "Genereaza";
            this.ButonGenereaza.UseVisualStyleBackColor = true;
            this.ButonGenereaza.Click += new System.EventHandler(this.ButonGenereaza_Click);
            // 
            // ButonSalveaza
            // 
            this.ButonSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButonSalveaza.Location = new System.Drawing.Point(294, 284);
            this.ButonSalveaza.Name = "ButonSalveaza";
            this.ButonSalveaza.Size = new System.Drawing.Size(120, 45);
            this.ButonSalveaza.TabIndex = 3;
            this.ButonSalveaza.Text = "Salveaza";
            this.ButonSalveaza.UseVisualStyleBackColor = true;
            this.ButonSalveaza.Click += new System.EventHandler(this.ButonSalveaza_Click);
            // 
            // valintrodusa
            // 
            this.valintrodusa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valintrodusa.Location = new System.Drawing.Point(125, 217);
            this.valintrodusa.MaxLength = 50;
            this.valintrodusa.Multiline = true;
            this.valintrodusa.Name = "valintrodusa";
            this.valintrodusa.Size = new System.Drawing.Size(150, 22);
            this.valintrodusa.TabIndex = 1;
            this.valintrodusa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valintrodusa.TextChanged += new System.EventHandler(this.valintrodusa_TextChanged);
            this.valintrodusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valintrodusa_KeyPress);
            // 
            // valoare
            // 
            this.valoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valoare.Location = new System.Drawing.Point(26, 209);
            this.valoare.Name = "valoare";
            this.valoare.Size = new System.Drawing.Size(99, 34);
            this.valoare.TabIndex = 3;
            this.valoare.Text = "Valoare";
            this.valoare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb.Location = new System.Drawing.Point(41, 34);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(400, 100);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 4;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // coddeafisat
            // 
            this.coddeafisat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coddeafisat.Location = new System.Drawing.Point(322, 218);
            this.coddeafisat.Multiline = true;
            this.coddeafisat.Name = "coddeafisat";
            this.coddeafisat.Size = new System.Drawing.Size(150, 22);
            this.coddeafisat.TabIndex = 5;
            this.coddeafisat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(281, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "-->";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aparechenar
            // 
            this.aparechenar.AutoSize = true;
            this.aparechenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aparechenar.Location = new System.Drawing.Point(77, 153);
            this.aparechenar.Name = "aparechenar";
            this.aparechenar.Size = new System.Drawing.Size(92, 20);
            this.aparechenar.TabIndex = 7;
            this.aparechenar.Text = "Chenar alb";
            this.aparechenar.UseVisualStyleBackColor = true;
            this.aparechenar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // butonopenfile
            // 
            this.butonopenfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butonopenfile.Location = new System.Drawing.Point(77, 335);
            this.butonopenfile.Name = "butonopenfile";
            this.butonopenfile.Size = new System.Drawing.Size(120, 23);
            this.butonopenfile.TabIndex = 8;
            this.butonopenfile.Text = "OpenFile";
            this.butonopenfile.UseVisualStyleBackColor = true;
            this.butonopenfile.Click += new System.EventHandler(this.butonopenfile_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(256, 335);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(158, 20);
            this.txtBarcode.TabIndex = 10;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.butonopenfile);
            this.Controls.Add(this.aparechenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coddeafisat);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.valoare);
            this.Controls.Add(this.valintrodusa);
            this.Controls.Add(this.ButonSalveaza);
            this.Controls.Add(this.ButonGenereaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator cod bare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonGenereaza;
        private System.Windows.Forms.Button ButonSalveaza;
        private System.Windows.Forms.TextBox valintrodusa;
        private System.Windows.Forms.Label valoare;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox coddeafisat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox aparechenar;
        private System.Windows.Forms.Button butonopenfile;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}

