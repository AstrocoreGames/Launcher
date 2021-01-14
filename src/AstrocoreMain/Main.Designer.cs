namespace AstrocoreMain
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Choices = new System.Windows.Forms.Label();
            this.ChoicesPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choices
            // 
            this.Choices.AutoSize = true;
            this.Choices.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choices.Location = new System.Drawing.Point(44, 9);
            this.Choices.Name = "Choices";
            this.Choices.Size = new System.Drawing.Size(132, 37);
            this.Choices.TabIndex = 0;
            this.Choices.Text = "Choices";
            // 
            // ChoicesPlay
            // 
            this.ChoicesPlay.Location = new System.Drawing.Point(51, 66);
            this.ChoicesPlay.Name = "ChoicesPlay";
            this.ChoicesPlay.Size = new System.Drawing.Size(125, 49);
            this.ChoicesPlay.TabIndex = 1;
            this.ChoicesPlay.Text = "Play";
            this.ChoicesPlay.UseVisualStyleBackColor = true;
            this.ChoicesPlay.Click += new System.EventHandler(this.ChoicesPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 126);
            this.Controls.Add(this.ChoicesPlay);
            this.Controls.Add(this.Choices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Astrocore Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Choices;
        private System.Windows.Forms.Button ChoicesPlay;
    }
}

