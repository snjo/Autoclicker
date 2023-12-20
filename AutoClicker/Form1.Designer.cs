namespace AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickInterval = new System.Windows.Forms.Timer(this.components);
            this.toggleTimer = new System.Windows.Forms.Button();
            this.clickDuration = new System.Windows.Forms.Timer(this.components);
            this.waitForStart = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.clickCountLabel = new System.Windows.Forms.Label();
            this.durationInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.clicksPerSecondInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startDelayInput = new System.Windows.Forms.NumericUpDown();
            this.UseCountdownInput = new System.Windows.Forms.CheckBox();
            this.StopWhenMouseMovesInput = new System.Windows.Forms.CheckBox();
            this.alwaysOnTopCheck = new System.Windows.Forms.CheckBox();
            this.StopWhenControlIsPressed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.durationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clicksPerSecondInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDelayInput)).BeginInit();
            this.SuspendLayout();
            // 
            // clickInterval
            // 
            this.clickInterval.Interval = 50;
            this.clickInterval.Tick += new System.EventHandler(this.onTimer);
            // 
            // toggleTimer
            // 
            this.toggleTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleTimer.Location = new System.Drawing.Point(5, 9);
            this.toggleTimer.MinimumSize = new System.Drawing.Size(67, 0);
            this.toggleTimer.Name = "toggleTimer";
            this.toggleTimer.Size = new System.Drawing.Size(181, 23);
            this.toggleTimer.TabIndex = 0;
            this.toggleTimer.Text = "start Clicking";
            this.toggleTimer.UseVisualStyleBackColor = true;
            this.toggleTimer.Click += new System.EventHandler(this.toggleTimerEvent);
            // 
            // clickDuration
            // 
            this.clickDuration.Interval = 5000;
            this.clickDuration.Tick += new System.EventHandler(this.disableClickingEvent);
            // 
            // waitForStart
            // 
            this.waitForStart.Interval = 2000;
            this.waitForStart.Tick += new System.EventHandler(this.startClickingEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "count click test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.countOneClick);
            // 
            // clickCountLabel
            // 
            this.clickCountLabel.AutoSize = true;
            this.clickCountLabel.Location = new System.Drawing.Point(103, 191);
            this.clickCountLabel.Name = "clickCountLabel";
            this.clickCountLabel.Size = new System.Drawing.Size(13, 13);
            this.clickCountLabel.TabIndex = 3;
            this.clickCountLabel.Text = "0";
            // 
            // durationInput
            // 
            this.durationInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.durationInput.Location = new System.Drawing.Point(105, 101);
            this.durationInput.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.durationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationInput.Name = "durationInput";
            this.durationInput.Size = new System.Drawing.Size(80, 20);
            this.durationInput.TabIndex = 4;
            this.durationInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duration (s)";
            // 
            // clicksPerSecondInput
            // 
            this.clicksPerSecondInput.Location = new System.Drawing.Point(105, 129);
            this.clicksPerSecondInput.Margin = new System.Windows.Forms.Padding(2);
            this.clicksPerSecondInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clicksPerSecondInput.Name = "clicksPerSecondInput";
            this.clicksPerSecondInput.Size = new System.Drawing.Size(80, 20);
            this.clicksPerSecondInput.TabIndex = 7;
            this.clicksPerSecondInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clicks per second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start delay (s)";
            // 
            // startDelayInput
            // 
            this.startDelayInput.Location = new System.Drawing.Point(105, 154);
            this.startDelayInput.Margin = new System.Windows.Forms.Padding(2);
            this.startDelayInput.Name = "startDelayInput";
            this.startDelayInput.Size = new System.Drawing.Size(80, 20);
            this.startDelayInput.TabIndex = 8;
            this.startDelayInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UseCountdownInput
            // 
            this.UseCountdownInput.AutoSize = true;
            this.UseCountdownInput.Location = new System.Drawing.Point(11, 79);
            this.UseCountdownInput.Margin = new System.Windows.Forms.Padding(2);
            this.UseCountdownInput.Name = "UseCountdownInput";
            this.UseCountdownInput.Size = new System.Drawing.Size(101, 17);
            this.UseCountdownInput.TabIndex = 9;
            this.UseCountdownInput.Text = "Use countdown";
            this.UseCountdownInput.UseVisualStyleBackColor = true;
            this.UseCountdownInput.CheckedChanged += new System.EventHandler(this.checkSafety);
            // 
            // StopWhenMouseMovesInput
            // 
            this.StopWhenMouseMovesInput.AutoSize = true;
            this.StopWhenMouseMovesInput.Checked = true;
            this.StopWhenMouseMovesInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StopWhenMouseMovesInput.Location = new System.Drawing.Point(11, 37);
            this.StopWhenMouseMovesInput.Margin = new System.Windows.Forms.Padding(2);
            this.StopWhenMouseMovesInput.Name = "StopWhenMouseMovesInput";
            this.StopWhenMouseMovesInput.Size = new System.Drawing.Size(145, 17);
            this.StopWhenMouseMovesInput.TabIndex = 9;
            this.StopWhenMouseMovesInput.Text = "Stop when mouse moves";
            this.StopWhenMouseMovesInput.UseVisualStyleBackColor = true;
            this.StopWhenMouseMovesInput.CheckedChanged += new System.EventHandler(this.checkSafety);
            // 
            // alwaysOnTopCheck
            // 
            this.alwaysOnTopCheck.AutoSize = true;
            this.alwaysOnTopCheck.Checked = true;
            this.alwaysOnTopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopCheck.Location = new System.Drawing.Point(12, 215);
            this.alwaysOnTopCheck.Margin = new System.Windows.Forms.Padding(2);
            this.alwaysOnTopCheck.Name = "alwaysOnTopCheck";
            this.alwaysOnTopCheck.Size = new System.Drawing.Size(92, 17);
            this.alwaysOnTopCheck.TabIndex = 10;
            this.alwaysOnTopCheck.Text = "Always on top";
            this.alwaysOnTopCheck.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheck.CheckedChanged += new System.EventHandler(this.toggleAlwaysOnTopEvent);
            // 
            // StopWhenControlIsPressed
            // 
            this.StopWhenControlIsPressed.AutoSize = true;
            this.StopWhenControlIsPressed.Checked = true;
            this.StopWhenControlIsPressed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StopWhenControlIsPressed.Location = new System.Drawing.Point(11, 58);
            this.StopWhenControlIsPressed.Margin = new System.Windows.Forms.Padding(2);
            this.StopWhenControlIsPressed.Name = "StopWhenControlIsPressed";
            this.StopWhenControlIsPressed.Size = new System.Drawing.Size(182, 17);
            this.StopWhenControlIsPressed.TabIndex = 11;
            this.StopWhenControlIsPressed.Text = "Stop when Control/Caps pressed";
            this.StopWhenControlIsPressed.UseVisualStyleBackColor = true;
            this.StopWhenControlIsPressed.CheckedChanged += new System.EventHandler(this.checkSafety);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 239);
            this.Controls.Add(this.StopWhenControlIsPressed);
            this.Controls.Add(this.alwaysOnTopCheck);
            this.Controls.Add(this.StopWhenMouseMovesInput);
            this.Controls.Add(this.UseCountdownInput);
            this.Controls.Add(this.startDelayInput);
            this.Controls.Add(this.clicksPerSecondInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationInput);
            this.Controls.Add(this.clickCountLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toggleTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoClicker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.durationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clicksPerSecondInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDelayInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clickInterval;
        private System.Windows.Forms.Button toggleTimer;
        private System.Windows.Forms.Timer clickDuration;
        private System.Windows.Forms.Timer waitForStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label clickCountLabel;
        private System.Windows.Forms.NumericUpDown durationInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown clicksPerSecondInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startDelayInput;
        private System.Windows.Forms.CheckBox UseCountdownInput;
        private System.Windows.Forms.CheckBox StopWhenMouseMovesInput;
        private System.Windows.Forms.CheckBox alwaysOnTopCheck;
        private System.Windows.Forms.CheckBox StopWhenControlIsPressed;
    }
}

