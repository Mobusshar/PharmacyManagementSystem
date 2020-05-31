namespace Pharmacy_Management_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.Exitbtn1 = new System.Windows.Forms.Button();
            this.mitonmoyDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitonmoyDbDataSet = new Pharmacy_Management_System.MitonmoyDbDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mitonmoyDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitonmoyDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(0, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exitbtn1
            // 
            this.Exitbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exitbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exitbtn1.ForeColor = System.Drawing.Color.White;
            this.Exitbtn1.Location = new System.Drawing.Point(0, 330);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Size = new System.Drawing.Size(102, 38);
            this.Exitbtn1.TabIndex = 2;
            this.Exitbtn1.Text = "Exit";
            this.Exitbtn1.UseVisualStyleBackColor = false;
            this.Exitbtn1.Click += new System.EventHandler(this.button2_Click);
            // 
            // mitonmoyDbDataSetBindingSource
            // 
            this.mitonmoyDbDataSetBindingSource.DataSource = this.mitonmoyDbDataSet;
            this.mitonmoyDbDataSetBindingSource.Position = 0;
            // 
            // mitonmoyDbDataSet
            // 
            this.mitonmoyDbDataSet.DataSetName = "MitonmoyDbDataSet";
            this.mitonmoyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(108, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 349);
            this.button2.TabIndex = 3;
            this.button2.Text = "FOR ADMIN BASED WORK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(370, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 349);
            this.button3.TabIndex = 4;
            this.button3.Text = "FOR PRODUCT BASED WORK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Exitbtn1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 392);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 80);
            this.panel2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mitonmoyDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitonmoyDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exitbtn1;
        private System.Windows.Forms.BindingSource mitonmoyDbDataSetBindingSource;
        private MitonmoyDbDataSet mitonmoyDbDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}