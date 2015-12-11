namespace LabSix
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
            this.backgrounds = new System.Windows.Forms.CheckedListBox();
            this.sizes = new System.Windows.Forms.CheckedListBox();
            this.titles = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgrounds
            // 
            this.backgrounds.CheckOnClick = true;
            this.backgrounds.FormattingEnabled = true;
            this.backgrounds.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.backgrounds.Location = new System.Drawing.Point(12, 27);
            this.backgrounds.Name = "backgrounds";
            this.backgrounds.Size = new System.Drawing.Size(162, 49);
            this.backgrounds.TabIndex = 0;
            this.backgrounds.SelectedIndexChanged += new System.EventHandler(this.backgrounds_SelectedIndexChanged);
            // 
            // sizes
            // 
            this.sizes.CheckOnClick = true;
            this.sizes.FormattingEnabled = true;
            this.sizes.Items.AddRange(new object[] {
            "Fullscreen",
            "Normal",
            "Halfscreen"});
            this.sizes.Location = new System.Drawing.Point(189, 27);
            this.sizes.Name = "sizes";
            this.sizes.Size = new System.Drawing.Size(162, 49);
            this.sizes.TabIndex = 1;
            this.sizes.SelectedIndexChanged += new System.EventHandler(this.sizes_SelectedIndexChanged);
            // 
            // titles
            // 
            this.titles.CheckOnClick = true;
            this.titles.FormattingEnabled = true;
            this.titles.Items.AddRange(new object[] {
            "Form1",
            "Customize Me",
            "New Form"});
            this.titles.Location = new System.Drawing.Point(367, 27);
            this.titles.Name = "titles";
            this.titles.Size = new System.Drawing.Size(162, 49);
            this.titles.TabIndex = 2;
            this.titles.SelectedIndexChanged += new System.EventHandler(this.titles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Background Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size of Window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(189, 110);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(162, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Retrieve Settings";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 261);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titles);
            this.Controls.Add(this.sizes);
            this.Controls.Add(this.backgrounds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox backgrounds;
        private System.Windows.Forms.CheckedListBox sizes;
        private System.Windows.Forms.CheckedListBox titles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
    }
}

