namespace sprintAppEnthusiast
{
    partial class SprintMain
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sixtyOneTwentyRadioButton = new System.Windows.Forms.RadioButton();
            this.thirtySixtyRadioButton = new System.Windows.Forms.RadioButton();
            this.timeElapsed_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.GOButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coolDown5 = new System.Windows.Forms.RadioButton();
            this.coolDown10 = new System.Windows.Forms.RadioButton();
            this.coolDown0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.warmUp5 = new System.Windows.Forms.RadioButton();
            this.warmUp10 = new System.Windows.Forms.RadioButton();
            this.warmUp0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.excerciseTargetNumber = new System.Windows.Forms.NumericUpDown();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excerciseTargetNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Cool Down On Demand";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sixtyOneTwentyRadioButton);
            this.groupBox4.Controls.Add(this.thirtySixtyRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(132, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 61);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sprint Styles";
            // 
            // sixtyOneTwentyRadioButton
            // 
            this.sixtyOneTwentyRadioButton.AutoSize = true;
            this.sixtyOneTwentyRadioButton.Location = new System.Drawing.Point(26, 35);
            this.sixtyOneTwentyRadioButton.Name = "sixtyOneTwentyRadioButton";
            this.sixtyOneTwentyRadioButton.Size = new System.Drawing.Size(73, 17);
            this.sixtyOneTwentyRadioButton.TabIndex = 1;
            this.sixtyOneTwentyRadioButton.Text = "60 / 120\'s";
            this.sixtyOneTwentyRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirtySixtyRadioButton
            // 
            this.thirtySixtyRadioButton.AutoSize = true;
            this.thirtySixtyRadioButton.Checked = true;
            this.thirtySixtyRadioButton.Location = new System.Drawing.Point(26, 15);
            this.thirtySixtyRadioButton.Name = "thirtySixtyRadioButton";
            this.thirtySixtyRadioButton.Size = new System.Drawing.Size(67, 17);
            this.thirtySixtyRadioButton.TabIndex = 0;
            this.thirtySixtyRadioButton.TabStop = true;
            this.thirtySixtyRadioButton.Text = "30 / 60\'s";
            this.thirtySixtyRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeElapsed_Label
            // 
            this.timeElapsed_Label.AutoSize = true;
            this.timeElapsed_Label.Location = new System.Drawing.Point(186, 29);
            this.timeElapsed_Label.Name = "timeElapsed_Label";
            this.timeElapsed_Label.Size = new System.Drawing.Size(28, 13);
            this.timeElapsed_Label.TabIndex = 21;
            this.timeElapsed_Label.Text = "0:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Elapsed Time";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(225, 228);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(57, 23);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // GOButton
            // 
            this.GOButton.Location = new System.Drawing.Point(151, 228);
            this.GOButton.Name = "GOButton";
            this.GOButton.Size = new System.Drawing.Size(68, 23);
            this.GOButton.TabIndex = 18;
            this.GOButton.Text = "GO!";
            this.GOButton.UseVisualStyleBackColor = true;
            this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(132, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 86);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notification Style";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Voice";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Whistles";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Tones";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.coolDown5);
            this.groupBox2.Controls.Add(this.coolDown10);
            this.groupBox2.Controls.Add(this.coolDown0);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 61);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "coolDown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0     /     5     /   10";
            // 
            // coolDown5
            // 
            this.coolDown5.AutoSize = true;
            this.coolDown5.Location = new System.Drawing.Point(47, 19);
            this.coolDown5.Name = "coolDown5";
            this.coolDown5.Size = new System.Drawing.Size(14, 13);
            this.coolDown5.TabIndex = 6;
            this.coolDown5.TabStop = true;
            this.coolDown5.UseVisualStyleBackColor = true;
            // 
            // coolDown10
            // 
            this.coolDown10.AutoSize = true;
            this.coolDown10.Location = new System.Drawing.Point(87, 19);
            this.coolDown10.Name = "coolDown10";
            this.coolDown10.Size = new System.Drawing.Size(14, 13);
            this.coolDown10.TabIndex = 5;
            this.coolDown10.UseVisualStyleBackColor = true;
            // 
            // coolDown0
            // 
            this.coolDown0.AutoSize = true;
            this.coolDown0.Checked = true;
            this.coolDown0.Location = new System.Drawing.Point(7, 19);
            this.coolDown0.Name = "coolDown0";
            this.coolDown0.Size = new System.Drawing.Size(14, 13);
            this.coolDown0.TabIndex = 4;
            this.coolDown0.TabStop = true;
            this.coolDown0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.warmUp5);
            this.groupBox1.Controls.Add(this.warmUp10);
            this.groupBox1.Controls.Add(this.warmUp0);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 62);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warm-Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "0     /     5     /   10";
            // 
            // warmUp5
            // 
            this.warmUp5.AutoSize = true;
            this.warmUp5.Location = new System.Drawing.Point(47, 19);
            this.warmUp5.Name = "warmUp5";
            this.warmUp5.Size = new System.Drawing.Size(14, 13);
            this.warmUp5.TabIndex = 2;
            this.warmUp5.TabStop = true;
            this.warmUp5.UseVisualStyleBackColor = true;
            // 
            // warmUp10
            // 
            this.warmUp10.AutoSize = true;
            this.warmUp10.Location = new System.Drawing.Point(87, 19);
            this.warmUp10.Name = "warmUp10";
            this.warmUp10.Size = new System.Drawing.Size(14, 13);
            this.warmUp10.TabIndex = 1;
            this.warmUp10.TabStop = true;
            this.warmUp10.UseVisualStyleBackColor = true;
            // 
            // warmUp0
            // 
            this.warmUp0.AutoSize = true;
            this.warmUp0.Checked = true;
            this.warmUp0.Location = new System.Drawing.Point(7, 19);
            this.warmUp0.Name = "warmUp0";
            this.warmUp0.Size = new System.Drawing.Size(14, 13);
            this.warmUp0.TabIndex = 0;
            this.warmUp0.TabStop = true;
            this.warmUp0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of Minutes to workout";
            // 
            // excerciseTargetNumber
            // 
            this.excerciseTargetNumber.Location = new System.Drawing.Point(12, 31);
            this.excerciseTargetNumber.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.excerciseTargetNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.excerciseTargetNumber.Name = "excerciseTargetNumber";
            this.excerciseTargetNumber.Size = new System.Drawing.Size(120, 20);
            this.excerciseTargetNumber.TabIndex = 13;
            this.excerciseTargetNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(306, 228);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 24;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // SprintMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.timeElapsed_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.GOButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excerciseTargetNumber);
            this.Name = "SprintMain";
            this.Text = "Spr!nts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SprintMain_FormClosed);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excerciseTargetNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton sixtyOneTwentyRadioButton;
        private System.Windows.Forms.RadioButton thirtySixtyRadioButton;
        private System.Windows.Forms.Label timeElapsed_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button GOButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton coolDown5;
        private System.Windows.Forms.RadioButton coolDown10;
        private System.Windows.Forms.RadioButton coolDown0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton warmUp5;
        private System.Windows.Forms.RadioButton warmUp10;
        private System.Windows.Forms.RadioButton warmUp0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown excerciseTargetNumber;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button btnPause;
    }
}

