namespace SHAREPOINT_EXTRANET_CATALOG_MAKER
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.oldNameTextBox = new System.Windows.Forms.TextBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.oldNameLabel = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(22, 219);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(300, 53);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Location = new System.Drawing.Point(22, 16);
            this.chooseFolderButton.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(300, 42);
            this.chooseFolderButton.TabIndex = 1;
            this.chooseFolderButton.Text = "Choose path";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(20, 75);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(68, 13);
            this.chooseLabel.TabIndex = 2;
            this.chooseLabel.Text = "chooseLabel";
            // 
            // oldNameTextBox
            // 
            this.oldNameTextBox.Location = new System.Drawing.Point(135, 129);
            this.oldNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oldNameTextBox.Name = "oldNameTextBox";
            this.oldNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.oldNameTextBox.TabIndex = 3;
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(135, 171);
            this.newNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.newNameTextBox.TabIndex = 4;
            // 
            // oldNameLabel
            // 
            this.oldNameLabel.AutoSize = true;
            this.oldNameLabel.Location = new System.Drawing.Point(22, 132);
            this.oldNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldNameLabel.Name = "oldNameLabel";
            this.oldNameLabel.Size = new System.Drawing.Size(55, 13);
            this.oldNameLabel.TabIndex = 5;
            this.oldNameLabel.Text = "Old name:";
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(22, 175);
            this.newNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(61, 13);
            this.newNameLabel.TabIndex = 6;
            this.newNameLabel.Text = "New name:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.oldNameLabel);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.oldNameTextBox);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renaming directories from pattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.TextBox oldNameTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label oldNameLabel;
        private System.Windows.Forms.Label newNameLabel;
    }
}

