namespace lab70_75
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
            lab70_71 = new Button();
            lab72_73 = new Button();
            lab74_75 = new Button();
            SuspendLayout();
            // 
            // lab70_71
            // 
            lab70_71.Location = new Point(12, 12);
            lab70_71.Name = "lab70_71";
            lab70_71.Size = new Size(137, 23);
            lab70_71.TabIndex = 0;
            lab70_71.Text = "lab70_71";
            lab70_71.UseVisualStyleBackColor = true;
            lab70_71.Click += lab70_71_Click;
            // 
            // lab72_73
            // 
            lab72_73.Location = new Point(12, 41);
            lab72_73.Name = "lab72_73";
            lab72_73.Size = new Size(137, 23);
            lab72_73.TabIndex = 1;
            lab72_73.Text = "lab72_73";
            lab72_73.UseVisualStyleBackColor = true;
            lab72_73.Click += lab72_73_Click;
            // 
            // lab74_75
            // 
            lab74_75.Location = new Point(12, 70);
            lab74_75.Name = "lab74_75";
            lab74_75.Size = new Size(137, 23);
            lab74_75.TabIndex = 2;
            lab74_75.Text = "lab74_75";
            lab74_75.UseVisualStyleBackColor = true;
            lab74_75.Click += lab74_75_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(161, 105);
            Controls.Add(lab74_75);
            Controls.Add(lab72_73);
            Controls.Add(lab70_71);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button lab70_71;
        private Button lab72_73;
        private Button lab74_75;
    }
}
