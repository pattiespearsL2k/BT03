using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        DataTable[] dt = new DataTable[5];
        int i;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (i = 0; i < comboBox1.Items.Count; i++)
            {
                dt[i] = new DataTable();
                dt[i].Columns.Add("Món ăn", typeof(string));
                dt[i].Columns.Add("Số lượng", typeof(int));
                Gr.DataSource = dt[i];
            }


        }


        private void button15_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            Button b = (Button)sender;
            int k;
            bool t = false;
            for (k = 0; k < dt[index].Rows.Count; k++)
            {
                if (b.Text == (String)dt[index].Rows[k]["Món ăn"])
                {
                    t = true;
                    break;
                }
            }
            if (t == true)
                dt[index].Rows[k]["Số lượng"] = (int)dt[index].Rows[k]["Số lượng"] + 1;
            else
            {
                DataRow dr = dt[index].NewRow();
                dr["Món ăn"] = b.Text;
                dr["Số lượng"] = 1;
                dt[index].Rows.Add(dr);

          

            }
            Gr.DataSource = dt[index];
        }

        private void button16_Click(object sender, EventArgs e)
        {


            if (Gr.Rows.Count > 0)
            {
                dt[comboBox1.SelectedIndex].Clear();
            }



            else
            {
               
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string s = cb.SelectedIndex.ToString();
            Gr.DataSource = dt[cb.SelectedIndex];
        }
    }
}















