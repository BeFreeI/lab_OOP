using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12 {
    public partial class Calc : Form {

        public Calc() {
            InitializeComponent();
        }

        public void ShowResult(int[] nums) {
            this.result.Text = "";
            foreach(int num in nums) {
                this.result.Text += $"{num}\n";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
