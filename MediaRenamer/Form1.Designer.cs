namespace MediaRenamer
{
    partial class MainWindow
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
            this.Browse = new System.Windows.Forms.Button();
            this.WorkingDirectory = new System.Windows.Forms.TextBox();
            this.Rename = new System.Windows.Forms.Button();
            this.ReplaceSpaces = new System.Windows.Forms.CheckBox();
            this.KillHyphens = new System.Windows.Forms.CheckBox();
            this.RemoveDoubleDot = new System.Windows.Forms.CheckBox();
            this.TextValues = new System.Windows.Forms.ListBox();
            this.RemoveText = new System.Windows.Forms.CheckBox();
            this.TextValue = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.ReplaceFrom = new System.Windows.Forms.TextBox();
            this.ReplaceText = new System.Windows.Forms.CheckBox();
            this.ReplaceTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTextValue = new System.Windows.Forms.TextBox();
            this.AddText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(274, 10);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(25, 23);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // WorkingDirectory
            // 
            this.WorkingDirectory.Location = new System.Drawing.Point(13, 13);
            this.WorkingDirectory.Name = "WorkingDirectory";
            this.WorkingDirectory.Size = new System.Drawing.Size(259, 20);
            this.WorkingDirectory.TabIndex = 1;
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(224, 280);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(75, 23);
            this.Rename.TabIndex = 2;
            this.Rename.Text = "Rename Files";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // ReplaceSpaces
            // 
            this.ReplaceSpaces.AutoSize = true;
            this.ReplaceSpaces.Checked = true;
            this.ReplaceSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplaceSpaces.Location = new System.Drawing.Point(12, 221);
            this.ReplaceSpaces.Name = "ReplaceSpaces";
            this.ReplaceSpaces.Size = new System.Drawing.Size(164, 17);
            this.ReplaceSpaces.TabIndex = 3;
            this.ReplaceSpaces.Text = "Replace Spaces with periods";
            this.ReplaceSpaces.UseVisualStyleBackColor = true;
            // 
            // KillHyphens
            // 
            this.KillHyphens.AutoSize = true;
            this.KillHyphens.Checked = true;
            this.KillHyphens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KillHyphens.Location = new System.Drawing.Point(12, 198);
            this.KillHyphens.Name = "KillHyphens";
            this.KillHyphens.Size = new System.Drawing.Size(111, 17);
            this.KillHyphens.TabIndex = 4;
            this.KillHyphens.Text = "Remove Hyphens";
            this.KillHyphens.UseVisualStyleBackColor = true;
            // 
            // RemoveDoubleDot
            // 
            this.RemoveDoubleDot.AutoSize = true;
            this.RemoveDoubleDot.Checked = true;
            this.RemoveDoubleDot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveDoubleDot.Location = new System.Drawing.Point(11, 244);
            this.RemoveDoubleDot.Name = "RemoveDoubleDot";
            this.RemoveDoubleDot.Size = new System.Drawing.Size(141, 17);
            this.RemoveDoubleDot.TabIndex = 5;
            this.RemoveDoubleDot.Text = "Remove Double Periods";
            this.RemoveDoubleDot.UseVisualStyleBackColor = true;
            // 
            // TextValues
            // 
            this.TextValues.FormattingEnabled = true;
            this.TextValues.Location = new System.Drawing.Point(152, 97);
            this.TextValues.Name = "TextValues";
            this.TextValues.Size = new System.Drawing.Size(120, 43);
            this.TextValues.TabIndex = 6;
            // 
            // RemoveText
            // 
            this.RemoveText.AutoSize = true;
            this.RemoveText.Checked = true;
            this.RemoveText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveText.Location = new System.Drawing.Point(13, 74);
            this.RemoveText.Name = "RemoveText";
            this.RemoveText.Size = new System.Drawing.Size(90, 17);
            this.RemoveText.TabIndex = 7;
            this.RemoveText.Text = "Remove Text";
            this.RemoveText.UseVisualStyleBackColor = true;
            // 
            // TextValue
            // 
            this.TextValue.Location = new System.Drawing.Point(109, 71);
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(163, 20);
            this.TextValue.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(274, 70);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(25, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(274, 97);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(25, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "-";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ReplaceFrom
            // 
            this.ReplaceFrom.Location = new System.Drawing.Point(109, 146);
            this.ReplaceFrom.Name = "ReplaceFrom";
            this.ReplaceFrom.Size = new System.Drawing.Size(163, 20);
            this.ReplaceFrom.TabIndex = 12;
            // 
            // ReplaceText
            // 
            this.ReplaceText.AutoSize = true;
            this.ReplaceText.Checked = true;
            this.ReplaceText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplaceText.Location = new System.Drawing.Point(13, 149);
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.Size = new System.Drawing.Size(90, 17);
            this.ReplaceText.TabIndex = 11;
            this.ReplaceText.Text = "Replace Text";
            this.ReplaceText.UseVisualStyleBackColor = true;
            // 
            // ReplaceTo
            // 
            this.ReplaceTo.Location = new System.Drawing.Point(109, 172);
            this.ReplaceTo.Name = "ReplaceTo";
            this.ReplaceTo.Size = new System.Drawing.Size(163, 20);
            this.ReplaceTo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "With Text";
            // 
            // AddTextValue
            // 
            this.AddTextValue.Location = new System.Drawing.Point(109, 45);
            this.AddTextValue.Name = "AddTextValue";
            this.AddTextValue.Size = new System.Drawing.Size(163, 20);
            this.AddTextValue.TabIndex = 16;
            // 
            // AddText
            // 
            this.AddText.AutoSize = true;
            this.AddText.Checked = true;
            this.AddText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddText.Location = new System.Drawing.Point(13, 48);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(69, 17);
            this.AddText.TabIndex = 15;
            this.AddText.Text = "Add Text";
            this.AddText.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 315);
            this.Controls.Add(this.AddTextValue);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceTo);
            this.Controls.Add(this.ReplaceFrom);
            this.Controls.Add(this.ReplaceText);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TextValue);
            this.Controls.Add(this.RemoveText);
            this.Controls.Add(this.TextValues);
            this.Controls.Add(this.RemoveDoubleDot);
            this.Controls.Add(this.KillHyphens);
            this.Controls.Add(this.ReplaceSpaces);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.WorkingDirectory);
            this.Controls.Add(this.Browse);
            this.Name = "MainWindow";
            this.Text = "MediaRenamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox WorkingDirectory;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.CheckBox ReplaceSpaces;
        private System.Windows.Forms.CheckBox KillHyphens;
        private System.Windows.Forms.CheckBox RemoveDoubleDot;
        private System.Windows.Forms.ListBox TextValues;
        private System.Windows.Forms.CheckBox RemoveText;
        private System.Windows.Forms.TextBox TextValue;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox ReplaceFrom;
        private System.Windows.Forms.CheckBox ReplaceText;
        private System.Windows.Forms.TextBox ReplaceTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTextValue;
        private System.Windows.Forms.CheckBox AddText;
    }
}

