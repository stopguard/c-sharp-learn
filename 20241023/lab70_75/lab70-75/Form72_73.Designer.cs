namespace lab70_75
{
    partial class Form72_73
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
            buttonNew = new Button();
            buttonClose = new Button();
            buttonVertical = new Button();
            buttonHorizontal = new Button();
            buttonCascade = new Button();
            SuspendLayout();
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(12, 12);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(88, 23);
            buttonNew.TabIndex = 0;
            buttonNew.Text = "Create form";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 41);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(88, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close all";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonVertical
            // 
            buttonVertical.Location = new Point(12, 70);
            buttonVertical.Name = "buttonVertical";
            buttonVertical.Size = new Size(88, 23);
            buttonVertical.TabIndex = 4;
            buttonVertical.Text = "TileVertical";
            buttonVertical.UseVisualStyleBackColor = true;
            buttonVertical.Click += buttonVertical_Click;
            // 
            // buttonHorizontal
            // 
            buttonHorizontal.Location = new Point(12, 99);
            buttonHorizontal.Name = "buttonHorizontal";
            buttonHorizontal.Size = new Size(88, 23);
            buttonHorizontal.TabIndex = 5;
            buttonHorizontal.Text = "TileHorizontal";
            buttonHorizontal.UseVisualStyleBackColor = true;
            buttonHorizontal.Click += buttonHorizontal_Click;
            // 
            // buttonCascade
            // 
            buttonCascade.Location = new Point(12, 128);
            buttonCascade.Name = "buttonCascade";
            buttonCascade.Size = new Size(88, 23);
            buttonCascade.TabIndex = 6;
            buttonCascade.Text = "Cascade";
            buttonCascade.UseVisualStyleBackColor = true;
            buttonCascade.Click += buttonCascade_Click;
            // 
            // Form72_73
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCascade);
            Controls.Add(buttonHorizontal);
            Controls.Add(buttonVertical);
            Controls.Add(buttonClose);
            Controls.Add(buttonNew);
            IsMdiContainer = true;
            Name = "Form72_73";
            Padding = new Padding(110, 0, 0, 0);
            Text = "Form72_73";
            Load += Form72_73_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNew;
        private Button buttonClose;
        private Button buttonVertical;
        private Button buttonHorizontal;
        private Button buttonCascade;
    }
}