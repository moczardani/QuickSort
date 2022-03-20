
namespace QuickSort
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
            this.components = new System.ComponentModel.Container();
            this.NewBn = new System.Windows.Forms.Button();
            this.StartBn = new System.Windows.Forms.Button();
            this.palya = new System.Windows.Forms.PictureBox();
            this.Metronom = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.palya)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBn
            // 
            this.NewBn.Location = new System.Drawing.Point(682, 16);
            this.NewBn.Name = "NewBn";
            this.NewBn.Size = new System.Drawing.Size(96, 25);
            this.NewBn.TabIndex = 0;
            this.NewBn.Text = "Új";
            this.NewBn.UseVisualStyleBackColor = true;
            this.NewBn.Click += new System.EventHandler(this.Fill_Click);
            // 
            // StartBn
            // 
            this.StartBn.Location = new System.Drawing.Point(682, 47);
            this.StartBn.Name = "StartBn";
            this.StartBn.Size = new System.Drawing.Size(96, 25);
            this.StartBn.TabIndex = 1;
            this.StartBn.Text = "Start";
            this.StartBn.UseVisualStyleBackColor = true;
            this.StartBn.Click += new System.EventHandler(this.StartBn_Click);
            // 
            // palya
            // 
            this.palya.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.palya.Location = new System.Drawing.Point(12, 16);
            this.palya.Name = "palya";
            this.palya.Size = new System.Drawing.Size(664, 433);
            this.palya.TabIndex = 2;
            this.palya.TabStop = false;
            // 
            // Metronom
            // 
            this.Metronom.Interval = 10;
            this.Metronom.Tick += new System.EventHandler(this.Metronom_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.palya);
            this.Controls.Add(this.StartBn);
            this.Controls.Add(this.NewBn);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.palya)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewBn;
        private System.Windows.Forms.Button StartBn;
        private System.Windows.Forms.PictureBox palya;
        private System.Windows.Forms.Timer Metronom;
    }
}

