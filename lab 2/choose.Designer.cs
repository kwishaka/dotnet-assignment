namespace lab_2
{
    partial class choose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button bicycleButton;
        private System.Windows.Forms.Button mechanicButton;
        private System.Windows.Forms.Button logoutButton;

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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.bicycleButton = new System.Windows.Forms.Button();
            this.mechanicButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(130, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(206, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Choose a Service";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(115, 100);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(154, 13);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "What would you like help with?";
            // 
            // bicycleButton
            // 
            this.bicycleButton.Location = new System.Drawing.Point(75, 145);
            this.bicycleButton.Name = "bicycleButton";
            this.bicycleButton.Size = new System.Drawing.Size(130, 45);
            this.bicycleButton.TabIndex = 2;
            this.bicycleButton.Text = "Bicycle";
            this.bicycleButton.UseVisualStyleBackColor = true;
            this.bicycleButton.Click += new System.EventHandler(this.bicycleButton_Click);
            // 
            // mechanicButton
            // 
            this.mechanicButton.Location = new System.Drawing.Point(230, 145);
            this.mechanicButton.Name = "mechanicButton";
            this.mechanicButton.Size = new System.Drawing.Size(130, 45);
            this.mechanicButton.TabIndex = 3;
            this.mechanicButton.Text = "mash";
            this.mechanicButton.UseVisualStyleBackColor = true;
            this.mechanicButton.Click += new System.EventHandler(this.mechanicButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(165, 225);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(105, 30);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 310);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mechanicButton);
            this.Controls.Add(this.bicycleButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}