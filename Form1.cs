using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTimer
{
    public partial class Form1 : Form
    {

        Timer   tmrMain;
        Boolean blnUP = true;

        public Form1()
        {
            InitializeComponent();

            this.Location = new Point( Properties.Settings.Default.cfgLocationX, Properties.Settings.Default.cfgLocationY);

            txbDo.Text = Properties.Settings.Default.cfgMainTime.ToString();
            txbInterval.Text = Properties.Settings.Default.cfgCoolTime.ToString();
            chkAuto.Checked = Properties.Settings.Default.cfgContinuous;
            trackBar1.Value = Properties.Settings.Default.cfgOpacity;
            this.Opacity = (double)trackBar1.Value / trackBar1.Maximum;

            tmrMain = new Timer();
            tmrMain.Interval = 100;
            tmrMain.Tick += new EventHandler(mainTmrIRF);
            tmrMain.Enabled = false;
        }

        private uint masterCount()
        {
            return uint.Parse(txbCount.Text);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                prgbarMain.Maximum = int.Parse(txbDo.Text) * 10;
            }
            catch (Exception)
            {
                txbDo.Text = Properties.Settings.Default.cfgMainTime.ToString();
                prgbarMain.Maximum = int.Parse(txbDo.Text) * 10;
            }
            prgbarMain.Step = 1;
            prgbarMain.Value = 0;

            if (blnUP)
            {
                txbCount.Text = (masterCount() + 1).ToString();
                blnUP = false;
            }

            tmrMain.Enabled = true;
        }


        private void mainTmrIRF(object sender, EventArgs e)
        {
            prgbarMain.PerformStep();


            if (prgbarMain.Value == prgbarMain.Maximum)
            {
                System.Media.SystemSounds.Beep.Play();
            }

            if (chkAuto.Checked)
            {
                if (prgbarMain.Value == prgbarMain.Maximum)
                {
                    txbCount.Text = (masterCount() + 1).ToString();
                    try
                    {
                        prgbarMain.Maximum = int.Parse(txbInterval.Text) * 10;
                    }
                    catch (Exception)
                    {
                        txbInterval.Text = Properties.Settings.Default.cfgCoolTime.ToString();
                        prgbarMain.Maximum = int.Parse(txbInterval.Text) * 10;
                    }                
                    prgbarMain.Value = prgbarMain.Maximum;
                    prgbarMain.Step = -1;                  
                }
                else if (prgbarMain.Value == prgbarMain.Minimum)
                {
                    btnRun.PerformClick();
                }
            }
            else
            {
                if (prgbarMain.Value == prgbarMain.Maximum)
                {
                    tmrMain.Enabled = false;
                    blnUP = true;
                }
            }
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            txbDo.Text = "60";
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            txbDo.Text = "30";
        }

        private void txbDo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbDo.Text != "")
                {
                    txbDo.Text = uint.Parse(txbDo.Text).ToString();
                    if (int.Parse(txbDo.Text) < 1) txbDo.Text = "1";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"#01\n(uint) Time per Picture\n1枚あたりの時間を入力してください。\n ---------- \n{exp}");
                txbDo.Text = Properties.Settings.Default.cfgMainTime.ToString();
            }
        }

        private void txbInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbInterval.Text != "") {
                    txbInterval.Text = uint.Parse(txbInterval.Text).ToString();
                    if (int.Parse(txbInterval.Text) < 1) txbInterval.Text = "1";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"#02\n(uint) Cool Time between Pictures\n切り替え時間を入力してください。\n ---------- \n{exp}");
                txbInterval.Text = Properties.Settings.Default.cfgCoolTime.ToString();
            }
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
            {
                txbInterval.Enabled = true;
            }
            else
            {
                txbInterval.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.cfgLocationX = this.Location.X;
            Properties.Settings.Default.cfgLocationY = this.Location.Y;
            Properties.Settings.Default.cfgMainTime     = uint.Parse(txbDo.Text);
            Properties.Settings.Default.cfgCoolTime     = uint.Parse(txbInterval.Text);
            Properties.Settings.Default.cfgContinuous   = chkAuto.Checked;
            Properties.Settings.Default.cfgOpacity = trackBar1.Value;
            Properties.Settings.Default.Save();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value / trackBar1.Maximum;
        }
    }
}
