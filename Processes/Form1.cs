using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Processes {
    public partial class Form1 : Form {

        private Process process;
        public Form1() {
            InitializeComponent();
            process = new Process();
            cbOperators.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbFileName.Text)) return;

            Thread thread = new Thread(Ex1);
            thread.Start();
        }
        private void Ex1() {
          

            process.StartInfo.FileName = tbFileName.Text;
            try {
                process.Start();
                process.WaitForExit();
                MessageBox.Show($"Exit code: {process.ExitCode}", "Result");
            }
            catch (Exception) {
                MessageBox.Show("File name hasn't found");
            }
        }
        private void bKill_Click(object sender, EventArgs e) {
            try {
                process.Kill();
            }
            catch (Exception) {

            }
        }

        private void bCalc_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbFileName.Text)) return;
            Thread thread = new Thread(calc);
            thread.Start();
        }
        private void calc() {

          

            Action action = () => {
                try {
                    process = Process.Start(tbFileName.Text, $"{nFirst.Value} {nSecond.Value} {cbOperators.SelectedItem}");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            };

            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void bWordsCounter_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbWord.Text)) return;

            OpenFileDialog fD = new OpenFileDialog();
            fD.Filter = "Text Files|*.txt|All files|*.*";
            fD.ShowDialog();

            Thread thread = new Thread(counter);
            thread.Start(fD.FileName);
        }

        private void counter(object folder) {
            Action action = () => {
                try {
                    process = Process.Start(tbFileName.Text, $"{folder as string} {tbWord.Text}");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            };

            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }
    }
}
