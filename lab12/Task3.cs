using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12 {

    class Params {
        public int[] x;
    }

    public partial class Task3 : Form {
        public Task3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var param = Expression.Parameter(typeof(string), "c");
            var condition = Expression.Call(param, typeof(int).GetMethod("Contains"),
                Expression.Constant("a"));
            var l = Expression.Lambda<Func<string, bool>>(condition, param).Compile();
            var rez = l("a");
        }
    }
}
