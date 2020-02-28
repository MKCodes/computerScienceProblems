namespace computerScienceProblems
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
            this.minimumButton = new System.Windows.Forms.Button();
            this.avarageButton = new System.Windows.Forms.Button();
            this.MedianButton = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.UnsortingListButton = new System.Windows.Forms.Button();
            this.minimumValue = new System.Windows.Forms.Label();
            this.avarageLabel = new System.Windows.Forms.Label();
            this.medianLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.randomizingListLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CalculateAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Median = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimum_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArithmeticAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnsortingList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Values = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nNumberLabel = new System.Windows.Forms.Label();
            this.NthSmallestButton = new System.Windows.Forms.Button();
            this.NthSmallestTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimumButton
            // 
            this.minimumButton.Location = new System.Drawing.Point(135, 56);
            this.minimumButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimumButton.Name = "minimumButton";
            this.minimumButton.Size = new System.Drawing.Size(112, 50);
            this.minimumButton.TabIndex = 0;
            this.minimumButton.Text = "Minimum Value";
            this.minimumButton.UseVisualStyleBackColor = true;
            this.minimumButton.Click += new System.EventHandler(this.MinimumButton_Click);
            // 
            // avarageButton
            // 
            this.avarageButton.Location = new System.Drawing.Point(286, 56);
            this.avarageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avarageButton.Name = "avarageButton";
            this.avarageButton.Size = new System.Drawing.Size(112, 50);
            this.avarageButton.TabIndex = 1;
            this.avarageButton.Text = "Arithmetic Avarage Button";
            this.avarageButton.UseVisualStyleBackColor = true;
            this.avarageButton.Click += new System.EventHandler(this.AvarageButton_Click);
            // 
            // MedianButton
            // 
            this.MedianButton.Location = new System.Drawing.Point(437, 55);
            this.MedianButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MedianButton.Name = "MedianButton";
            this.MedianButton.Size = new System.Drawing.Size(112, 51);
            this.MedianButton.TabIndex = 2;
            this.MedianButton.Text = "Median";
            this.MedianButton.UseVisualStyleBackColor = true;
            this.MedianButton.Click += new System.EventHandler(this.MedianButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(574, 55);
            this.ModeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(112, 50);
            this.ModeButton.TabIndex = 3;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // UnsortingListButton
            // 
            this.UnsortingListButton.Location = new System.Drawing.Point(706, 55);
            this.UnsortingListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnsortingListButton.Name = "UnsortingListButton";
            this.UnsortingListButton.Size = new System.Drawing.Size(112, 50);
            this.UnsortingListButton.TabIndex = 4;
            this.UnsortingListButton.Text = "Randomizing List Order";
            this.UnsortingListButton.UseVisualStyleBackColor = true;
            this.UnsortingListButton.Click += new System.EventHandler(this.UnsortingButton_Click);
            // 
            // minimumValue
            // 
            this.minimumValue.AutoSize = true;
            this.minimumValue.Location = new System.Drawing.Point(160, 105);
            this.minimumValue.Name = "minimumValue";
            this.minimumValue.Size = new System.Drawing.Size(0, 17);
            this.minimumValue.TabIndex = 5;
            // 
            // avarageLabel
            // 
            this.avarageLabel.AutoSize = true;
            this.avarageLabel.Location = new System.Drawing.Point(303, 105);
            this.avarageLabel.Name = "avarageLabel";
            this.avarageLabel.Size = new System.Drawing.Size(0, 17);
            this.avarageLabel.TabIndex = 6;
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(487, 105);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(0, 17);
            this.medianLabel.TabIndex = 7;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(615, 105);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(0, 17);
            this.modeLabel.TabIndex = 8;
            // 
            // randomizingListLabel
            // 
            this.randomizingListLabel.AutoSize = true;
            this.randomizingListLabel.Location = new System.Drawing.Point(711, 105);
            this.randomizingListLabel.Name = "randomizingListLabel";
            this.randomizingListLabel.Size = new System.Drawing.Size(0, 17);
            this.randomizingListLabel.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(11, 325);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(67, 34);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CalculateAllButton
            // 
            this.CalculateAllButton.Location = new System.Drawing.Point(840, 170);
            this.CalculateAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateAllButton.Name = "CalculateAllButton";
            this.CalculateAllButton.Size = new System.Drawing.Size(125, 31);
            this.CalculateAllButton.TabIndex = 11;
            this.CalculateAllButton.Text = "Calculate All";
            this.CalculateAllButton.UseVisualStyleBackColor = true;
            this.CalculateAllButton.Click += new System.EventHandler(this.CalculateAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Median,
            this.Minimum_Value,
            this.ArithmeticAverage,
            this.Mode,
            this.UnsortingList});
            this.dataGridView1.Location = new System.Drawing.Point(123, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(946, 120);
            this.dataGridView1.TabIndex = 12;
            // 
            // Median
            // 
            this.Median.HeaderText = "Median";
            this.Median.MinimumWidth = 8;
            this.Median.Name = "Median";
            this.Median.Width = 75;
            // 
            // Minimum_Value
            // 
            this.Minimum_Value.HeaderText = "Minimum Value";
            this.Minimum_Value.MinimumWidth = 8;
            this.Minimum_Value.Name = "Minimum_Value";
            this.Minimum_Value.Width = 75;
            // 
            // ArithmeticAverage
            // 
            this.ArithmeticAverage.HeaderText = "Arithmetic Average";
            this.ArithmeticAverage.MinimumWidth = 8;
            this.ArithmeticAverage.Name = "ArithmeticAverage";
            this.ArithmeticAverage.Width = 75;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Mode";
            this.Mode.MinimumWidth = 8;
            this.Mode.Name = "Mode";
            this.Mode.Width = 150;
            // 
            // UnsortingList
            // 
            this.UnsortingList.HeaderText = "Randomized List Order";
            this.UnsortingList.MinimumWidth = 8;
            this.UnsortingList.Name = "UnsortingList";
            this.UnsortingList.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalculateAllButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(103, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(989, 208);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation Results";
            // 
            // Values
            // 
            this.Values.Location = new System.Drawing.Point(269, 18);
            this.Values.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(292, 22);
            this.Values.TabIndex = 14;
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(135, 10);
            this.InputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(119, 33);
            this.InputButton.TabIndex = 15;
            this.InputButton.Text = "Input Values";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(856, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // nNumberLabel
            // 
            this.nNumberLabel.AutoSize = true;
            this.nNumberLabel.Location = new System.Drawing.Point(874, 114);
            this.nNumberLabel.Name = "nNumberLabel";
            this.nNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.nNumberLabel.TabIndex = 18;
            // 
            // NthSmallestButton
            // 
            this.NthSmallestButton.Location = new System.Drawing.Point(856, 57);
            this.NthSmallestButton.Name = "NthSmallestButton";
            this.NthSmallestButton.Size = new System.Drawing.Size(107, 49);
            this.NthSmallestButton.TabIndex = 19;
            this.NthSmallestButton.Text = "nth Smallest";
            this.NthSmallestButton.UseVisualStyleBackColor = true;
            this.NthSmallestButton.Click += new System.EventHandler(this.NthSmallestButton_Click);
            // 
            // NthSmallestTextBox
            // 
            this.NthSmallestTextBox.Location = new System.Drawing.Point(983, 68);
            this.NthSmallestTextBox.Name = "NthSmallestTextBox";
            this.NthSmallestTextBox.Size = new System.Drawing.Size(109, 22);
            this.NthSmallestTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1132, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1255, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NthSmallestTextBox);
            this.Controls.Add(this.NthSmallestButton);
            this.Controls.Add(this.nNumberLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.Values);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.randomizingListLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.medianLabel);
            this.Controls.Add(this.avarageLabel);
            this.Controls.Add(this.minimumValue);
            this.Controls.Add(this.UnsortingListButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.MedianButton);
            this.Controls.Add(this.avarageButton);
            this.Controls.Add(this.minimumButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mathmatical Problems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimumButton;
        private System.Windows.Forms.Button avarageButton;
        private System.Windows.Forms.Button MedianButton;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button UnsortingListButton;
        private System.Windows.Forms.Label minimumValue;
        private System.Windows.Forms.Label avarageLabel;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label randomizingListLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CalculateAllButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Median;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimum_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArithmeticAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnsortingList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Values;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nNumberLabel;
        private System.Windows.Forms.Button NthSmallestButton;
        private System.Windows.Forms.TextBox NthSmallestTextBox;
        private System.Windows.Forms.Button button1;
    }
}

