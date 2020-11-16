using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int player_a2_cool;
        int player_a3_cool;

        int bot_a2_cool;
        int bot_a3_cool;

        int player_hp = 0;
        int bot_hp = 0;

        int hard = 1000;

        int start = 0;
        Random rnd = new Random();
        // Function Zone
        public void default_setting()
        {
            bot_win.Visible = false;
            player_win.Visible = false;
            player_a2_cool = 30;
            player_a3_cool = 90;
            bot_a2_cool = 30;
            bot_a3_cool = 90;
            player_log.Text = "";
            bot_log.Text = "";
            player_log.AppendText("----------[Start New Game]----------\r\n");
            bot_log.AppendText("----------[Start New Game]----------\r\n");
            player_bar.Value = 1000000;
            bot_bar.Value = 1000000;

            player_hp = 1000000;
            bot_hp = 1000000;

            player_a1.Enabled = true;
            player_a2.Enabled = true;
            player_a3.Enabled = true;

            bot_a1.Enabled = true;
            bot_a2.Enabled = true;
            bot_a3.Enabled = true;
            time_bot.Enabled = true;

            level_butt_off();
        }
        public void level_butt_on()
        {
            easy_butt.Enabled = true;
            normal_butt.Enabled = true;
            hard_butt.Enabled = true;
            rip_butt.Enabled = true;
        }
        public void level_butt_off()
        {
            easy_butt.Enabled = false;
            normal_butt.Enabled = false;
            hard_butt.Enabled = false;
            rip_butt.Enabled = false;
        }
        public void close_timer()
        {
            time_a2.Enabled = false;
            time_a3.Enabled = false;

            time_a2_bot.Enabled = false;
            time_a3_bot.Enabled = false;
        }
        public void attack_1(int side)
        {
            int damage = rnd.Next(1500, 1701);
            if (side == 1)
            {
                if(bot_hp <= damage)
                {
                    bot_hp = 0;
                }
                else
                {
                    bot_hp = bot_hp - damage;
                    player_log.AppendText("A1 > Attact to Bot: " + damage + " Damage\r\n");
                }
            }
            else if (side == 2)
            {
                if (player_hp <= damage)
                {
                    player_hp = 0;
                }
                else
                {
                    player_hp = player_hp - damage;
                    bot_log.AppendText("A1 > Attact to Player: " + damage + " Damage\r\n");

                }
            }
        }
        public void attack_2(int side)
        {
            int i = 1;
            while (i <= 3)
            {
                int damage = rnd.Next(1000, 2001);
                if (side == 1)
                {
                    if (bot_hp <= damage)
                    {
                        bot_hp = 0;
                    }
                    else
                    {
                        bot_hp = bot_hp - damage;
                        player_log.AppendText("A2 > Attact to Bot: " + damage + " Damage\r\n");
                    }
                }
                else if (side == 2)
                {
                    if (player_hp <= damage)
                    {
                        bot_hp = 0;
                    }
                    else
                    {
                        player_hp = player_hp - damage;
                        bot_log.AppendText("A2 > Attact to Player: " + damage + " Damage\r\n");

                    }
                }
                i++;
            }
        }
        public void attack_3(int side)
        {
            int damage = rnd.Next(1400, 2501);
            if (side == 1)
            {
                if (bot_hp <= damage)
                {
                    bot_hp = 0;
                }
                else
                {
                    bot_hp = bot_hp - damage;
                    player_log.AppendText("A3 > Attact to Bot: " + damage + " Damage\r\n");
                }
            }
            else if (side == 2)
            {
                if (player_hp <= damage)
                {
                    bot_hp = 0;
                }
                else
                {
                    player_hp = player_hp - damage;
                    bot_log.AppendText("A3> Attact to Player: " + damage + " Damage\r\n");

                }
            }

        }
        public void attack_3_check(int side)
        {
            if(side == 1 && bot_hp < 250000)
            {
                time_player_a3.Enabled = true;
            }
            else if (side == 1 && bot_hp >= 250000)
            {
                int i = 1;
                while (i <= 10)
                {
                    attack_3(1);
                    i++;
                }
            }
            else if (side == 2 && player_hp < 250000)
            {

            }
            else if (side == 2 && bot_hp >= 250000)
            {
                int i = 1;
                while (i <= 10)
                {
                    attack_3(2);
                    i++;
                }
            }
        }
        public void get_winner()
        {
            timer1.Enabled = false;
            start = 0;
            start_butt.Text = "New Game";
            close_timer();
            level_butt_on();
            start_butt.BackColor = Color.MediumSeaGreen;
            bot_a1.Enabled = false;
            bot_a2.Enabled = false;
            bot_a3.Enabled = false;
            player_a1.Enabled = false;
            player_a2.Enabled = false;
            player_a3.Enabled = false;
            player_bar.Value = 0;
            bot_bar.Value = 0;
            player_hp = 0;
            bot_hp = 0;
            time_bot.Enabled = false;

            player_a2.Text = "A2";
            player_a3.Text = "A3";

            bot_a2.Text = "A2";
            bot_a3.Text = "A3";

            close_timer();

            level_butt_on();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            get_winner();
        }
        // Button Click Zone
        private void start_butt_Click(object sender, EventArgs e)
        {

            if(start == 0)
            {
                timer1.Enabled = true;
                default_setting();
                start_butt.Text = "SURRENDER";
                start_butt.BackColor = Color.MediumSlateBlue;
                start = 2;
            }
            else if (start == 2)
            {
                timer1.Enabled = false;
                start_butt.Text = "START";
                start_butt.BackColor = Color.MediumSeaGreen;
                start = 0;
                bot_win.Visible = true;
                get_winner();
            }
        }
        private void player_a1_Click(object sender, EventArgs e)
        {
            attack_1(1);
        }
        private void player_a2_Click(object sender, EventArgs e)
        {
            player_a2.Enabled = false;
            attack_2(1);
            time_a2.Enabled = true;
        }
        private void player_a3_Click(object sender, EventArgs e)
        {
            player_a3.Enabled = false;
            attack_3_check(1);
            time_a3.Enabled = true;
        }
        private void easy_butt_Click(object sender, EventArgs e)
        {
            hard = 1000;
        }

        private void normal_butt_Click(object sender, EventArgs e)
        {
            hard = 300;
        }

        private void hard_butt_Click(object sender, EventArgs e)
        {
            hard = 50;
        }
        private void rip_butt_Click(object sender, EventArgs e)
        {
            hard = 1;
        }
        // Timer Zone
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            player_bar.Value = player_hp;
            bot_bar.Value = bot_hp;
            bot_hp_label.Text = "BOT HP: " + bot_hp + " / 1000000";
            player_hp_label.Text = "PLAYER HP: " + player_hp + " / 1000000";
            if(bot_hp == 0 && bot_hp < player_hp)
            {
                player_win.Visible = true;
                get_winner();
            }
            else if (player_hp == 0 && player_hp < bot_hp)
            {
                bot_win.Visible = true;
                get_winner();
            }
        }
        private void time_a2_Tick(object sender, EventArgs e)
        {
            time_a2.Interval = 1000;
            if(player_a2_cool <= 0)
            {
                time_a2.Enabled = false;
                player_a2_cool = 30;
                player_a2.Enabled = true;
                player_a2.Text = "A2";
            }
            else
            {
                player_a2_cool = player_a2_cool - 1;
                player_a2.Enabled = false;
                player_a2.Text = "A2 (" + Convert.ToString(player_a2_cool) + ")";
            }
        }

        private void time_a3_Tick(object sender, EventArgs e)
        {
            time_a3.Interval = 1000;
            if (player_a3_cool <= 0)
            {
                time_a3.Enabled = false;
                player_a3_cool = 90;
                player_a3.Enabled = true;
                player_a3.Text = "A3";
            }
            else
            {
                player_a3_cool = player_a3_cool - 1;
                player_a3.Enabled = false;
                player_a3.Text = "A3 (" + Convert.ToString(player_a3_cool) + ")";
            }
        }

        private void time_player_a3_Tick(object sender, EventArgs e)
        {
            time_player_a3.Interval = 10;
            if(bot_hp > 0)
            {
                attack_3(1);
            }
            else
            {
                time_player_a3.Enabled = false;
            }
        }

        private void time_bot_a3_Tick(object sender, EventArgs e)
        {
            time_bot_a3.Interval = 10;
            if (player_hp > 0)
            {
                attack_3(2);
            }
            else
            {
                time_bot_a3.Enabled = false;
            }
        }

        private void time_a2_bot_Tick(object sender, EventArgs e)
        {
            time_a2_bot.Interval = 1000;
            if (bot_a2_cool <= 0)
            {
                time_a2_bot.Enabled = false;
                bot_a2_cool = 30;
                bot_a2.Enabled = true;
                bot_a2.Text = "A2";
            }
            else
            {
                bot_a2_cool = bot_a2_cool - 1;
                bot_a2.Enabled = false;
                bot_a2.Text = "A2 (" + Convert.ToString(bot_a2_cool) + ")";
            }
        }

        private void time_a3_bot_Tick(object sender, EventArgs e)
        {
            time_a3_bot.Interval = 1000;
            if (bot_a3_cool <= 0)
            {
                time_a3_bot.Enabled = false;
                bot_a3_cool = 90;
                bot_a3.Enabled = true;
                bot_a3.Text = "A3";
            }
            else
            {
                bot_a3_cool = bot_a3_cool - 1;
                bot_a3.Enabled = false;
                bot_a3.Text = "A3 (" + Convert.ToString(bot_a3_cool) + ")";
            }
        }

        private void time_bot_Tick(object sender, EventArgs e)
        {
            if(start == 2)
            {
                time_bot.Interval = hard;
                if(bot_a1.Enabled == true)
                {
                    attack_1(2);
                }
                if (bot_a2.Enabled == true)
                {
                    bot_a2.Enabled = false;
                    attack_2(2);
                    time_a2_bot.Enabled = true;
                }
                if (bot_a3.Enabled == true)
                {
                    bot_a3.Enabled = false;
                    attack_3_check(2);
                    time_a3_bot.Enabled = true;
                }
            }
        }
    }
}
