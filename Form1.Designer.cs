namespace Wurzelbot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnWasser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.cBoxSpeed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWasser
            // 
            this.btnWasser.Location = new System.Drawing.Point(293, 244);
            this.btnWasser.Name = "btnWasser";
            this.btnWasser.Size = new System.Drawing.Size(54, 23);
            this.btnWasser.TabIndex = 0;
            this.btnWasser.Text = "Gießen";
            this.btnWasser.UseVisualStyleBackColor = true;
            this.btnWasser.Click += new System.EventHandler(this.btnWasser_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(197, 556);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(54, 23);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "GOGO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // cBoxSpeed
            // 
            this.cBoxSpeed.FormattingEnabled = true;
            this.cBoxSpeed.Items.AddRange(new object[] {
            "10",
            "30",
            "50",
            "70",
            "100",
            "300",
            "500",
            "700",
            "1000"});
            this.cBoxSpeed.Location = new System.Drawing.Point(143, 557);
            this.cBoxSpeed.Name = "cBoxSpeed";
            this.cBoxSpeed.Size = new System.Drawing.Size(48, 23);
            this.cBoxSpeed.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(419, 648);
            this.Controls.Add(this.cBoxSpeed);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWasser);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnWasser;
        private PictureBox pictureBox1;
        private Button btnGO;
        private ComboBox cBoxSpeed;
    }
}