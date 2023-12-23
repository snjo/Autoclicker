namespace AutoClicker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            clickInterval = new System.Windows.Forms.Timer(components);
            toggleTimer = new System.Windows.Forms.Button();
            clickDuration = new System.Windows.Forms.Timer(components);
            waitForStart = new System.Windows.Forms.Timer(components);
            button1 = new System.Windows.Forms.Button();
            clickCountLabel = new System.Windows.Forms.Label();
            durationInput = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            clicksPerSecondInput = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            startDelayInput = new System.Windows.Forms.NumericUpDown();
            UseCountdownInput = new System.Windows.Forms.CheckBox();
            StopWhenMouseMovesInput = new System.Windows.Forms.CheckBox();
            alwaysOnTopCheck = new System.Windows.Forms.CheckBox();
            StopWhenControlIsPressed = new System.Windows.Forms.CheckBox();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)durationInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clicksPerSecondInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startDelayInput).BeginInit();
            SuspendLayout();
            // 
            // clickInterval
            // 
            clickInterval.Interval = 50;
            clickInterval.Tick += onTimer;
            // 
            // toggleTimer
            // 
            toggleTimer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            toggleTimer.Location = new System.Drawing.Point(6, 31);
            toggleTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            toggleTimer.MinimumSize = new System.Drawing.Size(78, 0);
            toggleTimer.Name = "toggleTimer";
            toggleTimer.Size = new System.Drawing.Size(211, 27);
            toggleTimer.TabIndex = 0;
            toggleTimer.Text = "start Clicking";
            toggleTimer.UseVisualStyleBackColor = true;
            toggleTimer.Click += toggleTimerEvent;
            // 
            // clickDuration
            // 
            clickDuration.Interval = 5000;
            clickDuration.Tick += disableClickingEvent;
            // 
            // waitForStart
            // 
            waitForStart.Interval = 2000;
            waitForStart.Tick += startClickingEvent;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 236);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 2;
            button1.Text = "count click test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += countOneClick;
            // 
            // clickCountLabel
            // 
            clickCountLabel.AutoSize = true;
            clickCountLabel.Location = new System.Drawing.Point(120, 241);
            clickCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            clickCountLabel.Name = "clickCountLabel";
            clickCountLabel.Size = new System.Drawing.Size(13, 15);
            clickCountLabel.TabIndex = 3;
            clickCountLabel.Text = "0";
            // 
            // durationInput
            // 
            durationInput.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            durationInput.Location = new System.Drawing.Point(122, 138);
            durationInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            durationInput.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            durationInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            durationInput.Name = "durationInput";
            durationInput.Size = new System.Drawing.Size(93, 23);
            durationInput.TabIndex = 4;
            durationInput.Value = new decimal(new int[] { 10, 0, 0, 0 });
            durationInput.ValueChanged += durationInput_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 142);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Duration (s)";
            // 
            // clicksPerSecondInput
            // 
            clicksPerSecondInput.Location = new System.Drawing.Point(122, 170);
            clicksPerSecondInput.Margin = new System.Windows.Forms.Padding(2);
            clicksPerSecondInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            clicksPerSecondInput.Name = "clicksPerSecondInput";
            clicksPerSecondInput.Size = new System.Drawing.Size(93, 23);
            clicksPerSecondInput.TabIndex = 7;
            clicksPerSecondInput.Value = new decimal(new int[] { 12, 0, 0, 0 });
            clicksPerSecondInput.ValueChanged += clicksPerSecondInput_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 174);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Clicks per second";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 204);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "Start delay (s)";
            // 
            // startDelayInput
            // 
            startDelayInput.Location = new System.Drawing.Point(122, 199);
            startDelayInput.Margin = new System.Windows.Forms.Padding(2);
            startDelayInput.Name = "startDelayInput";
            startDelayInput.Size = new System.Drawing.Size(93, 23);
            startDelayInput.TabIndex = 8;
            startDelayInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            startDelayInput.ValueChanged += startDelayInput_ValueChanged;
            // 
            // UseCountdownInput
            // 
            UseCountdownInput.AutoSize = true;
            UseCountdownInput.Location = new System.Drawing.Point(13, 112);
            UseCountdownInput.Margin = new System.Windows.Forms.Padding(2);
            UseCountdownInput.Name = "UseCountdownInput";
            UseCountdownInput.Size = new System.Drawing.Size(109, 19);
            UseCountdownInput.TabIndex = 9;
            UseCountdownInput.Text = "Use countdown";
            UseCountdownInput.UseVisualStyleBackColor = true;
            UseCountdownInput.CheckedChanged += checkSafety;
            // 
            // StopWhenMouseMovesInput
            // 
            StopWhenMouseMovesInput.AutoSize = true;
            StopWhenMouseMovesInput.Checked = true;
            StopWhenMouseMovesInput.CheckState = System.Windows.Forms.CheckState.Checked;
            StopWhenMouseMovesInput.Location = new System.Drawing.Point(13, 64);
            StopWhenMouseMovesInput.Margin = new System.Windows.Forms.Padding(2);
            StopWhenMouseMovesInput.Name = "StopWhenMouseMovesInput";
            StopWhenMouseMovesInput.Size = new System.Drawing.Size(159, 19);
            StopWhenMouseMovesInput.TabIndex = 9;
            StopWhenMouseMovesInput.Text = "Stop when mouse moves";
            StopWhenMouseMovesInput.UseVisualStyleBackColor = true;
            StopWhenMouseMovesInput.CheckedChanged += checkSafety;
            // 
            // alwaysOnTopCheck
            // 
            alwaysOnTopCheck.AutoSize = true;
            alwaysOnTopCheck.Checked = true;
            alwaysOnTopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            alwaysOnTopCheck.Location = new System.Drawing.Point(14, 269);
            alwaysOnTopCheck.Margin = new System.Windows.Forms.Padding(2);
            alwaysOnTopCheck.Name = "alwaysOnTopCheck";
            alwaysOnTopCheck.Size = new System.Drawing.Size(101, 19);
            alwaysOnTopCheck.TabIndex = 10;
            alwaysOnTopCheck.Text = "Always on top";
            alwaysOnTopCheck.UseVisualStyleBackColor = true;
            alwaysOnTopCheck.CheckedChanged += toggleAlwaysOnTopEvent;
            // 
            // StopWhenControlIsPressed
            // 
            StopWhenControlIsPressed.AutoSize = true;
            StopWhenControlIsPressed.Checked = true;
            StopWhenControlIsPressed.CheckState = System.Windows.Forms.CheckState.Checked;
            StopWhenControlIsPressed.Location = new System.Drawing.Point(13, 88);
            StopWhenControlIsPressed.Margin = new System.Windows.Forms.Padding(2);
            StopWhenControlIsPressed.Name = "StopWhenControlIsPressed";
            StopWhenControlIsPressed.Size = new System.Drawing.Size(199, 19);
            StopWhenControlIsPressed.TabIndex = 11;
            StopWhenControlIsPressed.Text = "Stop when Control/Caps pressed";
            StopWhenControlIsPressed.UseVisualStyleBackColor = true;
            StopWhenControlIsPressed.CheckedChanged += checkSafety;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(193, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(24, 23);
            button2.TabIndex = 12;
            button2.Text = "⚙️";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(225, 299);
            Controls.Add(button2);
            Controls.Add(StopWhenControlIsPressed);
            Controls.Add(alwaysOnTopCheck);
            Controls.Add(StopWhenMouseMovesInput);
            Controls.Add(UseCountdownInput);
            Controls.Add(startDelayInput);
            Controls.Add(clicksPerSecondInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(durationInput);
            Controls.Add(clickCountLabel);
            Controls.Add(button1);
            Controls.Add(toggleTimer);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "AutoClicker";
            TopMost = true;
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)durationInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)clicksPerSecondInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)startDelayInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button button2;
    }
}

