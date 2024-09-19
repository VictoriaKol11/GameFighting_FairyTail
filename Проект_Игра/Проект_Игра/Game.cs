using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Игра
{
    public partial class Game : Form
    {
        private readonly Random random = new Random();
        private readonly string[] massLabelAttackOrProtection = { "голову", "туловище", "ноги" };//Указание, куда был нанесен урон
        int attackGamer, protectionGamer, attackBot, attackBotBefore, protectionBot, protectionBotBefore,
            xod, xodNow = 1, hpAccess = 1, hpAccessBot = 1, damage;
        double hpGamer = 100, hpBot = 100;
        /* ПЕРЕМЕННЫЕ:
        attackGamer - атака игрока;
        protectionGamer - защита игрока;
        attackBot - атака бота;
        attackBotBefore - атака бота в предыдущем ходе. Переменная для ограничения;
        protectionBot - защита бота;
        protectionBotBefore - защита бота в предыдущем ходе. Переменная для ограничения;
        xodNow - счетчик ходов за всю игру;
        xod - указание действия для игрока (аттака/защита);
        hpAccess и hpAccessBot - переменные для разрешения доступа на восстановление HP для игрока и бота соответствено;
        damage - нанесенный урон*/

        private void MessageGameRestart()//Вывод сообщения с предложением сыграть повторно//
        {
            DialogResult result_restart = MessageBox.Show("Хотите сыграть заново?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result_restart == DialogResult.Yes)
            {
                Game newForm1 = new Game();
                newForm1.Show();
            }
        }

        private void IndicationAttackProtection(int xod)//Указание нынешнего хода для игрока//
        {
            switch (xod)
            {
                case 0:
                    {
                        label_attack_or_protection.Text = "АТАКА";
                        button_HeadAttack.Enabled = true;
                        button_BodyAttack.Enabled = true;
                        button_LegsAttack.Enabled = true;
                        button_HeadProtection.Enabled = false;
                        button_BodyProtection.Enabled = false;
                        button_LegsProtection.Enabled = false;
                        break;
                    }
                default:
                    {
                        label_attack_or_protection.Text = "ЗАЩИТА";
                        button_HeadAttack.Enabled = false;
                        button_BodyAttack.Enabled = false;
                        button_LegsAttack.Enabled = false;
                        button_HeadProtection.Enabled = true;
                        button_BodyProtection.Enabled = true;
                        button_LegsProtection.Enabled = true;
                        break;
                    }
            }
        }

        private void GameOverAndHP()//Вывод сообщения о победе/проигрыше и доступ к кнопке HP при HP < 60//
        {
            if ((hpGamer < 60) && (hpAccess == 1))//Доступ к кнопке ХП только при условии HP < 60 % и условии, что игрок еще не лечился//
                button_HP.Enabled = true;
            if ((hpBot < 60) && (hpAccessBot == 1))//Доступ к восстановлению здоровья для бота//
                if ((random.Next(1, 101) < 16))//Восстановление здоровья бота с вероятностью 15%//
                {
                    hpAccessBot = 0;
                    double Treatment_BOT = (100 - hpBot) * random.Next(40, 81) / 100;
                    hpBot += Treatment_BOT;
                    listBox_History.Items.Add("Дедуля восстановил здоровье на " + Treatment_BOT + "%");
                    label_HpBot.Text = Convert.ToString(Math.Round(hpBot, 1));
                    timer1000Bot.Stop();
                    timer1800Bot.Stop();
                    timer2000Bot.Stop();
                    timer2000Bot.Start();
                    pictureBox_Bot.Image = Properties.Resources.MakarovHP;
                }
            if (hpBot <= 0)//Победа//
            {
                StopAllTimers();
                pictureBox_Gamer.Image = Properties.Resources.NatsuWin;
                pictureBox_Bot.Image = Properties.Resources.MakarovLose;
                label_HpBot.Text = "0";
                progressBarBOT.Value = 0;
                MessageBox.Show("ВЫ ПОБЕДИЛИ", "GAME OVER", MessageBoxButtons.OK);
                this.Close();
                MessageGameRestart();
            }
            else
                progressBarBOT.Value = Convert.ToInt32(hpBot);
            if (hpGamer <= 0)//Проигрыш//
            {
                StopAllTimers();
                pictureBox_Gamer.Image = Properties.Resources.NatsuLosePNG;
                pictureBox_Bot.Image = Properties.Resources.MakarovWin;
                label_HpGamer.Text = "0";
                progressBarGamer.Value = 0;
                MessageBox.Show("ВЫ ПРОИГРАЛИ", "GAME OVER", MessageBoxButtons.OK);
                this.Close();
                MessageGameRestart();
            }
            else
                progressBarGamer.Value = Convert.ToInt32(hpGamer);
        }

        private void AttackOrProtection(int rn1, int rn2, double krit)
        /*Атака\защита. 
        Параметры: 1 и 2 - границы рандома урона, 3 - крит урон*/
        {
            StopAllTimers();
            int kritRn = random.Next(1, 101);//Шанс выпадения крита//
            switch (xod) //Проверка: игрок атакует(0) или защищается(1)//
            {
                case 0:
                    {
                        do//Ограничение для бота: защищать 2 раза подряд одно и тоже место нельзя//
                            protectionBot = random.Next(1, 4);//Рандом хода бота - защита//
                        while (protectionBot == protectionBotBefore);
                        protectionBotBefore = protectionBot;
                        if (protectionBot != attackGamer)//Удар прошел//
                        {
                            damage = random.Next(rn1, rn2);//Рандом урона//
                            if ((kritRn < 6) && (kritRn > 0))//Удар с критом, если он выпал//
                            {
                                hpBot -= (damage * krit);
                                listBox_History.Items.Add("ХОД " + xodNow + ": Успешная атака с крит уроном в " + massLabelAttackOrProtection[attackGamer - 1] + " - " + (damage * krit) + " HP");
                                timer2300.Start();
                                pictureBox_Gamer.Image = Properties.Resources.NatsuKrit;
                            }
                            else
                            {
                                hpBot -= damage;//Удар без крит урона//
                                listBox_History.Items.Add("ХОД " + xodNow + ": Успешная атака в " + massLabelAttackOrProtection[attackGamer - 1] + " - " + damage + " HP");
                                timer1800Gamer.Start();
                                pictureBox_Gamer.Image = Properties.Resources.NatsuAttack;
                            }
                            timer1000Bot.Start();
                            pictureBox_Bot.Image = Properties.Resources.MakarovDamage;
                            pictureBoxBotIcon.Image = Properties.Resources.MakarovDamageIcon;
                        }
                        else//Удар не прошел//
                        {
                            if ((kritRn < 6) && (kritRn > 0))//Удар с критом, если он выпал, но противник защитился//
                            {
                                damage = random.Next(rn1, rn2);//Рандом урона//
                                hpBot -= ((damage * krit) / 2);
                                listBox_History.Items.Add("ХОД " + xodNow + ": Успешная атака с крит уроном в " + massLabelAttackOrProtection[attackGamer - 1] + ", но дедуля защитился - " + ((damage * krit) / 2) + " HP");
                                timer2300.Start();
                                pictureBox_Gamer.Image = Properties.Resources.NatsuKrit;
                                timer1000Bot.Start();
                                pictureBox_Bot.Image = Properties.Resources.MakarovDamage;
                                pictureBoxBotIcon.Image = Properties.Resources.MakarovDamageIcon;
                            }
                            else
                            {
                                listBox_History.Items.Add("ХОД " + xodNow + ": Вы атаковали в " + massLabelAttackOrProtection[attackGamer - 1] + ", но дедуля защитился");
                                timer1000Bot.Start();
                                pictureBox_Bot.Image = Properties.Resources.MakarovProtection;
                                timer1800Gamer.Start();
                                pictureBox_Gamer.Image = Properties.Resources.NatsuAttack;
                            }
                        }
                        label_HpBot.Text = Convert.ToString(Math.Round(hpBot,1));//Отображение текущего количества HP у бота//
                        break;
                    }
                default:
                    {
                        do//Ограничение для бота: атаковать 2 раза подряд в одно и тоже место нельзя//
                            attackBot = random.Next(1, 4);//Рандом хода бота - атака//
                        while (attackBot == attackBotBefore);
                        attackBotBefore = attackBot;
                        if (attackBot != protectionGamer) //Удар прошел//
                        {
                            damage = random.Next(rn1, rn2);//Рандом урона//
                            if ((kritRn < 6) && (kritRn > 0))//Удар с крит уроном//
                            {
                                hpGamer -= (damage * krit);
                                listBox_History.Items.Add("ХОД " + xodNow + ": Дедуля атаковал в " + massLabelAttackOrProtection[attackBot - 1] + " с крит уроном - " + (damage * krit) + " HP");
                                timer1800Bot.Start();
                                pictureBox_Bot.Image = Properties.Resources.MakarovKrit;
                            }
                            else
                            {
                                hpGamer -= damage;//Удар без крит урона//
                                listBox_History.Items.Add("ХОД " + xodNow + ": Дедуля атаковал в " + massLabelAttackOrProtection[attackBot - 1] + " - " + damage + " HP");
                                timer1000Bot.Start();
                                pictureBox_Bot.Image = Properties.Resources.MakarovAttack;
                            }
                            timer1000Gamer.Start();
                            pictureBox_Gamer.Image = Properties.Resources.NatsuDamage;
                            pictureBoxGamerIcon.Image = Properties.Resources.NatsuDamageIcon;
                        }
                        else //Удар не прошел//
                        {
                            if ((kritRn < 6) && (kritRn > 0))
                            {
                                damage = random.Next(rn1, rn2);//Рандом урона//
                                hpGamer -= ((damage * krit) / 2);
                                listBox_History.Items.Add("ХОД " + xodNow + ": Дедуля атаковал в " + massLabelAttackOrProtection[attackBot - 1] + ". Вы защитились, но выпал крит урон - " + ((damage * krit) / 2) + " HP");
                                timer1000Gamer.Start();
                                pictureBox_Gamer.Image = Properties.Resources.NatsuDamage;
                                pictureBoxGamerIcon.Image = Properties.Resources.NatsuDamageIcon;
                                timer1800Bot.Start();
                                pictureBox_Bot.Image = Properties.Resources.MakarovKrit;
                            }
                            else
                            {
                                listBox_History.Items.Add("ХОД " + xodNow + ": Дедуля атаковал в " + massLabelAttackOrProtection[attackBot - 1] + ", но вы защитились");
                                timer1000Bot.Start();
                                timer1000Gamer.Start();
                                pictureBox_Gamer.Image = Properties.Resources.NatsuProtection;
                                pictureBox_Bot.Image = Properties.Resources.MakarovAttack;
                            }
                        }
                        label_HpGamer.Text = Convert.ToString(Math.Round(hpGamer,1));//Отображение текущего количества HP у игрока//
                        break;
                    }
            }
            xodNow++;
            label_xod_now.Text = "ХОД: " + xodNow; //Отображение текущего хода//
        }

        private void AttackLimitationForGamer()//Ограничение для игрока: нельзя атаковать/защищать дважды одно и тоже место//
        {
            if (xod == 0)//Для атаки//
            {
                switch (attackGamer)
                {
                    case 1:
                        button_HeadAttack.Enabled = false;
                        button_BodyAttack.Enabled = true;
                        button_LegsAttack.Enabled = true;
                        break;
                    case 2:
                        button_HeadAttack.Enabled = true;
                        button_BodyAttack.Enabled = false;
                        button_LegsAttack.Enabled = true;
                        break;
                    case 3:
                        button_HeadAttack.Enabled = true;
                        button_BodyAttack.Enabled = true;
                        button_LegsAttack.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            else//Для защиты//
            {
                switch (protectionGamer)
                {
                    case 1:
                        button_HeadProtection.Enabled = false;
                        button_BodyProtection.Enabled = true;
                        button_LegsProtection.Enabled = true;
                        break;
                    case 2:
                        button_HeadProtection.Enabled = true;
                        button_BodyProtection.Enabled = false;
                        button_LegsProtection.Enabled = true;
                        break;
                    case 3:
                        button_HeadProtection.Enabled = true;
                        button_BodyProtection.Enabled = true;
                        button_LegsProtection.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void StopAllTimers()
        {
            timer1000Bot.Stop();
            timer1800Bot.Stop();
            timer2000Bot.Stop();
            timer2300.Stop();
            timer1000Gamer.Stop();
            timer1800Gamer.Stop();
            timer2000Gamer.Stop();
        }//Прекращение предыдущих анимаций

        private void timer2300_Tick(object sender, EventArgs e)
        {
            pictureBox_Gamer.Image = Properties.Resources.NatsuStance;
            pictureBoxGamerIcon.Image = Properties.Resources.NatsuStonceIcon;
            timer2300.Stop();
        }

        private void timer1000Gamer_Tick(object sender, EventArgs e)
        {
            pictureBox_Gamer.Image = Properties.Resources.NatsuStance;
            pictureBoxGamerIcon.Image = Properties.Resources.NatsuStonceIcon;
            timer1000Gamer.Stop();
        }

        private void timer1800Gamer_Tick(object sender, EventArgs e)
        {
            pictureBox_Gamer.Image = Properties.Resources.NatsuStance;
            pictureBoxGamerIcon.Image = Properties.Resources.NatsuStonceIcon;
            timer1800Gamer.Stop();
        }

        private void timer2000Gamer_Tick(object sender, EventArgs e)
        {
            pictureBox_Gamer.Image = Properties.Resources.NatsuStance;
            pictureBoxGamerIcon.Image = Properties.Resources.NatsuStonceIcon;
            timer2000Gamer.Stop();
        }
        private void timer1000Bot_Tick(object sender, EventArgs e)
        {
            pictureBox_Bot.Image = Properties.Resources.MakarovStonce;
            pictureBoxBotIcon.Image = Properties.Resources.MakarovStonceIcon;
            timer1000Bot.Stop();
        }

        private void timer1800Bot_Tick(object sender, EventArgs e)
        {
            pictureBox_Bot.Image = Properties.Resources.MakarovStonce;
            pictureBoxBotIcon.Image = Properties.Resources.MakarovStonceIcon;
            timer1800Bot.Stop();
        }

        private void timer2000Bot_Tick(object sender, EventArgs e)
        {
            pictureBox_Bot.Image = Properties.Resources.MakarovStonce;
            pictureBoxBotIcon.Image = Properties.Resources.MakarovStonceIcon;
            timer2000Bot.Stop();
        }

        

        private void ButtonClick(ref int xod, int PartOfBody, int rn1, int rn2, double krit)
        {
            switch (xod)
            {
                case 0:
                    {
                        attackGamer = PartOfBody;
                        break;
                    }
                default:
                    {
                        protectionGamer = PartOfBody;
                        break;
                    }
            }
            AttackOrProtection(rn1, rn2, krit);
            GameOverAndHP();
            switch (xod)//Смена хода
            {
                case 0:
                    {
                        xod = 1;
                        break;
                    }
                default:
                    {
                        xod = 0;
                        break;
                    }
            }
            IndicationAttackProtection(xod);
            AttackLimitationForGamer();
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_HP.Enabled = false;//Восстановление здоровья недоступно в начале игры//
            hpGamer = progressBarGamer.Value;
            hpBot = progressBarBOT.Value;
            xod = random.Next(0, 2); //Рандом хода в начале игры. 0 - Атака, 1 - Защита//
            label_xod_now.Text = "ХОД: " + xodNow;
            IndicationAttackProtection(xod);
            listBox_History.Items.Add("Нацу: 'Хей, дедуля, смахнемся?'");
            listBox_History.Items.Add("(Д̶е̶д̶у̶л̶я̶) Макаров: '...(￢_￢)'");
        }

        private void Button_HeadProtection_Click(object sender, EventArgs e)//Защита головы
        {
            ButtonClick(ref xod, 1, 8, 15, 1.8);
        }

        private void Button_BodyProtection_Click(object sender, EventArgs e)//Защита туловища
        {
            ButtonClick(ref xod, 2, 7, 13, 1.9);
        }

        private void Button_LegsProtection_Click(object sender, EventArgs e)//Защита ног
        {
            ButtonClick(ref xod, 3, 6, 11, 2);
        }

        private void Button_HeadAttack_Click(object sender, EventArgs e)//Атака в голову
        {
            ButtonClick(ref xod, 1, 8, 15, 1.8);
        }

        private void Button_BodyAttack_Click(object sender, EventArgs e)//Атака в туловище
        {
            ButtonClick(ref xod, 2, 7, 13, 1.9);
        }

        private void Button_LegsAttack_Click(object sender, EventArgs e)//Атака в ноги
        {
            ButtonClick(ref xod, 3, 6, 11, 2);
        }

        private void Button_HP_Click(object sender, EventArgs e)//Лечение
        {
            button_HP.Enabled = false;
            hpAccess = 0;
            double HP_plus =(100 - hpGamer) *random.Next(40,81)/100;
            hpGamer += HP_plus;
            listBox_History.Items.Add("Вы восстановили здоровье на "+HP_plus+" %");
            progressBarGamer.Value = Convert.ToInt32(hpGamer);
            label_HpGamer.Text = Convert.ToString(Math.Round(hpGamer,1));
            StopAllTimers();
            timer2000Gamer.Start();
            pictureBox_Gamer.Image = Properties.Resources.NatsuHP;
        }

        private void Button_exit_Click(object sender, EventArgs e)//Выход
        {
            DialogResult exit_message = MessageBox.Show("Xотите прервать игру?",
                "EXIT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (exit_message == DialogResult.Yes)
                this.Close();
        }
    }
}
