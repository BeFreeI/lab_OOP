using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace lab12 {
    public partial class Input : Form {
        public Input() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private int[] getNumbers() {
            int[] arr = new int[3];
            try {
                arr[0] = int.Parse(this.textBox1.Text);
                arr[1] = int.Parse(this.textBox2.Text);
                arr[2] = int.Parse(this.textBox3.Text);
            } catch {
                Application.Exit();
            }
            return arr;
        }

        private int gcd(int a, int b) { return (a > 0) ? gcd(b % a, a) : b; }
        private int mlc(int a, int b) { return (a * b) / gcd(a, b); }

        public int[] getResult() {
            CheckedItemCollection operations = getCheckedOperation();
            int[] numbers = getNumbers(),
                rez = new int[operations.Count];
            int i = 0;
            if(operations.Contains("Summ")) {
                rez[i++] = numbers.Sum();
            }
            if (operations.Contains("Least multiple")) {
                rez[i++] = mlc(numbers[0], numbers[1]);
            }

            return rez;
        }

        private CheckedItemCollection getCheckedOperation() {
            return this.checkedListBox1.CheckedItems;
        }
    }
}
