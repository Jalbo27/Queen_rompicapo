namespace Queen_rompicapo
{
    partial class Rompicapo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rompicapo));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Regina1 = new System.Windows.Forms.Label();
            this.Regina2 = new System.Windows.Forms.Label();
            this.Regina3 = new System.Windows.Forms.Label();
            this.Regina4 = new System.Windows.Forms.Label();
            this.Regina5 = new System.Windows.Forms.Label();
            this.Regina6 = new System.Windows.Forms.Label();
            this.Regina7 = new System.Windows.Forms.Label();
            this.Regina8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "regina.png");
            this.imageList1.Images.SetKeyName(1, "beige.jpg");
            this.imageList1.Images.SetKeyName(2, "nero.jpg");
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Regina1
            // 
            resources.ApplyResources(this.Regina1, "Regina1");
            this.Regina1.Name = "Regina1";
            // 
            // Regina2
            // 
            resources.ApplyResources(this.Regina2, "Regina2");
            this.Regina2.Name = "Regina2";
            // 
            // Regina3
            // 
            resources.ApplyResources(this.Regina3, "Regina3");
            this.Regina3.Name = "Regina3";
            // 
            // Regina4
            // 
            resources.ApplyResources(this.Regina4, "Regina4");
            this.Regina4.Name = "Regina4";
            // 
            // Regina5
            // 
            resources.ApplyResources(this.Regina5, "Regina5");
            this.Regina5.Name = "Regina5";
            // 
            // Regina6
            // 
            resources.ApplyResources(this.Regina6, "Regina6");
            this.Regina6.Name = "Regina6";
            // 
            // Regina7
            // 
            resources.ApplyResources(this.Regina7, "Regina7");
            this.Regina7.Name = "Regina7";
            // 
            // Regina8
            // 
            resources.ApplyResources(this.Regina8, "Regina8");
            this.Regina8.Name = "Regina8";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 17, 0, 6, 13, 0);
            // 
            // Rompicapo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Regina8);
            this.Controls.Add(this.Regina7);
            this.Controls.Add(this.Regina6);
            this.Controls.Add(this.Regina5);
            this.Controls.Add(this.Regina4);
            this.Controls.Add(this.Regina3);
            this.Controls.Add(this.Regina2);
            this.Controls.Add(this.Regina1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rompicapo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private ImageList imageList1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label Regina1;
        private Label Regina2;
        private Label Regina3;
        private Label Regina4;
        private Label Regina5;
        private Label Regina6;
        private Label Regina7;
        private Label Regina8;
        private NotifyIcon notifyIcon1;
        private DateTimePicker dateTimePicker1;
    }
}