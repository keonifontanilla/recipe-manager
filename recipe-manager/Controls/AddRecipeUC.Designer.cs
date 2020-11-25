
namespace recipe_manager.Controls
{
    partial class AddRecipeUC
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
            this.recipeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.instructionsListBox = new System.Windows.Forms.ListBox();
            this.addInstructionButton = new System.Windows.Forms.Button();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientsTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.recipeGroupBox = new System.Windows.Forms.GroupBox();
            this.instructionsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeInstuctionButton = new System.Windows.Forms.Button();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ingredientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            this.recipeGroupBox.SuspendLayout();
            this.instructionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeLabel.Location = new System.Drawing.Point(17, 29);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(54, 19);
            this.recipeLabel.TabIndex = 0;
            this.recipeLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(143, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(237, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(17, 59);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(91, 19);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(143, 58);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(237, 156);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(16, 26);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(93, 19);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "Instructions:";
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.Location = new System.Drawing.Point(142, 25);
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.Size = new System.Drawing.Size(237, 20);
            this.instructionsTextBox.TabIndex = 5;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(17, 224);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(47, 19);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(143, 224);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(237, 21);
            this.typeComboBox.TabIndex = 7;
            // 
            // instructionsListBox
            // 
            this.instructionsListBox.FormattingEnabled = true;
            this.instructionsListBox.Location = new System.Drawing.Point(20, 86);
            this.instructionsListBox.Name = "instructionsListBox";
            this.instructionsListBox.Size = new System.Drawing.Size(359, 446);
            this.instructionsListBox.TabIndex = 8;
            // 
            // addInstructionButton
            // 
            this.addInstructionButton.AutoSize = true;
            this.addInstructionButton.Location = new System.Drawing.Point(142, 54);
            this.addInstructionButton.Name = "addInstructionButton";
            this.addInstructionButton.Size = new System.Drawing.Size(88, 23);
            this.addInstructionButton.TabIndex = 9;
            this.addInstructionButton.Text = "Add Instruction";
            this.addInstructionButton.UseVisualStyleBackColor = true;
            this.addInstructionButton.Click += new System.EventHandler(this.addInstructionButton_Click);
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(17, 32);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(90, 19);
            this.ingredientsLabel.TabIndex = 10;
            this.ingredientsLabel.Text = "Ingredients:";
            // 
            // ingredientsTextBox
            // 
            this.ingredientsTextBox.Location = new System.Drawing.Point(142, 33);
            this.ingredientsTextBox.Name = "ingredientsTextBox";
            this.ingredientsTextBox.Size = new System.Drawing.Size(237, 20);
            this.ingredientsTextBox.TabIndex = 12;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(17, 69);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 19);
            this.quantityLabel.TabIndex = 13;
            this.quantityLabel.Text = "Quantity:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(247, 73);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(42, 19);
            this.unitLabel.TabIndex = 14;
            this.unitLabel.Text = "Unit:";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.AutoSize = true;
            this.addIngredientButton.Location = new System.Drawing.Point(21, 109);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(88, 23);
            this.addIngredientButton.TabIndex = 15;
            this.addIngredientButton.Text = "Add Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(142, 70);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(70, 20);
            this.quantityTextBox.TabIndex = 16;
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(309, 72);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(70, 20);
            this.unitTextBox.TabIndex = 17;
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.ingredientsDataGridView);
            this.ingredientsGroupBox.Controls.Add(this.removeIngredientButton);
            this.ingredientsGroupBox.Controls.Add(this.ingredientsLabel);
            this.ingredientsGroupBox.Controls.Add(this.unitTextBox);
            this.ingredientsGroupBox.Controls.Add(this.quantityTextBox);
            this.ingredientsGroupBox.Controls.Add(this.ingredientsTextBox);
            this.ingredientsGroupBox.Controls.Add(this.addIngredientButton);
            this.ingredientsGroupBox.Controls.Add(this.quantityLabel);
            this.ingredientsGroupBox.Controls.Add(this.unitLabel);
            this.ingredientsGroupBox.Location = new System.Drawing.Point(13, 282);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(398, 284);
            this.ingredientsGroupBox.TabIndex = 18;
            this.ingredientsGroupBox.TabStop = false;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AllowUserToAddRows = false;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(142, 109);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.ingredientsDataGridView.TabIndex = 19;
            this.ingredientsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredientsDataGridView_CellValueChanged);
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.AutoSize = true;
            this.removeIngredientButton.Location = new System.Drawing.Point(21, 147);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(107, 23);
            this.removeIngredientButton.TabIndex = 18;
            this.removeIngredientButton.Text = "Remove Ingredient";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // recipeGroupBox
            // 
            this.recipeGroupBox.Controls.Add(this.recipeLabel);
            this.recipeGroupBox.Controls.Add(this.nameTextBox);
            this.recipeGroupBox.Controls.Add(this.descriptionLabel);
            this.recipeGroupBox.Controls.Add(this.descriptionTextBox);
            this.recipeGroupBox.Controls.Add(this.typeComboBox);
            this.recipeGroupBox.Controls.Add(this.typeLabel);
            this.recipeGroupBox.Location = new System.Drawing.Point(13, 17);
            this.recipeGroupBox.Name = "recipeGroupBox";
            this.recipeGroupBox.Size = new System.Drawing.Size(398, 259);
            this.recipeGroupBox.TabIndex = 19;
            this.recipeGroupBox.TabStop = false;
            // 
            // instructionsGroupBox
            // 
            this.instructionsGroupBox.Controls.Add(this.removeInstuctionButton);
            this.instructionsGroupBox.Controls.Add(this.instructionsLabel);
            this.instructionsGroupBox.Controls.Add(this.instructionsTextBox);
            this.instructionsGroupBox.Controls.Add(this.addInstructionButton);
            this.instructionsGroupBox.Controls.Add(this.instructionsListBox);
            this.instructionsGroupBox.Location = new System.Drawing.Point(447, 17);
            this.instructionsGroupBox.Name = "instructionsGroupBox";
            this.instructionsGroupBox.Size = new System.Drawing.Size(396, 549);
            this.instructionsGroupBox.TabIndex = 19;
            this.instructionsGroupBox.TabStop = false;
            // 
            // removeInstuctionButton
            // 
            this.removeInstuctionButton.AutoSize = true;
            this.removeInstuctionButton.Location = new System.Drawing.Point(270, 54);
            this.removeInstuctionButton.Name = "removeInstuctionButton";
            this.removeInstuctionButton.Size = new System.Drawing.Size(109, 23);
            this.removeInstuctionButton.TabIndex = 10;
            this.removeInstuctionButton.Text = "Remove Instruction";
            this.removeInstuctionButton.UseVisualStyleBackColor = true;
            this.removeInstuctionButton.Click += new System.EventHandler(this.removeInstuctionButton_Click);
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.AutoSize = true;
            this.addRecipeButton.Location = new System.Drawing.Point(383, 572);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(88, 23);
            this.addRecipeButton.TabIndex = 18;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(799, 572);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(44, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AddRecipeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.instructionsGroupBox);
            this.Controls.Add(this.recipeGroupBox);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Name = "AddRecipeUC";
            this.Size = new System.Drawing.Size(878, 614);
            this.ingredientsGroupBox.ResumeLayout(false);
            this.ingredientsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            this.recipeGroupBox.ResumeLayout(false);
            this.recipeGroupBox.PerformLayout();
            this.instructionsGroupBox.ResumeLayout(false);
            this.instructionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ListBox instructionsListBox;
        private System.Windows.Forms.Button addInstructionButton;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.TextBox ingredientsTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.GroupBox recipeGroupBox;
        private System.Windows.Forms.GroupBox instructionsGroupBox;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.Button removeInstuctionButton;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.Button clearButton;
    }
}
