using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SpelunkySuperTrainer
{
    public partial class Trainer : Form
    {
        HackScripts HackScripts;
        ProcessInformation spelunkyProcessInformation;
        Thread lockingThread;

        private int lockHearts = -1;
        private int lockMoney = -1;
        private int lockRopes = -1;
        private int lockBombs = -1;
        private int lockTimeLeft = -1;
        private int lockTimeRight = -1;

        public Trainer()
        {
            InitializeComponent();
            cboxCurrentlyHolding.DataSource = Enum.GetValues(typeof(ObjectTypes));
            InitializeTrainer();
            InitializeValues();
            InitializeLockThread();
        }

        private void InitializeValues()
        {
            numHearts.Value = HackScripts.GetHearts();
            numRopes.Value = HackScripts.GetRopes();
            numMoney.Value = HackScripts.GetMoney();
            numBombs.Value = HackScripts.GetBombs();
            numStage.Value = HackScripts.GetCurrentStage();
            txtbXPlayer.Text = HackScripts.GetCurrentX().ToString();
            txtbYPlayer.Text = HackScripts.GetCurrentY().ToString();
        }

        private void InitializeLockThread()
        {
            lockingThread = new Thread(() =>
            {
                while (true)
                {
                    if (lockHearts != -1)
                    {
                        HackScripts.SetHearts(lockHearts);
                    }

                    if (lockMoney != -1)
                    {
                        HackScripts.SetMoney(lockMoney);
                    }

                    if (lockRopes != -1)
                    {
                        HackScripts.SetRopes(lockRopes);
                    }

                    if (lockBombs != -1)
                    {
                        HackScripts.SetBombs(lockBombs);
                    }

                    if(lockTimeLeft != -1)
                    {
                        HackScripts.SetLeftTime(lockTimeLeft);
                    }

                    if(lockTimeRight != -1)
                    {
                        HackScripts.SetRightTime(lockTimeRight);
                    }

                    Thread.Sleep(300);
                }
            });
            lockingThread.Start();
        }

        private void InitializeTrainer()
        {
            spelunkyProcessInformation = new ProcessInformation();

            var processes = Process.GetProcessesByName("Spelunky");

            if (processes != null && processes != default && processes.Count() > 0)
            {
                spelunkyProcessInformation.process = Process.GetProcessesByName("Spelunky")[0];
            }
            else
            {
                MessageBox.Show("Unable to find Spelunky. Make sure the game is running!");
                Application.Exit();
                Environment.Exit(Environment.ExitCode);
                return;
            }


            spelunkyProcessInformation.hProc = WinAPIWrapper.OpenProcess(WinAPIWrapper.ProcessAccessFlags.All, false, spelunkyProcessInformation.process.Id);
            spelunkyProcessInformation.moduleBaseAddress = WinAPIWrapper.GetModuleBaseAddress(spelunkyProcessInformation.process.Id, "Spelunky.exe");

            HackScripts = new HackScripts(spelunkyProcessInformation);
        }

        private void btnSetHearts_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numHearts.Value.ToString(), out int hearts))
            {
                HackScripts.SetHearts(hearts);
            }
        }

        private void btnSetBombs_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numBombs.Value.ToString(), out int bombs))
            {
                HackScripts.SetBombs(bombs);
            }
        }

        private void btnSetRopes_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numRopes.Value.ToString(), out int ropes))
            {
                HackScripts.SetRopes(ropes);
            }
        }

        private void btnSetMoney_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numMoney.Value.ToString(), out int money))
            {
                HackScripts.SetMoney(money);
            }
        }

        private void numEntArray_ValueChanged(object sender, EventArgs e)
        {
            var result = HackScripts.GetEntityObject((int)numEntArray.Value);
            if (result == null)
            {
                MessageBox.Show("Unable to get entity!");
                return;
            }

            lblEntX.Text = "X = " + result.Position.X;
            lblEntY.Text = "Y = " + result.Position.Y;
            lblEntType.Text = "Type =  " +  result.ObjectType.ToString() + " (" + result.ObjectTypeId + ")";
        }

        private void btnTeleportToEnt_Click(object sender, EventArgs e)
        {
            var result = HackScripts.GetEntityObject((int)numEntArray.Value);
            if (result == null)
            {
                MessageBox.Show("Unable to get entity!");
                return;
            }

            HackScripts.TeleportPlayer(result.Position);
        }

        private void btnTeleportEntToPlayer_Click(object sender, EventArgs e)
        {
            var result = HackScripts.GetEntityObject((int)numEntArray.Value);
            if (result == null)
            {
                MessageBox.Show("Unable to get entity!");
                return;
            }

            HackScripts.TeleportEntityToPlayer((int)numEntArray.Value);
        }

        private void btnTeleportToExit_Click(object sender, EventArgs e)
        {
            Vector2 exit = HackScripts.GetExitLocation();

            HackScripts.TeleportPlayer(exit);
        }

        private void btnChangeCurrentlyHolding_Click(object sender, EventArgs e)
        {
            var itemId = (int)(ObjectTypes)cboxCurrentlyHolding.SelectedItem;
            HackScripts.SetCurrentHoldingItem(itemId);
            MessageBox.Show("Only use this while in the 'Level done' screen!");
            btnTeleportToExit_Click(null, null);
        }

        private void btnSetStage_Click(object sender, EventArgs e)
        {
            HackScripts.SetStage((int)numStage.Value);
        }

        private void btnTeleportToDest_Click(object sender, EventArgs e)
        {
            if(float.TryParse(txtbXPlayer.Text, out float x) && float.TryParse(txtbYPlayer.Text, out float y))
            {
                HackScripts.TeleportPlayer(new Vector2(x, y));
            }
        }

        private void chckboxHearts_CheckedChanged(object sender, EventArgs e)
        {
            if(chckboxHearts.Checked)
            {
                lockHearts = (int)numHearts.Value;
            }
            else
            {
                lockHearts = -1;
            }
        }

        private void chckboxBombs_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxBombs.Checked)
            {
                lockBombs = (int)numBombs.Value;
            }
            else
            {
                lockBombs = -1;
            }
        }

        private void chckboxRopes_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxRopes.Checked)
            {
                lockRopes = (int)numRopes.Value;
            }
            else
            {
                lockRopes = -1;
            }
        }

        private void chckboxMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxMoney.Checked)
            {
                lockMoney = (int)numMoney.Value;
            }
            else
            {
                lockMoney = -1;
            }
        }

        private void chckboxLockLeftTimer_CheckedChanged(object sender, EventArgs e)
        {
            if(chckboxLockLeftTimer.Checked)
            {
                lockTimeLeft = 1;
            }
            else
            {
                lockTimeLeft = -1;
            }
        }

        private void chckboxLockRightTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxLockRightTimer.Checked)
            {
                lockTimeRight = 1;
            }
            else
            {
                lockTimeRight = -1;
            }
        }

        private void Trainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
