
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeManagerForm));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.favoritesButton = new System.Windows.Forms.Button();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.categoriesSubPanel = new System.Windows.Forms.Panel();
            this.drinksSideButton = new System.Windows.Forms.Button();
            this.dessertsSideButton = new System.Windows.Forms.Button();
            this.sideDishesSideButton = new System.Windows.Forms.Button();
            this.mainSideButton = new System.Windows.Forms.Button();
            this.breakfastSideButton = new System.Windows.Forms.Button();
            this.allRecipesSideButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.drinksRecipeGroupBox = new System.Windows.Forms.GroupBox();
            this.drinksButton = new System.Windows.Forms.Button();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.dessertsRecipeGroupBox = new System.Windows.Forms.GroupBox();
            this.dessertsButton = new System.Windows.Forms.Button();
            this.dessertsLabel = new System.Windows.Forms.Label();
            this.sideRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.sideDishesButton = new System.Windows.Forms.Button();
            this.sideDishesLabel = new System.Windows.Forms.Label();
            this.mainRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.mainRecipesButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.breakfastRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.breakfastRecipesButton = new System.Windows.Forms.Button();
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.allRecipesGroupBox = new System.Windows.Forms.GroupBox();
            this.allRecipesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchAPIButton = new System.Windows.Forms.Button();
            this.sideBarPanel.SuspendLayout();
            this.categoriesSubPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.drinksRecipeGroupBox.SuspendLayout();
            this.dessertsRecipeGroupBox.SuspendLayout();
            this.sideRecipesGroupBox.SuspendLayout();
            this.mainRecipesGroupBox.SuspendLayout();
            this.breakfastRecipesGroupBox.SuspendLayout();
            this.allRecipesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.sideBarPanel.Controls.Add(this.searchAPIButton);
            this.sideBarPanel.Controls.Add(this.favoritesButton);
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
            // favoritesButton
            // 
            this.favoritesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.favoritesButton.FlatAppearance.BorderSize = 0;
            this.favoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritesButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritesButton.Location = new System.Drawing.Point(0, 492);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.favoritesButton.Size = new System.Drawing.Size(225, 60);
            this.favoritesButton.TabIndex = 5;
            this.favoritesButton.Text = "Favorites";
            this.favoritesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favoritesButton.UseVisualStyleBackColor = true;
            this.favoritesButton.Click += new System.EventHandler(this.recipesButton_Click);
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
            this.categoriesSubPanel.Controls.Add(this.sideDishesSideButton);
            this.categoriesSubPanel.Controls.Add(this.mainSideButton);
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
            // sideDishesSideButton
            // 
            this.sideDishesSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideDishesSideButton.FlatAppearance.BorderSize = 0;
            this.sideDishesSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideDishesSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideDishesSideButton.Location = new System.Drawing.Point(0, 69);
            this.sideDishesSideButton.Name = "sideDishesSideButton";
            this.sideDishesSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.sideDishesSideButton.Size = new System.Drawing.Size(225, 23);
            this.sideDishesSideButton.TabIndex = 8;
            this.sideDishesSideButton.Text = "Side Dishes";
            this.sideDishesSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideDishesSideButton.UseVisualStyleBackColor = true;
            this.sideDishesSideButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // mainSideButton
            // 
            this.mainSideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSideButton.FlatAppearance.BorderSize = 0;
            this.mainSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSideButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSideButton.Location = new System.Drawing.Point(0, 46);
            this.mainSideButton.Name = "mainSideButton";
            this.mainSideButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.mainSideButton.Size = new System.Drawing.Size(225, 23);
            this.mainSideButton.TabIndex = 7;
            this.mainSideButton.Text = "Main Course";
            this.mainSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainSideButton.UseVisualStyleBackColor = true;
            this.mainSideButton.Click += new System.EventHandler(this.recipesButton_Click);
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
            this.homePanel.Controls.Add(this.drinksRecipeGroupBox);
            this.homePanel.Controls.Add(this.dessertsRecipeGroupBox);
            this.homePanel.Controls.Add(this.sideRecipesGroupBox);
            this.homePanel.Controls.Add(this.mainRecipesGroupBox);
            this.homePanel.Controls.Add(this.breakfastRecipesGroupBox);
            this.homePanel.Controls.Add(this.allRecipesGroupBox);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(225, 35);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(878, 614);
            this.homePanel.TabIndex = 2;
            // 
            // drinksRecipeGroupBox
            // 
            this.drinksRecipeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.drinksRecipeGroupBox.Controls.Add(this.drinksButton);
            this.drinksRecipeGroupBox.Controls.Add(this.drinksLabel);
            this.drinksRecipeGroupBox.Location = new System.Drawing.Point(636, 346);
            this.drinksRecipeGroupBox.Name = "drinksRecipeGroupBox";
            this.drinksRecipeGroupBox.Size = new System.Drawing.Size(218, 178);
            this.drinksRecipeGroupBox.TabIndex = 5;
            this.drinksRecipeGroupBox.TabStop = false;
            // 
            // drinksButton
            // 
            this.drinksButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drinksButton.Location = new System.Drawing.Point(3, 8);
            this.drinksButton.Name = "drinksButton";
            this.drinksButton.Size = new System.Drawing.Size(212, 144);
            this.drinksButton.TabIndex = 0;
            this.drinksButton.UseVisualStyleBackColor = true;
            this.drinksButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // drinksLabel
            // 
            this.drinksLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drinksLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(3, 152);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(212, 23);
            this.drinksLabel.TabIndex = 5;
            this.drinksLabel.Text = "Drinks";
            this.drinksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dessertsRecipeGroupBox
            // 
            this.dessertsRecipeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dessertsRecipeGroupBox.Controls.Add(this.dessertsButton);
            this.dessertsRecipeGroupBox.Controls.Add(this.dessertsLabel);
            this.dessertsRecipeGroupBox.Location = new System.Drawing.Point(325, 346);
            this.dessertsRecipeGroupBox.Name = "dessertsRecipeGroupBox";
            this.dessertsRecipeGroupBox.Size = new System.Drawing.Size(218, 178);
            this.dessertsRecipeGroupBox.TabIndex = 4;
            this.dessertsRecipeGroupBox.TabStop = false;
            // 
            // dessertsButton
            // 
            this.dessertsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dessertsButton.Location = new System.Drawing.Point(3, 8);
            this.dessertsButton.Name = "dessertsButton";
            this.dessertsButton.Size = new System.Drawing.Size(212, 144);
            this.dessertsButton.TabIndex = 0;
            this.dessertsButton.UseVisualStyleBackColor = true;
            this.dessertsButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // dessertsLabel
            // 
            this.dessertsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dessertsLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertsLabel.Location = new System.Drawing.Point(3, 152);
            this.dessertsLabel.Name = "dessertsLabel";
            this.dessertsLabel.Size = new System.Drawing.Size(212, 23);
            this.dessertsLabel.TabIndex = 4;
            this.dessertsLabel.Text = "Desserts";
            this.dessertsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideRecipesGroupBox
            // 
            this.sideRecipesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.sideRecipesGroupBox.Controls.Add(this.sideDishesButton);
            this.sideRecipesGroupBox.Controls.Add(this.sideDishesLabel);
            this.sideRecipesGroupBox.Location = new System.Drawing.Point(6, 346);
            this.sideRecipesGroupBox.Name = "sideRecipesGroupBox";
            this.sideRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.sideRecipesGroupBox.TabIndex = 3;
            this.sideRecipesGroupBox.TabStop = false;
            // 
            // sideDishesButton
            // 
            this.sideDishesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sideDishesButton.Location = new System.Drawing.Point(3, 8);
            this.sideDishesButton.Name = "sideDishesButton";
            this.sideDishesButton.Size = new System.Drawing.Size(212, 144);
            this.sideDishesButton.TabIndex = 0;
            this.sideDishesButton.UseVisualStyleBackColor = true;
            this.sideDishesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // sideDishesLabel
            // 
            this.sideDishesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sideDishesLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideDishesLabel.Location = new System.Drawing.Point(3, 152);
            this.sideDishesLabel.Name = "sideDishesLabel";
            this.sideDishesLabel.Size = new System.Drawing.Size(212, 23);
            this.sideDishesLabel.TabIndex = 3;
            this.sideDishesLabel.Text = "Side Dishes";
            this.sideDishesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainRecipesGroupBox
            // 
            this.mainRecipesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.mainRecipesGroupBox.Controls.Add(this.mainRecipesButton);
            this.mainRecipesGroupBox.Controls.Add(this.mainLabel);
            this.mainRecipesGroupBox.Location = new System.Drawing.Point(636, 61);
            this.mainRecipesGroupBox.Name = "mainRecipesGroupBox";
            this.mainRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.mainRecipesGroupBox.TabIndex = 2;
            this.mainRecipesGroupBox.TabStop = false;
            // 
            // mainRecipesButton
            // 
            this.mainRecipesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainRecipesButton.Location = new System.Drawing.Point(3, 8);
            this.mainRecipesButton.Name = "mainRecipesButton";
            this.mainRecipesButton.Size = new System.Drawing.Size(212, 144);
            this.mainRecipesButton.TabIndex = 0;
            this.mainRecipesButton.UseVisualStyleBackColor = true;
            this.mainRecipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(3, 152);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(212, 23);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Main Course";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breakfastRecipesGroupBox
            // 
            this.breakfastRecipesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.breakfastRecipesGroupBox.Controls.Add(this.breakfastRecipesButton);
            this.breakfastRecipesGroupBox.Controls.Add(this.breakfastLabel);
            this.breakfastRecipesGroupBox.Location = new System.Drawing.Point(325, 61);
            this.breakfastRecipesGroupBox.Name = "breakfastRecipesGroupBox";
            this.breakfastRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.breakfastRecipesGroupBox.TabIndex = 1;
            this.breakfastRecipesGroupBox.TabStop = false;
            // 
            // breakfastRecipesButton
            // 
            this.breakfastRecipesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("breakfastRecipesButton.BackgroundImage")));
            this.breakfastRecipesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.breakfastRecipesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.breakfastRecipesButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastRecipesButton.Location = new System.Drawing.Point(3, 8);
            this.breakfastRecipesButton.Name = "breakfastRecipesButton";
            this.breakfastRecipesButton.Size = new System.Drawing.Size(212, 144);
            this.breakfastRecipesButton.TabIndex = 0;
            this.breakfastRecipesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.breakfastRecipesButton.UseVisualStyleBackColor = true;
            this.breakfastRecipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.breakfastLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastLabel.Location = new System.Drawing.Point(3, 152);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(212, 23);
            this.breakfastLabel.TabIndex = 1;
            this.breakfastLabel.Text = "Breakfast";
            this.breakfastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allRecipesGroupBox
            // 
            this.allRecipesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.allRecipesGroupBox.Controls.Add(this.allRecipesButton);
            this.allRecipesGroupBox.Controls.Add(this.label1);
            this.allRecipesGroupBox.Location = new System.Drawing.Point(6, 61);
            this.allRecipesGroupBox.Name = "allRecipesGroupBox";
            this.allRecipesGroupBox.Size = new System.Drawing.Size(218, 178);
            this.allRecipesGroupBox.TabIndex = 0;
            this.allRecipesGroupBox.TabStop = false;
            // 
            // allRecipesButton
            // 
            this.allRecipesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allRecipesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allRecipesButton.Location = new System.Drawing.Point(3, 8);
            this.allRecipesButton.Name = "allRecipesButton";
            this.allRecipesButton.Size = new System.Drawing.Size(212, 144);
            this.allRecipesButton.TabIndex = 0;
            this.allRecipesButton.UseVisualStyleBackColor = true;
            this.allRecipesButton.Click += new System.EventHandler(this.recipesButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Recipes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchAPIButton
            // 
            this.searchAPIButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchAPIButton.FlatAppearance.BorderSize = 0;
            this.searchAPIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAPIButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAPIButton.Location = new System.Drawing.Point(0, 552);
            this.searchAPIButton.Name = "searchAPIButton";
            this.searchAPIButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.searchAPIButton.Size = new System.Drawing.Size(225, 60);
            this.searchAPIButton.TabIndex = 6;
            this.searchAPIButton.Text = "Search API";
            this.searchAPIButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAPIButton.UseVisualStyleBackColor = true;
            this.searchAPIButton.Click += new System.EventHandler(this.searchAPIButton_Click);
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
            this.drinksRecipeGroupBox.ResumeLayout(false);
            this.dessertsRecipeGroupBox.ResumeLayout(false);
            this.sideRecipesGroupBox.ResumeLayout(false);
            this.mainRecipesGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox mainRecipesGroupBox;
        private System.Windows.Forms.Button mainRecipesButton;
        private System.Windows.Forms.GroupBox breakfastRecipesGroupBox;
        private System.Windows.Forms.Button breakfastRecipesButton;
        private System.Windows.Forms.GroupBox drinksRecipeGroupBox;
        private System.Windows.Forms.Button drinksButton;
        private System.Windows.Forms.GroupBox dessertsRecipeGroupBox;
        private System.Windows.Forms.Button dessertsButton;
        private System.Windows.Forms.GroupBox sideRecipesGroupBox;
        private System.Windows.Forms.Button sideDishesButton;
        private System.Windows.Forms.Panel categoriesSubPanel;
        private System.Windows.Forms.Button allRecipesSideButton;
        private System.Windows.Forms.Button drinksSideButton;
        private System.Windows.Forms.Button dessertsSideButton;
        private System.Windows.Forms.Button sideDishesSideButton;
        private System.Windows.Forms.Button mainSideButton;
        private System.Windows.Forms.Button breakfastSideButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label breakfastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label dessertsLabel;
        private System.Windows.Forms.Label sideDishesLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button favoritesButton;
        private System.Windows.Forms.Button searchAPIButton;
    }
}

