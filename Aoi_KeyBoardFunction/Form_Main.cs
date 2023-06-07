using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using NAudio.Wave;

namespace Aoi_KeyBoardFunction
{
    public partial class Form_Main : Form
    {
        private bool functionFlag = false;
        private WaveOutEvent player;
        private GlobalKeyboardHook gHook;
        private Dictionary<string, string> keyValuePairs;
        private string soundfolderPath = string.Empty;

        public Form_Main()
        {
            InitializeComponent();
            keyValuePairs = Program.keyValuePairs;
            soundfolderPath = Program.soundfolderPath;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
        }

        private void Btn_Enable_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            functionFlag = !functionFlag;
            Btn_Enable.Text = functionFlag ? "Disabled" : "Enabled";
            Btn_Setting.Enabled = !functionFlag;

            if (functionFlag)
            {
                gHook.hook();
                Logger.WriteLog(true, $"Hook Start");
            }
            else
            {
                gHook.unhook();
            }

            Cursor = Cursors.Default;
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            Visible = false;
            var setting = new Form_KBSetting();
            setting.ShowDialog();

            Visible = true;
        }

        private void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            Debug.WriteLine($"Press {key}");
            

            if (keyValuePairs.ContainsKey(key) && !string.IsNullOrEmpty(keyValuePairs[key]))
            {
                PlaySound(keyValuePairs[key]);
            }
        }

        private void PlaySound(string soundPath)
        {
            try
            {
                if (player != null)
                {
                    player.Stop();
                    player.Dispose();
                }

                player = new WaveOutEvent();
                var audioFileReader = new AudioFileReader(Path.Combine(soundfolderPath, soundPath));
                player.Init(audioFileReader);
                player.Play();
                Logger.WriteLog(true, $"Play {soundPath}");
            }
            catch (Exception exp)
            {
                Logger.WriteLog(false, $"Play {soundPath}: {exp.Message}");
                throw exp;
            }
        }

    }
}
