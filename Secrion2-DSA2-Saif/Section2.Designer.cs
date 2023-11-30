namespace Secrion2_DSA2_Saif
{
    partial class Section2
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
            this.components = new System.ComponentModel.Container();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.lstPath = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.StartCityBox = new System.Windows.Forms.ComboBox();
            this.EndCityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindPath
            // 
            this.btnFindPath.Location = new System.Drawing.Point(50, 150);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(150, 30);
            this.btnFindPath.TabIndex = 2;
            this.btnFindPath.Text = "Find Path";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click_1);
            // 
            // lstPath
            // 
            this.lstPath.FormattingEnabled = true;
            this.lstPath.ItemHeight = 16;
            this.lstPath.Location = new System.Drawing.Point(250, 50);
            this.lstPath.Name = "lstPath";
            this.lstPath.Size = new System.Drawing.Size(200, 116);
            this.lstPath.TabIndex = 3;
            // 
            // StartCityBox
            // 
            this.StartCityBox.FormattingEnabled = true;
            this.StartCityBox.Items.AddRange(new object[] {
            "Varna",
            "Burgas",
            "Dobrich",
            "Silistra",
            "Razgrad",
            "Tyrgowishte",
            "Shumen",
            "Veliko Trynovo",
            "Sliven",
            "Yambol",
            "Kazanlyk",
            "Stara Zagora"});
            this.StartCityBox.Location = new System.Drawing.Point(50, 50);
            this.StartCityBox.Name = "StartCityBox";
            this.StartCityBox.Size = new System.Drawing.Size(150, 24);
            this.StartCityBox.TabIndex = 4;
            // 
            // EndCityBox
            // 
            this.EndCityBox.FormattingEnabled = true;
            this.EndCityBox.Items.AddRange(new object[] {
            "Varna",
            "Burgas",
            "Dobrich",
            "Silistra",
            "Razgrad",
            "Tyrgowishte",
            "Shumen",
            "Veliko Trynovo",
            "Sliven",
            "Yambol",
            "Kazanlyk",
            "Stara Zagora"});
            this.EndCityBox.Location = new System.Drawing.Point(50, 104);
            this.EndCityBox.Name = "EndCityBox";
            this.EndCityBox.Size = new System.Drawing.Size(150, 24);
            this.EndCityBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Firebrick;
            this.Time.Location = new System.Drawing.Point(243, 195);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 18);
            this.Time.TabIndex = 9;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.ForeColor = System.Drawing.Color.Firebrick;
            this.Distance.Location = new System.Drawing.Point(243, 223);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(0, 18);
            this.Distance.TabIndex = 10;
            // 
            // Section2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 250);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndCityBox);
            this.Controls.Add(this.StartCityBox);
            this.Controls.Add(this.lstPath);
            this.Controls.Add(this.btnFindPath);
            this.MaximumSize = new System.Drawing.Size(700, 297);
            this.MinimumSize = new System.Drawing.Size(700, 297);
            this.Name = "Section2";
            this.Text = "City Path Finder";
            this.Load += new System.EventHandler(this.Section2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.ListBox lstPath;

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox StartCityBox;
        private System.Windows.Forms.ComboBox EndCityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Distance;
    }
}

