namespace Flight_Management
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.title = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Passenger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Flight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Display Passengers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Display flights ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // title
            // 
            this.title.ActiveControl = null;
            this.title.Location = new System.Drawing.Point(12, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(381, 61);
            this.title.TabIndex = 5;
            this.title.Text = "Home";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.title.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.title.UseSelectable = true;
            this.title.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 561);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private MetroFramework.Controls.MetroTile title;
    }
}