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
            btnPlant = new Button();
            cBoxSpeed = new ComboBox();
            lblTime = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            cBoxFields = new ComboBox();
            label8 = new Label();
            rBtnNormalScreen = new RadioButton();
            rBtnWideScreen = new RadioButton();
            label2 = new Label();
            btnWater = new Button();
            btnHarvest = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnPlant
            // 
            resources.ApplyResources(btnPlant, "btnPlant");
            btnPlant.Name = "btnPlant";
            btnPlant.UseVisualStyleBackColor = true;
            btnPlant.Click += btnPlant_Click;
            // 
            // cBoxSpeed
            // 
            cBoxSpeed.FormattingEnabled = true;
            cBoxSpeed.Items.AddRange(new object[] { resources.GetString("cBoxSpeed.Items"), resources.GetString("cBoxSpeed.Items1"), resources.GetString("cBoxSpeed.Items2"), resources.GetString("cBoxSpeed.Items3"), resources.GetString("cBoxSpeed.Items4"), resources.GetString("cBoxSpeed.Items5"), resources.GetString("cBoxSpeed.Items6"), resources.GetString("cBoxSpeed.Items7"), resources.GetString("cBoxSpeed.Items8") });
            resources.ApplyResources(cBoxSpeed, "cBoxSpeed");
            cBoxSpeed.Name = "cBoxSpeed";
            // 
            // lblTime
            // 
            resources.ApplyResources(lblTime, "lblTime");
            lblTime.Name = "lblTime";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // cBoxFields
            // 
            cBoxFields.FormattingEnabled = true;
            cBoxFields.Items.AddRange(new object[] { resources.GetString("cBoxFields.Items"), resources.GetString("cBoxFields.Items1"), resources.GetString("cBoxFields.Items2") });
            resources.ApplyResources(cBoxFields, "cBoxFields");
            cBoxFields.Name = "cBoxFields";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // rBtnNormalScreen
            // 
            resources.ApplyResources(rBtnNormalScreen, "rBtnNormalScreen");
            rBtnNormalScreen.Name = "rBtnNormalScreen";
            rBtnNormalScreen.TabStop = true;
            rBtnNormalScreen.UseVisualStyleBackColor = true;
            // 
            // rBtnWideScreen
            // 
            resources.ApplyResources(rBtnWideScreen, "rBtnWideScreen");
            rBtnWideScreen.Name = "rBtnWideScreen";
            rBtnWideScreen.TabStop = true;
            rBtnWideScreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // btnWater
            // 
            resources.ApplyResources(btnWater, "btnWater");
            btnWater.Name = "btnWater";
            btnWater.UseVisualStyleBackColor = true;
            btnWater.Click += btnWater_Click;
            // 
            // btnHarvest
            // 
            resources.ApplyResources(btnHarvest, "btnHarvest");
            btnHarvest.Name = "btnHarvest";
            btnHarvest.UseVisualStyleBackColor = true;
            btnHarvest.Click += btnHarvest_Click;
            // 
            // WurzelBot
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            resources.ApplyResources(this, "$this");
            Controls.Add(btnHarvest);
            Controls.Add(btnWater);
            Controls.Add(label2);
            Controls.Add(rBtnWideScreen);
            Controls.Add(rBtnNormalScreen);
            Controls.Add(label8);
            Controls.Add(cBoxFields);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblTime);
            Controls.Add(cBoxSpeed);
            Controls.Add(btnPlant);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            Name = "WurzelBot";
            Load += WurzelBot_Load;
            KeyPress += WurzelBot_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlant;
        private ComboBox cBoxSpeed;
        private Label lblTime;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private ComboBox cBoxFields;
        private Label label8;
        private RadioButton rBtnNormalScreen;
        private RadioButton rBtnWideScreen;
        private Label label2;
        private Button btnWater;
        private Button btnHarvest;
    }
}