﻿
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
            this.categoriesSubPanel = new System.Windows.Forms.Panel();
            this.drinksSideButton = new System.Windows.Forms.Button();
            this.dessertsSideButton = new System.Windows.Forms.Button();
            this.dinnerSideButton = new System.Windows.Forms.Button();
            this.lunchSideButton = new System.Windows.Forms.Button();
            this.breakfastSideButton = new System.Windows.Forms.Button();
            this.allRecipesSideButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drinksButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dessertsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dinnerButton = new System.Windows.Forms.Button();
            this.lunchRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.lunchRecipesButton = new System.Windows.Forms.Button();
            this.breakfastRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.breakfastRecipesButton = new System.Windows.Forms.Button();
            this.allRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.allRecipesButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sideBarPanel.SuspendLayout();
            this.categoriesSubPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lunchRecipesGroupBox.SuspendLayout();
            this.breakfastRecipesGroupBox.SuspendLayout();
            this.allRecipesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.sideBarPanel.Controls.Add(this.addRecipeButton);
            this.sideBarPanel.Controls.Add(this.categoriesSubPanel);
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
            this.addRecipeButton.Location = new System.Drawing.Point(0, 432);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.addRecipeButton.Size = new System.Drawing.Size(225, 60);
            this.addRecipeButton.TabIndex = 2;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // categoriesSubPanel
            // 
            this.categoriesSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.categoriesSubPanel.Controls.Add(this.drinksSideButton);
            this.categoriesSubPanel.Controls.Add(this.dessertsSideButton);
            this.categoriesSubPanel.Controls.Add(this.dinnerSideButton);
            this.categoriesSubPanel.Controls.Add(this.lunchSideButton);
            this.categoriesSubPanel.Controls.Add(this.breakfastSideButton);
            this.categoriesSubPanel.Controls.Add(this.allRecipesSideButton);
            this.categoriesSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesSubPanel.Location = new System.Drawing.Point(0, 288);
            this.categoriesSubPanel.Name = "categoriesSubPanel";
            this.categoriesSubPanel.Size = new System.Drawing.Size(225, 144);
            this.categoriesSubPanel.TabIndex = 4;
            this.categoriesSubPanel.Visible = false;
            // 
            // drinksSideButton
            // 
            this.drinksSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.drinksSideButton.FlatAppearance.BorderSize = 0;
            this.drinksSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinksSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksSideButton.Location = new System.Drawing.Point(0, 115);
            this.drinksSideButton.Name = "drinksSideButton";
            this.drinksSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.drinksSideButton.Size = new System.Drawing.Size(225, 23);
            this.drinksSideButton.TabIndex = 10;
            this.drinksSideButton.Text = "Drinks";
            this.drinksSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drinksSideButton.UseVisualStyleBackColor = true;
            this.drinksSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // dessertsSideButton
            // 
            this.dessertsSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dessertsSideButton.FlatAppearance.BorderSize = 0;
            this.dessertsSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessertsSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertsSideButton.Location = new System.Drawing.Point(0, 92);
            this.dessertsSideButton.Name = "dessertsSideButton";
            this.dessertsSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dessertsSideButton.Size = new System.Drawing.Size(225, 23);
            this.dessertsSideButton.TabIndex = 9;
            this.dessertsSideButton.Text = "Desserts";
            this.dessertsSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dessertsSideButton.UseVisualStyleBackColor = true;
            this.dessertsSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // dinnerSideButton
            // 
            this.dinnerSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dinnerSideButton.FlatAppearance.BorderSize = 0;
            this.dinnerSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinnerSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerSideButton.Location = new System.Drawing.Point(0, 69);
            this.dinnerSideButton.Name = "dinnerSideButton";
            this.dinnerSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dinnerSideButton.Size = new System.Drawing.Size(225, 23);
            this.dinnerSideButton.TabIndex = 8;
            this.dinnerSideButton.Text = "Dinner";
            this.dinnerSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dinnerSideButton.UseVisualStyleBackColor = true;
            this.dinnerSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // lunchSideButton
            // 
            this.lunchSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lunchSideButton.FlatAppearance.BorderSize = 0;
            this.lunchSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchSideButton.Location = new System.Drawing.Point(0, 46);
            this.lunchSideButton.Name = "lunchSideButton";
            this.lunchSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lunchSideButton.Size = new System.Drawing.Size(225, 23);
            this.lunchSideButton.TabIndex = 7;
            this.lunchSideButton.Text = "Lunch";
            this.lunchSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lunchSideButton.UseVisualStyleBackColor = true;
            this.lunchSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // breakfastSideButton
            // 
            this.breakfastSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.breakfastSideButton.FlatAppearance.BorderSize = 0;
            this.breakfastSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.breakfastSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastSideButton.Location = new System.Drawing.Point(0, 23);
            this.breakfastSideButton.Name = "breakfastSideButton";
            this.breakfastSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.breakfastSideButton.Size = new System.Drawing.Size(225, 23);
            this.breakfastSideButton.TabIndex = 6;
            this.breakfastSideButton.Text = "Breakfast";
            this.breakfastSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.breakfastSideButton.UseVisualStyleBackColor = true;
            this.breakfastSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // allRecipesSideButton
            // 
            this.allRecipesSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allRecipesSideButton.FlatAppearance.BorderSize = 0;
            this.allRecipesSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allRecipesSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRecipesSideButton.Location = new System.Drawing.Point(0, 0);
            this.allRecipesSideButton.Name = "allRecipesSideButton";
            this.allRecipesSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.allRecipesSideButton.Size = new System.Drawing.Size(225, 23);
            this.allRecipesSideButton.TabIndex = 5;
            this.allRecipesSideButton.Text = "All Recipes";
            this.allRecipesSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allRecipesSideButton.UseVisualStyleBackColor = true;
            this.allRecipesSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesButton.Location = new System.Drawing.Point(0, 228);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.categoriesButton.Size = new System.Drawing.Size(225, 60);
            this.categoriesButton.TabIndex = 3;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(0, 168);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(225, 60);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
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
            this.homePanel.AutoScroll = true;
            this.homePanel.Controls.Add(this.groupBox3);
            this.homePanel.Controls.Add(this.groupBox2);
            this.homePanel.Controls.Add(this.groupBox1);
            this.homePanel.Controls.Add(this.lunchRecipesGroupBox);
            this.homePanel.Controls.Add(this.breakfastRecipesGroupBox);
            this.homePanel.Controls.Add(this.allRecipesGroupBox);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(225, 35);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(878, 614);
            this.homePanel.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drinksButton);
            this.groupBox3.Location = new System.Drawing.Point(636, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 178);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // drinksButton
            // 
            this.drinksButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drinksButton.Location = new System.Drawing.Point(3, 152);
            this.drinksButton.Name = "drinksButton";
            this.drinksButton.Size = new System.Drawing.Size(212, 23);
            this.drinksButton.TabIndex = 0;
            this.drinksButton.Text = "Drinks";
            this.drinksButton.UseVisualStyleBackColor = true;
            this.drinksButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dessertsButton);
            this.groupBox2.Location = new System.Drawing.Point(325, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dessertsButton
            // 
            this.dessertsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dessertsButton.Location = new System.Drawing.Point(3, 152);
            this.dessertsButton.Name = "dessertsButton";
            this.dessertsButton.Size = new System.Drawing.Size(212, 23);
            this.dessertsButton.TabIndex = 0;
            this.dessertsButton.Text = "Desserts";
            this.dessertsButton.UseVisualStyleBackColor = true;
            this.dessertsButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dinnerButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dinnerButton
            // 
            this.dinnerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dinnerButton.Location = new System.Drawing.Point(3, 152);
            this.dinnerButton.Name = "dinnerButton";
            this.dinnerButton.Size = new System.Drawing.Size(212, 23);
            this.dinnerButton.TabIndex = 0;
            this.dinnerButton.Text = "Dinner";
            this.dinnerButton.UseVisualStyleBackColor = true;
            this.dinnerButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // lunchRecipesGroupBox
            // 
            this.lunchRecipesGroupBox.Controls.Add(this.lunchRecipesButton);
            this.lunchRecipesGroupBox.Location = new System.Drawing.Point(636, 61);
            this.lunchRecipesGroupBox.Name = "lunchRecipesGroupBox";
            this.lunchRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.lunchRecipesGroupBox.TabIndex = 2;
            this.lunchRecipesGroupBox.TabStop = false;
            // 
            // lunchRecipesButton
            // 
            this.lunchRecipesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lunchRecipesButton.Location = new System.Drawing.Point(3, 152);
            this.lunchRecipesButton.Name = "lunchRecipesButton";
            this.lunchRecipesButton.Size = new System.Drawing.Size(212, 23);
            this.lunchRecipesButton.TabIndex = 0;
            this.lunchRecipesButton.Text = "Lunch";
            this.lunchRecipesButton.UseVisualStyleBackColor = true;
            this.lunchRecipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // breakfastRecipesGroupBox
            // 
            this.breakfastRecipesGroupBox.Controls.Add(this.breakfastRecipesButton);
            this.breakfastRecipesGroupBox.Location = new System.Drawing.Point(325, 61);
            this.breakfastRecipesGroupBox.Name = "breakfastRecipesGroupBox";
            this.breakfastRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.breakfastRecipesGroupBox.TabIndex = 1;
            this.breakfastRecipesGroupBox.TabStop = false;
            // 
            // breakfastRecipesButton
            // 
            this.breakfastRecipesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.breakfastRecipesButton.Location = new System.Drawing.Point(3, 152);
            this.breakfastRecipesButton.Name = "breakfastRecipesButton";
            this.breakfastRecipesButton.Size = new System.Drawing.Size(212, 23);
            this.breakfastRecipesButton.TabIndex = 0;
            this.breakfastRecipesButton.Text = "Breakfast";
            this.breakfastRecipesButton.UseVisualStyleBackColor = true;
            this.breakfastRecipesButton.Click += new System.EventHandler(this.recipesButton_Click);
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
            this.allRecipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(225, 168);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Recipes";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.categoriesSubPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.lunchRecipesGroupBox.ResumeLayout(false);
            this.breakfastRecipesGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox lunchRecipesGroupBox;
        private System.Windows.Forms.Button lunchRecipesButton;
        private System.Windows.Forms.GroupBox breakfastRecipesGroupBox;
        private System.Windows.Forms.Button breakfastRecipesButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button drinksButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dessertsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dinnerButton;
        private System.Windows.Forms.Panel categoriesSubPanel;
        private System.Windows.Forms.Button allRecipesSideButton;
        private System.Windows.Forms.Button drinksSideButton;
        private System.Windows.Forms.Button dessertsSideButton;
        private System.Windows.Forms.Button dinnerSideButton;
        private System.Windows.Forms.Button lunchSideButton;
        private System.Windows.Forms.Button breakfastSideButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

