
namespace Cluedo
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cardTypesCountTextBox = new System.Windows.Forms.TextBox();
            this.cardTypesCountButton = new System.Windows.Forms.Button();
            this.nameOfCardTypeLabel = new System.Windows.Forms.Label();
            this.cardTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.cardTypeNameButton = new System.Windows.Forms.Button();
            this.typeCountButton = new System.Windows.Forms.Button();
            this.typeCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(126, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сколько мастей(видов карт) в игре?";
            // 
            // cardTypesCountTextBox
            // 
            this.cardTypesCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypesCountTextBox.Location = new System.Drawing.Point(250, 106);
            this.cardTypesCountTextBox.Name = "cardTypesCountTextBox";
            this.cardTypesCountTextBox.Size = new System.Drawing.Size(153, 36);
            this.cardTypesCountTextBox.TabIndex = 1;
            this.cardTypesCountTextBox.Text = "От 0 до 10";
            // 
            // cardTypesCountButton
            // 
            this.cardTypesCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypesCountButton.Location = new System.Drawing.Point(483, 106);
            this.cardTypesCountButton.Name = "cardTypesCountButton";
            this.cardTypesCountButton.Size = new System.Drawing.Size(111, 36);
            this.cardTypesCountButton.TabIndex = 2;
            this.cardTypesCountButton.Text = "Enter";
            this.cardTypesCountButton.UseVisualStyleBackColor = true;
            this.cardTypesCountButton.Click += new System.EventHandler(this.cardTypesCountButton_Click);
            // 
            // nameOfCardTypeLabel
            // 
            this.nameOfCardTypeLabel.AutoSize = true;
            this.nameOfCardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nameOfCardTypeLabel.Location = new System.Drawing.Point(244, 175);
            this.nameOfCardTypeLabel.Name = "nameOfCardTypeLabel";
            this.nameOfCardTypeLabel.Size = new System.Drawing.Size(320, 36);
            this.nameOfCardTypeLabel.TabIndex = 3;
            this.nameOfCardTypeLabel.Text = "Название n-ой карты";
            this.nameOfCardTypeLabel.Visible = false;
            // 
            // cardTypeNameTextBox
            // 
            this.cardTypeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypeNameTextBox.Location = new System.Drawing.Point(250, 233);
            this.cardTypeNameTextBox.Name = "cardTypeNameTextBox";
            this.cardTypeNameTextBox.Size = new System.Drawing.Size(153, 36);
            this.cardTypeNameTextBox.TabIndex = 4;
            this.cardTypeNameTextBox.Text = "Название";
            this.cardTypeNameTextBox.Visible = false;
            // 
            // cardTypeNameButton
            // 
            this.cardTypeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cardTypeNameButton.Location = new System.Drawing.Point(483, 233);
            this.cardTypeNameButton.Name = "cardTypeNameButton";
            this.cardTypeNameButton.Size = new System.Drawing.Size(111, 36);
            this.cardTypeNameButton.TabIndex = 5;
            this.cardTypeNameButton.Text = "Enter";
            this.cardTypeNameButton.UseVisualStyleBackColor = true;
            this.cardTypeNameButton.Visible = false;
            this.cardTypeNameButton.Click += new System.EventHandler(this.cardTypeNameButton_Click);
            // 
            // typeCountButton
            // 
            this.typeCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.typeCountButton.Location = new System.Drawing.Point(483, 292);
            this.typeCountButton.Name = "typeCountButton";
            this.typeCountButton.Size = new System.Drawing.Size(111, 36);
            this.typeCountButton.TabIndex = 7;
            this.typeCountButton.Text = "Enter";
            this.typeCountButton.UseVisualStyleBackColor = true;
            this.typeCountButton.Visible = false;
            this.typeCountButton.Click += new System.EventHandler(this.typeCountButton_Click);
            // 
            // typeCountTextBox
            // 
            this.typeCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.typeCountTextBox.Location = new System.Drawing.Point(250, 292);
            this.typeCountTextBox.Name = "typeCountTextBox";
            this.typeCountTextBox.Size = new System.Drawing.Size(153, 36);
            this.typeCountTextBox.TabIndex = 6;
            this.typeCountTextBox.Text = "Кол-во карт этой масти?";
            this.typeCountTextBox.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typeCountButton);
            this.Controls.Add(this.typeCountTextBox);
            this.Controls.Add(this.cardTypeNameButton);
            this.Controls.Add(this.cardTypeNameTextBox);
            this.Controls.Add(this.nameOfCardTypeLabel);
            this.Controls.Add(this.cardTypesCountButton);
            this.Controls.Add(this.cardTypesCountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cardTypesCountTextBox;
        private System.Windows.Forms.Button cardTypesCountButton;
        private System.Windows.Forms.Label nameOfCardTypeLabel;
        private System.Windows.Forms.TextBox cardTypeNameTextBox;
        private System.Windows.Forms.Button cardTypeNameButton;
        private System.Windows.Forms.Button typeCountButton;
        private System.Windows.Forms.TextBox typeCountTextBox;
    }
}