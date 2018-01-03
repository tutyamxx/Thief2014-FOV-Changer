namespace Thief__2014__FOV_Changer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.fov_Bar = new System.Windows.Forms.TrackBar();
            this.lbl_FOV = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_NewFov = new System.Windows.Forms.Label();
            this.lbl_Info1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Info2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fov_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("GeForce", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change FOV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fov_Bar
            // 
            this.fov_Bar.Location = new System.Drawing.Point(12, 201);
            this.fov_Bar.Maximum = 150;
            this.fov_Bar.Minimum = 40;
            this.fov_Bar.Name = "fov_Bar";
            this.fov_Bar.Size = new System.Drawing.Size(234, 45);
            this.fov_Bar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.fov_Bar, "Your current FOV value");
            this.fov_Bar.Value = 50;
            this.fov_Bar.Scroll += new System.EventHandler(this.fov_Bar_Scroll);
            // 
            // lbl_FOV
            // 
            this.lbl_FOV.AutoSize = true;
            this.lbl_FOV.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FOV.Location = new System.Drawing.Point(69, 167);
            this.lbl_FOV.Name = "lbl_FOV";
            this.lbl_FOV.Size = new System.Drawing.Size(116, 13);
            this.lbl_FOV.TabIndex = 2;
            this.lbl_FOV.Text = "Field of View (FOV)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thief__2014__FOV_Changer.Properties.Resources.thief;
            this.pictureBox1.Location = new System.Drawing.Point(41, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Info.Location = new System.Drawing.Point(21, 249);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(197, 13);
            this.lbl_Info.TabIndex = 4;
            this.lbl_Info.Text = "    It will add to the 90° base FOV";
            // 
            // lbl_NewFov
            // 
            this.lbl_NewFov.AutoSize = true;
            this.lbl_NewFov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewFov.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_NewFov.Location = new System.Drawing.Point(69, 272);
            this.lbl_NewFov.Name = "lbl_NewFov";
            this.lbl_NewFov.Size = new System.Drawing.Size(104, 13);
            this.lbl_NewFov.TabIndex = 5;
            this.lbl_NewFov.Text = "New FOV will be:";
            // 
            // lbl_Info1
            // 
            this.lbl_Info1.AutoSize = true;
            this.lbl_Info1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info1.Location = new System.Drawing.Point(44, 127);
            this.lbl_Info1.Name = "lbl_Info1";
            this.lbl_Info1.Size = new System.Drawing.Size(165, 13);
            this.lbl_Info1.TabIndex = 6;
            this.lbl_Info1.Text = "-=[ Surpass the 110 FOV Limit! ]=-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Thief__2014__FOV_Changer.Properties.Resources.gitcat;
            this.pictureBox2.Location = new System.Drawing.Point(213, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Go to my GitHub page!");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_Info2
            // 
            this.lbl_Info2.AutoSize = true;
            this.lbl_Info2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info2.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Info2.Location = new System.Drawing.Point(21, 140);
            this.lbl_Info2.Name = "lbl_Info2";
            this.lbl_Info2.Size = new System.Drawing.Size(225, 13);
            this.lbl_Info2.TabIndex = 8;
            this.lbl_Info2.Text = "Might not work for multi-monitor configurations!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(258, 358);
            this.Controls.Add(this.lbl_Info2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Info1);
            this.Controls.Add(this.lbl_NewFov);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_FOV);
            this.Controls.Add(this.fov_Bar);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thief (2014) FOV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fov_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar fov_Bar;
        private System.Windows.Forms.Label lbl_FOV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_NewFov;
        private System.Windows.Forms.Label lbl_Info1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Info2;
    }
}

