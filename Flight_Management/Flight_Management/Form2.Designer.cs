namespace Flight_Management
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.passenger_name = new System.Windows.Forms.TextBox();
            this.passenger_phone = new System.Windows.Forms.TextBox();
            this.flight_number = new System.Windows.Forms.TextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "flight number";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(261, 410);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 60);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // passenger_name
            // 
            this.passenger_name.Location = new System.Drawing.Point(421, 140);
            this.passenger_name.Name = "passenger_name";
            this.passenger_name.Size = new System.Drawing.Size(279, 22);
            this.passenger_name.TabIndex = 5;
            // 
            // passenger_phone
            // 
            this.passenger_phone.Location = new System.Drawing.Point(421, 229);
            this.passenger_phone.Name = "passenger_phone";
            this.passenger_phone.Size = new System.Drawing.Size(279, 22);
            this.passenger_phone.TabIndex = 6;
            // 
            // flight_number
            // 
            this.flight_number.Location = new System.Drawing.Point(421, 321);
            this.flight_number.Name = "flight_number";
            this.flight_number.Size = new System.Drawing.Size(279, 22);
            this.flight_number.TabIndex = 7;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(24, 29);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(772, 70);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Passenger";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.flight_number);
            this.Controls.Add(this.passenger_phone);
            this.Controls.Add(this.passenger_name);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox passenger_name;
        private System.Windows.Forms.TextBox passenger_phone;
        private System.Windows.Forms.TextBox flight_number;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Button button1;
    }
}