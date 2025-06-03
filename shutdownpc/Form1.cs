using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace shutdownpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, System.EventArgs e)
        {
            string cmd = $"shutdown -s -t {nud1.Value * 3600 + nud2.Value * 60 + nud3.Value}";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C {cmd}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
            MessageBox.Show($"Máy tính sẽ tắt trong {nud1.Value} giờ {nud2.Value} phút {nud3.Value} giây!");
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            string cmd = $"shutdown -a";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C {cmd}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
            MessageBox.Show("Huỷ hẹn giờ thành công!");;
        }
    }
}
