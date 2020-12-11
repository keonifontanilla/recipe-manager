
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
            ((System.ComponentModel.ISupportInitialize)(this.apiRecipesDataGridView)).BeginInit();
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
            // ApiRecipeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apiSearchButton);
            this.Controls.Add(this.apiSearchTextBox);
            this.Controls.Add(this.apiRecipesDataGridView);
            this.Name = "ApiRecipeUC";
            this.Size = new System.Drawing.Size(878, 614);
            ((System.ComponentModel.ISupportInitialize)(this.apiRecipesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apiRecipesDataGridView;
        private System.Windows.Forms.TextBox apiSearchTextBox;
        private System.Windows.Forms.Button apiSearchButton;
    }
}
