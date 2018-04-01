using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace გამოცდა
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Do_Checked();
            Do_Checked1();

            if (checkBox1.Checked & checkBox2.Checked)
            {
               button1.Enabled = !checkBox1.Checked;
               button2.Enabled = !checkBox2.Checked;
            }
        }

        #region checkbox1 - 2
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked1();
        }
        private void Do_Checked()
        {
            button1.Enabled = checkBox1.Checked;
        }
        private void Do_Checked1()
        {
            button2.Enabled = checkBox2.Checked;
        }
        #endregion

        #region double ცვლადები

        double Leagues = 0;
        double Sample = 0;
        double MetruliGrami = 1;
        double MetruliGrami1 = 1;
        double SinjisRaodenoba = 1;
        double ligaturisRaodenoba = 1;
        double SinjisRaodenoba1 = 1;
        double ligaturisRaodenoba1 = 1;

        #endregion 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region სინჯები და ლიგატურები - მეტრულში 
        void sinjebi_double()
        {
            SinjisRaodenoba = Convert.ToDouble(numericUpDown3.Value / 1000);

        }
        void ligaturebi_double()
        {
            ligaturisRaodenoba = 1 - SinjisRaodenoba;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            // სინჯის რაოდენობა
            sinjebi_double();
            // ლიგატურების რაოდენობა 
            ligaturebi_double();
        }
        #endregion

        #region სინჯები და ლიგატურები - კარატულში 
        void sinjebi1_double()
        {
            SinjisRaodenoba1 = Convert.ToDouble(((numericUpDown4.Value) / 1000) * 42);


        }

        
        void ligaturebi1_double()
        {
            ligaturisRaodenoba1 = 1 - SinjisRaodenoba1;
        }
        #endregion
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            // კარატის რაოდენობა

            sinjebi1_double();
            ligaturebi1_double();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            // გრამების რაოდენობა - სინჯისთვის
            MetruliGrami = Convert.ToDouble(numericUpDown5.Value);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //სინჯი 1 - ოქრო
            Sample = 109;   // ოქრო 
            Color_button1S();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //სინჯი 2 - ვერცხლი
            Sample = 1;   // ვერცხლი
            Color_button2S();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // სინჯი 3 - ბრინჯაო
            Sample = 73;   // ბრინჯაო
            Color_button3S();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // სინჯი 6 - მელხიორი 
            Sample = 2;   // მელხიორი
            Color_button6S();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // სინჯი 5 - სპილენძი
            Sample = 0.02;   // სპილენძი
            Color_button5S();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //სინჯი 4 - პლატინა
            Sample = 75;   // პლატინა 
            Color_button4S();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            // ლიგატურა 1 - ვერცხლი
            Leagues = 1;   // ვერცხლი
            Color_button1L();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            // ლიგატურა 2 - სპილენძი
            Leagues = 0.02;   // სპილენძი 
            Color_button2L();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (((Sample * SinjisRaodenoba) + (ligaturisRaodenoba * Leagues)) * MetruliGrami).ToString();
            textBox2.Text = ((((Sample * SinjisRaodenoba) + (ligaturisRaodenoba * Leagues)) * MetruliGrami) / 2.5).ToString();
            textBox3.Text = ((((Sample * SinjisRaodenoba) + (ligaturisRaodenoba * Leagues)) * MetruliGrami) / 3).ToString();
            if (Leagues == 0 &&  Sample ==  0 ) { MessageBox.Show("თქვენ არ მიგითითბიათ არც ლიგატურა და არც სინჯი"); }
            else if (Leagues == 0) { MessageBox.Show("თქვენ არ მიგითითებიათ რომელი ლიგატურა გინდათ"); }
            else if (Sample == 0) { MessageBox.Show("თქვენ არ მიგითითებიათ რომელი სინჯი გინდათ"); }
            else { }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // დოლარი - მეტრული სისტემისთვის
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // ევრო - მეტრული სისტემისთვის
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            // გრამის რაოდენობა - კარატისთვის
            MetruliGrami1 = Convert.ToDouble(numericUpDown1.Value);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = (((Sample * SinjisRaodenoba1) + (ligaturisRaodenoba1 * Leagues)) * MetruliGrami1).ToString();
            textBox5.Text = ((((Sample * SinjisRaodenoba1) + (ligaturisRaodenoba1 * Leagues)) * MetruliGrami1) / 2.5).ToString();
            textBox4.Text = ((((Sample * SinjisRaodenoba1) + (ligaturisRaodenoba1 * Leagues)) * MetruliGrami1) / 3).ToString();
            if (Leagues == 0 && Sample == 0) { MessageBox.Show("თქვენ არ მიგითითბიათ არც ლიგატურა და არც სინჯი"); }
            else if (Leagues == 0) { MessageBox.Show("თქვენ არ მიგითითებიათ რომელი ლიგატურა გინდათ"); }
            else if (Sample == 0) { MessageBox.Show("თქვენ არ მიგითითებიათ რომელი სინჯი გინდათ"); }
            else { }
        }

        #region color_buttons 
        private void Color_button1S()
        {
            button5.BackColor = button4.BackColor = button8.BackColor = button7.BackColor = button6.BackColor = Color.LightGray;
            button3.BackColor = Color.Green;
        }
        private void Color_button2S()
        {
            button5.BackColor = button3.BackColor = button8.BackColor = button7.BackColor = button6.BackColor = Color.LightGray;
            button4.BackColor = Color.Green;
        }
        private void Color_button3S()
        {
            button4.BackColor = button3.BackColor = button8.BackColor = button7.BackColor = button6.BackColor = Color.LightGray;
            button5.BackColor = Color.Green;
        }
        private void Color_button4S()
        {
            button4.BackColor = button3.BackColor = button5.BackColor = button7.BackColor = button6.BackColor = Color.LightGray;
            button8.BackColor = Color.Green;
        }
        private void Color_button5S()
        {
            button4.BackColor = button3.BackColor = button5.BackColor = button8.BackColor = button6.BackColor = Color.LightGray;
            button7.BackColor = Color.Green;
        }
        private void Color_button6S()
        {
            button4.BackColor = button3.BackColor = button5.BackColor = button8.BackColor = button7.BackColor = Color.LightGray;
            button6.BackColor = Color.Green;
        }
        private void Color_button1L()
        {
            button10.BackColor = Color.LightGray;
            button9.BackColor = Color.Green;
        }
        private void Color_button2L()
        {
            button9.BackColor = Color.LightGray;
            button10.BackColor = Color.Green;
        }
        #endregion

        // tresh
        private void numericUpDown5_TabIndexChanged(object sender, EventArgs e)
        {
            // tresh
        }

        private void kalkulatori_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            
        }
    }
}

// giorgi samkharadze 
// sasertifikato davaleba