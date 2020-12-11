
namespace recipe_manager.Controls
{
    partial class ApiRecipeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.apiRecipesDataGridView = new System.Windows.Forms.DataGridView();
            this.apiSearchTextBox = new System.Windows.Forms.TextBox();
            this.apiSearchButton = new System.Windows.Forms.Button();
            this.apiViewButton = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apiRecipesDataGridView)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiRecipesDataGridView
            // 
            this.apiRecipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apiRecipesDataGridView.Location = new System.Drawing.Point(28, 68);
            this.apiRecipesDataGridView.Name = "apiRecipesDataGridView";
            this.apiRecipesDataGridView.ReadOnly = true;
            this.apiRecipesDataGridView.Size = new System.Drawing.Size(825, 524);
            this.apiRecipesDataGridView.TabIndex = 0;
            // 
            // apiSearchTextBox
            // 
            this.apiSearchTextBox.Location = new System.Drawing.Point(28, 31);
            this.apiSearchTextBox.Name = "apiSearchTextBox";
            this.apiSearchTextBox.Size = new System.Drawing.Size(349, 20);
            this.apiSearchTextBox.TabIndex = 5;
            // 
            // apiSearchButton
            // 
            this.apiSearchButton.Location = new System.Drawing.Point(383, 30);
            this.apiSearchButton.Name = "apiSearchButton";
            this.apiSearchButton.Size = new System.Drawing.Size(67, 21);
            this.apiSearchButton.TabIndex = 6;
            this.apiSearchButton.Text = "Search";
            this.apiSearchButton.UseVisualStyleBackColor = true;
            this.apiSearchButton.Click += new System.EventHandler(this.apiSearchButton_Click);
            // 
            // apiViewButton
            // 
            this.apiViewButton.Location = new System.Drawing.Point(786, 30);
            this.apiViewButton.Name = "apiViewButton";
            this.apiViewButton.Size = new System.Drawing.Size(67, 21);
            this.apiViewButton.TabIndex = 7;
            this.apiViewButton.Text = "View";
            this.apiViewButton.UseVisualStyleBackColor = true;
            this.apiViewButton.Click += new System.EventHandler(this.apiViewButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.instructionsTextBox);
            this.viewPanel.Controls.Add(this.instructionsLabel);
            this.viewPanel.Controls.Add(this.ingredientsTextBox);
            this.viewPanel.Controls.Add(this.ingredientsLabel);
            this.viewPanel.Controls.Add(this.typeLabel);
            this.viewPanel.Controls.Add(this.descriptionLabel);
            this.viewPanel.Controls.Add(this.descriptionTextBox);
            this.viewPanel.Controls.Add(this.nameLabel);
            this.viewPanel.Location = new System.Drawing.Point(28, 68);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(825, 524);
            this.viewPanel.TabIndex = 8;
            this.viewPanel.Visible = false;
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.instructionsTextBox.Location = new System.Drawing.Point(456, 48);
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.ReadOnly = true;
            this.instructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionsTextBox.Size = new System.Drawing.Size(363, 465);
            this.instructionsTextBox.TabIndex = 14;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(452, 26);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(112, 22);
            this.instructionsLabel.TabIndex = 13;
            this.instructionsLabel.Text = "Instructions:";
            // 
            // ingredientsTextBox
            // 
            this.ingredientsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ingredientsTextBox.Location = new System.Drawing.Point(8, 278);
            this.ingredientsTextBox.Multiline = true;
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.ReadOnly = true;
            this.ingredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientsTextBox.Size = new System.Drawing.Size(363, 201);
            this.ingredientsTextBox.TabIndex = 12;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(5, 256);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(107, 22);
            this.ingredientsLabel.TabIndex = 11;
            this.ingredientsLabel.Text = "Ingredients:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(4, 494);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(116, 22);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type: <type>";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(4, 26);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(109, 22);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(8, 48);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(363, 188);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(825, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: <name>";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApiRecipeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.apiViewButton);
            this.Controls.Add(this.apiSearchButton);
            this.Controls.Add(this.apiSearchTextBox);
            this.Controls.Add(this.apiRecipesDataGridView);
            this.Name = "ApiRecipeUC";
            this.Size = new System.Drawing.Size(878, 614);
            ((System.ComponentModel.ISupportInitialize)(this.apiRecipesDataGridView)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apiRecipesDataGridView;
        private System.Windows.Forms.TextBox apiSearchTextBox;
        private System.Windows.Forms.Button apiSearchButton;
        private System.Windows.Forms.Button apiViewButton;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}
