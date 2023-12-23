namespace AutoClicker
{
    partial class Options
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
            HotkeyGrid = new System.Windows.Forms.DataGridView();
            ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumntKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnControl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ColumnAlt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ColumnShift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ColumnWin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            buttonOK = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            buttonApply = new System.Windows.Forms.Button();
            buttonReset = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            checkBoxRegisterHotkeys = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)HotkeyGrid).BeginInit();
            SuspendLayout();
            // 
            // HotkeyGrid
            // 
            HotkeyGrid.AllowUserToAddRows = false;
            HotkeyGrid.AllowUserToDeleteRows = false;
            HotkeyGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            HotkeyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HotkeyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnFunction, ColumntKey, ColumnControl, ColumnAlt, ColumnShift, ColumnWin });
            HotkeyGrid.Location = new System.Drawing.Point(12, 52);
            HotkeyGrid.Name = "HotkeyGrid";
            HotkeyGrid.RowHeadersVisible = false;
            HotkeyGrid.Size = new System.Drawing.Size(577, 153);
            HotkeyGrid.TabIndex = 0;
            // 
            // ColumnFunction
            // 
            ColumnFunction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ColumnFunction.HeaderText = "Function";
            ColumnFunction.Name = "ColumnFunction";
            ColumnFunction.ReadOnly = true;
            // 
            // ColumntKey
            // 
            ColumntKey.HeaderText = "Key";
            ColumntKey.Name = "ColumntKey";
            ColumntKey.Width = 130;
            // 
            // ColumnControl
            // 
            ColumnControl.HeaderText = "Control";
            ColumnControl.Name = "ColumnControl";
            ColumnControl.Width = 50;
            // 
            // ColumnAlt
            // 
            ColumnAlt.HeaderText = "Alt";
            ColumnAlt.Name = "ColumnAlt";
            ColumnAlt.Width = 50;
            // 
            // ColumnShift
            // 
            ColumnShift.HeaderText = "Shift";
            ColumnShift.Name = "ColumnShift";
            ColumnShift.Width = 50;
            // 
            // ColumnWin
            // 
            ColumnWin.HeaderText = "Win";
            ColumnWin.Name = "ColumnWin";
            ColumnWin.Width = 50;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonOK.Location = new System.Drawing.Point(352, 211);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new System.Drawing.Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.Location = new System.Drawing.Point(514, 211);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonApply
            // 
            buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonApply.Location = new System.Drawing.Point(433, 211);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new System.Drawing.Size(75, 23);
            buttonApply.TabIndex = 3;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonReset.Location = new System.Drawing.Point(12, 211);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(75, 23);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Hotkeys";
            // 
            // checkBoxRegisterHotkeys
            // 
            checkBoxRegisterHotkeys.AutoSize = true;
            checkBoxRegisterHotkeys.Location = new System.Drawing.Point(12, 27);
            checkBoxRegisterHotkeys.Name = "checkBoxRegisterHotkeys";
            checkBoxRegisterHotkeys.Size = new System.Drawing.Size(111, 19);
            checkBoxRegisterHotkeys.TabIndex = 6;
            checkBoxRegisterHotkeys.Text = "RegisterHotkeys";
            checkBoxRegisterHotkeys.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(601, 243);
            Controls.Add(checkBoxRegisterHotkeys);
            Controls.Add(label1);
            Controls.Add(buttonReset);
            Controls.Add(buttonApply);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(HotkeyGrid);
            Name = "Options";
            Text = "Options";
            ((System.ComponentModel.ISupportInitialize)HotkeyGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView HotkeyGrid;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumntKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnControl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAlt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnShift;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnWin;
        private System.Windows.Forms.CheckBox checkBoxRegisterHotkeys;
    }
}