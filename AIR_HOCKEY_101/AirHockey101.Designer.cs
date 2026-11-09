namespace AIR_HOCKEY_101
{
    partial class AirHockey101
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
            MainPictureBox = new PictureBox();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainPictureBox
            // 
            MainPictureBox.Location = new Point(12, 12);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(548, 426);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(667, 389);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(121, 49);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // AirHockey101
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(MainPictureBox);
            Name = "AirHockey101";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MainPictureBox;
        private Button ExitButton;
    }
}
