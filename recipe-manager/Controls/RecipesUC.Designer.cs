
namespace recipe_manager.Controls
{
    partial class RecipesUC
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
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Location = new System.Drawing.Point(28, 68);
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.ReadOnly = true;
            this.recipesDataGridView.Size = new System.Drawing.Size(825, 524);
            this.recipesDataGridView.TabIndex = 0;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(425, 28);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 19);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(504, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(349, 20);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
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
            this.viewPanel.TabIndex = 5;
            this.viewPanel.Visible = false;
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.instructionsTextBox.Location = new System.Drawing.Point(456, 48);
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.ReadOnly = true;
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
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(28, 28);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(109, 28);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(190, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Location = new System.Drawing.Point(271, 28);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(75, 23);
            this.favoriteButton.TabIndex = 8;
            this.favoriteButton.Text = "Favorite";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // RecipesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.recipesDataGridView);
            this.Name = "RecipesUC";
            this.Size = new System.Drawing.Size(878, 614);
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recipesDataGridView;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button favoriteButton;
    }
}
