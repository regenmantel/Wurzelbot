namespace Wurzelbot
{
    partial class WurzelBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WurzelBot));
            this.btnGO = new System.Windows.Forms.Button();
            this.cBoxSpeed = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cBoxFields = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rBtnNormalScreen = new System.Windows.Forms.RadioButton();
            this.rBtnWideScreen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiessen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            resources.ApplyResources(this.btnGO, "btnGO");
            this.btnGO.Name = "btnGO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // cBoxSpeed
            // 
            this.cBoxSpeed.FormattingEnabled = true;
            this.cBoxSpeed.Items.AddRange(new object[] {
            resources.GetString("cBoxSpeed.Items"),
            resources.GetString("cBoxSpeed.Items1"),
            resources.GetString("cBoxSpeed.Items2"),
            resources.GetString("cBoxSpeed.Items3"),
            resources.GetString("cBoxSpeed.Items4"),
            resources.GetString("cBoxSpeed.Items5"),
            resources.GetString("cBoxSpeed.Items6"),
            resources.GetString("cBoxSpeed.Items7"),
            resources.GetString("cBoxSpeed.Items8")});
            resources.ApplyResources(this.cBoxSpeed, "cBoxSpeed");
            this.cBoxSpeed.Name = "cBoxSpeed";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // cBoxFields
            // 
            this.cBoxFields.FormattingEnabled = true;
            this.cBoxFields.Items.AddRange(new object[] {
            resources.GetString("cBoxFields.Items"),
            resources.GetString("cBoxFields.Items1"),
            resources.GetString("cBoxFields.Items2")});
            resources.ApplyResources(this.cBoxFields, "cBoxFields");
            this.cBoxFields.Name = "cBoxFields";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rBtnNormalScreen
            // 
            resources.ApplyResources(this.rBtnNormalScreen, "rBtnNormalScreen");
            this.rBtnNormalScreen.Name = "rBtnNormalScreen";
            this.rBtnNormalScreen.TabStop = true;
            this.rBtnNormalScreen.UseVisualStyleBackColor = true;
            // 
            // rBtnWideScreen
            // 
            resources.ApplyResources(this.rBtnWideScreen, "rBtnWideScreen");
            this.rBtnWideScreen.Name = "rBtnWideScreen";
            this.rBtnWideScreen.TabStop = true;
            this.rBtnWideScreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnGiessen
            // 
            resources.ApplyResources(this.btnGiessen, "btnGiessen");
            this.btnGiessen.Name = "btnGiessen";
            this.btnGiessen.UseVisualStyleBackColor = true;
            this.btnGiessen.Click += new System.EventHandler(this.btnGiessen_Click);
            // 
            // WurzelBot
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnGiessen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rBtnWideScreen);
            this.Controls.Add(this.rBtnNormalScreen);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBoxFields);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cBoxSpeed);
            this.Controls.Add(this.btnGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "WurzelBot";
            this.Load += new System.EventHandler(this.WurzelBot_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WurzelBot_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGO;
        private ComboBox cBoxSpeed;
        private Label lblTime;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private ComboBox cBoxFields;
        private Label label8;
        private Button btnHelp;
        private RadioButton rBtnNormalScreen;
        private RadioButton rBtnWideScreen;
        private Label label2;
        private Button btnGiessen;
    }
}