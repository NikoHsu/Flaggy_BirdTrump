namespace Flappy_Trump
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.top = new System.Windows.Forms.PictureBox();
            this.bottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.BabyTrump = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BabyTrump)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.top.Image = global::Flappy_Trump.Properties.Resources.Top;
            this.top.Location = new System.Drawing.Point(473, -55);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(118, 287);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 0;
            this.top.TabStop = false;
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.Magenta;
            this.bottom.Image = global::Flappy_Trump.Properties.Resources.Button;
            this.bottom.Location = new System.Drawing.Point(412, 419);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(139, 304);
            this.bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottom.TabIndex = 1;
            this.bottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Trump.Properties.Resources.Wall;
            this.ground.Location = new System.Drawing.Point(-16, 619);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(641, 145);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // BabyTrump
            // 
            this.BabyTrump.Image = global::Flappy_Trump.Properties.Resources.Trump;
            this.BabyTrump.Location = new System.Drawing.Point(38, 251);
            this.BabyTrump.Name = "BabyTrump";
            this.BabyTrump.Size = new System.Drawing.Size(100, 70);
            this.BabyTrump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BabyTrump.TabIndex = 4;
            this.BabyTrump.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.DarkOrange;
            this.scoretext.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(12, 20);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(126, 34);
            this.scoretext.TabIndex = 5;
            this.scoretext.Text = "Score:0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 18;
            this.timer.Tick += new System.EventHandler(this.timerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::Flappy_Trump.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 757);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.BabyTrump);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.top);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Flaggy Trump (by bilibili 工科狗Niko)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BabyTrump)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox bottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox BabyTrump;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer timer;
    }
}

