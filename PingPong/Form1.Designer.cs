namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackGround = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.Boll = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boll)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Controls.Add(this.GamePanel);
            this.BackGround.Controls.Add(this.Boll);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(800, 450);
            this.BackGround.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Blue;
            this.GamePanel.Location = new System.Drawing.Point(219, 393);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(302, 31);
            this.GamePanel.TabIndex = 1;
            this.GamePanel.TabStop = false;
            // 
            // Boll
            // 
            this.Boll.BackColor = System.Drawing.Color.Yellow;
            this.Boll.Location = new System.Drawing.Point(158, 87);
            this.Boll.Name = "Boll";
            this.Boll.Size = new System.Drawing.Size(50, 50);
            this.Boll.TabIndex = 0;
            this.Boll.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.BackGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boll)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel BackGround;
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.PictureBox Boll;
        private System.Windows.Forms.Timer timer;
    }
}

