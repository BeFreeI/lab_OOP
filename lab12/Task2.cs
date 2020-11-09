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
    struct man {
        public string name,
            sername;
    }
    public partial class Task2 : Form {
        public Task2() {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Task2_Load(object sender, EventArgs e) {
            man el = new man();
            el.name = "Pavel";
            el.sername = "Nepogodin";
            var arr = this.listView1.Items[0];
            return;
        }
    }
}
