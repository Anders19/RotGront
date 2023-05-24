namespace RotGront
{
    partial class RotoGrönt
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
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clearbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1273, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rot och Grönt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(50, 234);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(315, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 349);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1236, 419);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(65, 283);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(300, 50);
            this.clearbutton.TabIndex = 3;
            this.clearbutton.Text = "Rensa fält";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(498, 282);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(300, 50);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Spara inlägg";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(929, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(300, 50);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Radera inlägg";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(491, 168);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(315, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(491, 234);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(315, 20);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(50, 168);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(315, 20);
            this.IdTextBox.TabIndex = 9;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Grönsak",
            "Rotsak"});
            this.categoryBox.Location = new System.Drawing.Point(929, 168);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(315, 21);
            this.categoryBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Namn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Beskrivning";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(926, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Antal";
            // 
            // RotoGrönt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1297, 780);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "RotoGrönt";
            this.Text = "Rot & Grönt";
            this.Load += new System.EventHandler(this.RotoGrönt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

