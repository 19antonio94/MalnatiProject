namespace MalnatiProject
{
    partial class Foto
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
            this.Invia = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Invia
            // 
            this.Invia.Location = new System.Drawing.Point(204, 215);
            this.Invia.Name = "Invia";
            this.Invia.Size = new System.Drawing.Size(75, 23);
            this.Invia.TabIndex = 0;
            this.Invia.Text = "Invia";
            this.Invia.UseVisualStyleBackColor = true;
            this.Invia.Click += new System.EventHandler(this.Invia_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(40, 215);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Invia);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Foto";
            this.Text = "Foto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Invia;
        private System.Windows.Forms.Button RefreshButton;
    }
}