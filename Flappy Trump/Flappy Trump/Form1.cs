using System;
using System.Media;
using System.Windows.Forms;

namespace Flappy_Trump
{
    public partial class Form1 : Form
    {
        int flyspeed = 6;
        int gravity = 6;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            string path = @"D:\Rescarch\VS编程\C#\Flappy Trump\Flappy Trump\Resources\Astronomia2.wav";
            SoundPlayer bgm = new SoundPlayer(path);
            bgm.PlayLooping();
        }

        private void timerevent(object sender, EventArgs e)
        {
            BabyTrump.Top += gravity;
            bottom.Left -= flyspeed;
            top.Left -= flyspeed;
           

            scoretext.Text = "score:"+score;

            if (bottom.Left<-100)
            {
                bottom.Left = 400;
                Random r2 = new Random();
                int a2 = r2.Next(-35, 41);
                bottom.Top =(290+a2);
                score++;
            }

            if (top.Left < -70)
            {
                top.Left = 400;
                Random r1 = new Random();
                int a1 = r1.Next(-40, 36);
                top.Top =(-45+ a1);
                score++;
            }

            if (BabyTrump.Bounds.IntersectsWith(bottom.Bounds)
               ||BabyTrump.Bounds.IntersectsWith(top.Bounds)
               ||BabyTrump.Bounds.IntersectsWith(ground.Bounds)
               ||BabyTrump.Top<-20
                )
            {
                gameover();       
            }

            if (score>5)
            {
                flyspeed = 10;
            }
            if(score>28)
            {
                flyspeed = 13;
                scoretext.Text = "score:" + score+"你太强了！";
            }
            if (score > 68)
            {
                flyspeed = 18;
                scoretext.Text = "score:" + score + "难以置信！！";
            }
            if (score > 100)
            {
                flyspeed = 28;
                scoretext.Text = "score:" + score + " 无路可退,唯有前进!!!";
            }
            if (score > 160)
            {
                flyspeed = 34;
                scoretext.Text = "score:" + score + " 势不可挡!!!";
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -6;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 6;
            }
        }

        private void gameover()
        {
            timer.Stop();
            if (MessageBox.Show("游戏失败，是否给 B站“工科狗Niko” 投币以继续游戏？", "提示：得分超过200分后可获得源码！", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer.Start();
                BabyTrump.Top = 200;
                BabyTrump.Left = 0;
                bottom.Left += 300;
                top.Left += 300;
                gravity = 6;
            }
            else
            {
                if (score < 200)
                {
                    MessageBox.Show("您的选择是明智的，Trump很不靠谱！", "提示：超过200分后可获得源码", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("恭喜您超过了200分！源码我放在了：https://github.com/NikoHsu/Bilibili 感谢您对这个小项目的喜爱！", "恭喜！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Environment.Exit(0);
                }
            }
        }
    }
}
