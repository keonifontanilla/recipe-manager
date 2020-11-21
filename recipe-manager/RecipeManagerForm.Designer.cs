
namespace recipe_manager
{
    partial class RecipeManagerForm
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
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.allRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.allRecipesButton = new System.Windows.Forms.Button();
            this.sideBarPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.allRecipesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.sideBarPanel.Controls.Add(this.addRecipeButton);
            this.sideBarPanel.Controls.Add(this.categoriesButton);
            this.sideBarPanel.Controls.Add(this.homeButton);
            this.sideBarPanel.Controls.Add(this.titlePanel);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(225, 649);
            this.sideBarPanel.TabIndex = 0;
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRecipeButton.FlatAppearance.BorderSize = 0;
            this.addRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecipeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipeButton.Location = new System.Drawing.Point(0, 322);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(225, 77);
            this.addRecipeButton.TabIndex = 2;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesButton.Location = new System.Drawing.Point(0, 245);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(225, 77);
            this.categoriesButton.TabIndex = 3;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(0, 168);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(225, 77);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(225, 168);
            this.titlePanel.TabIndex = 1;
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.LightGray;
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(225, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(878, 35);
            this.topBarPanel.TabIndex = 1;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.allRecipesGroupBox);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(225, 35);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(878, 614);
            this.homePanel.TabIndex = 2;
            // 
            // allRecipesGroupBox
            // 
            this.allRecipesGroupBox.Controls.Add(this.allRecipesButton);
            this.allRecipesGroupBox.Location = new System.Drawing.Point(6, 61);
            this.allRecipesGroupBox.Name = "allRecipesGroupBox";
            this.allRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.allRecipesGroupBox.TabIndex = 0;
            this.allRecipesGroupBox.TabStop = false;
            // 
            // allRecipesButton
            // 
            this.allRecipesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allRecipesButton.Location = new System.Drawing.Point(3, 152);
            this.allRecipesButton.Name = "allRecipesButton";
            this.allRecipesButton.Size = new System.Drawing.Size(212, 23);
            this.allRecipesButton.TabIndex = 0;
            this.allRecipesButton.Text = "All Recipes";
            this.allRecipesButton.UseVisualStyleBackColor = true;
            this.allRecipesButton.Click += new System.EventHandler(this.allRecipesButton_Click);
            // 
            // RecipeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 649);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.sideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecipeManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Manager";
            this.sideBarPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.allRecipesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.GroupBox allRecipesGroupBox;
        private System.Windows.Forms.Button allRecipesButton;
        private System.Windows.Forms.Button categoriesButton;
    }
}

