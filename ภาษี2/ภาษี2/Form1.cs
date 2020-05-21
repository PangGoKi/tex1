using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ภาษี2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            status1.SelectedItem = "โสด";
        }
        double M, sum1, sum2, sum3, sum4, sum5 ; 
        private void status1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        //เงินบริจาค
        double temp;
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            sum4 = 0;
            temp = M * 0.1; // 10% ของรายได้
            sum4 += double.Parse(textBox29.Text);
            sum4 += double.Parse(textBox28.Text);
            sum4 += double.Parse(textBox27.Text);
            sum4 += double.Parse(textBox26.Text);
            sum4 += double.Parse(textBox25.Text);
            sum4 = sum4 * 2;

            if (sum4 >= temp) sum4 += temp;

            if (double.Parse(textBox24.Text) >= temp) sum4 += temp;
            else sum4 += double.Parse(textBox24.Text);

            if (double.Parse(textBox23.Text) >= 10000) sum4 += 10000;
            else sum4 += double.Parse(textBox23.Text);

        }

        //กระตุ้นเศรษฐกิจ

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            double A; //ช่วยชาติ
            double OTOP;
            double B; //กีฬา
            double C; //ท่องเที่ยวหลัก
            double D; //ท่อวเที่ยวรอง
            double sum; //รวมท่องเที่ยว
            double E; //อสังหา ปาบึก
            double F; //รถ 
            double G; //โพดุล อสังหา
            double H; //รถ
            if (int.Parse(textBox19.Text) > 15000)  // ช่วยชาติ
            {
                A = 15000;
            }
            else
            {
                A = int.Parse(textBox19.Text);
            }
            if (int.Parse(textBox18.Text) > 15000) //OTOP
            {
                OTOP = 15000;
            }
            else
            {
                OTOP = int.Parse(textBox18.Text);
            }
            if (int.Parse(textBox17.Text) > 15000)//กีฬา
            {
                B = 15000;
            }
            else
            {
                B = int.Parse(textBox17.Text);
            }
            if (int.Parse(textBox16.Text) > 15000) //เที่ยวหลัก
            {
                C = 15000;

            }
            else
            {
                C = int.Parse(textBox16.Text);
            }
            if (int.Parse(textBox10.Text) > 20000) //เที่ยวรอง
            {
                D = 20000;
            }
            else
            {
                D = int.Parse(textBox10.Text);
            }
            if (C + D > 20000) //รวมเที่ยว
            {
                sum = 20000;
            }
            else
            {
                sum = C + D;
            }
            if (int.Parse(textBox15.Text) > 100000) //ปาบึก อสังหา
            {
                E = 100000;
            }
            else
            {
                E = int.Parse(textBox15.Text);
            }
            if (int.Parse(textBox14.Text) > 30000) // ปาบึกรถ
            {
                F = 30000;
            }
            else
            {
                F = int.Parse(textBox14.Text);
            }
            if (int.Parse(textBox13.Text) > 100000) // โพดุล อสังหา
            {
                G = 100000;
            }
            else
            {
                G = int.Parse(textBox13.Text);
            }
            if (int.Parse(textBox12.Text) > 30000) //โพดุล รถ
            {
                H = 30000;
            }
            else
            {
                H = int.Parse(textBox12.Text);
            }
            sum5 = sum + A + OTOP + B + E + F + G + H;
        }


        //ภาษีที่ต้องจ่าย
        double panggoki;
        private void button1_Click(object sender, EventArgs e)
        {
            show.Text = M.ToString();
            panggoki = M - sum1 - sum2 - sum3 - sum4 - sum5;
            if(panggoki < 0) //ขั้นที่ 1 ไม่จ่ายภาษี
            {
                panggoki = 0;
            }
            if (panggoki >= 0 && panggoki <= 150000)
            {
                panggoki = 0;
            }
            else if (panggoki > 150000 && panggoki <= 300000) //ขั้นที่2 5%
            {
                panggoki = (panggoki - 150000) * 0.05;
            }
            else if (panggoki > 300000 && panggoki <= 500000) //ขั้นที่3 10%
            {
                panggoki = ((panggoki - 300000) * 0.1) + 7500;
            }
            else if (panggoki > 500000 && panggoki <= 750000) //ขั้นที่4 15%
            {
                panggoki = ((panggoki - 500000) * 0.15) + 27500;
            }
            else if (panggoki > 750000 && panggoki <= 1000000)//ขั้นที่5 20%
            {
                panggoki = ((panggoki - 750000) * 0.2) + 65000;
            }
            else if (panggoki > 1000000 && panggoki <= 2000000)//ขั้นที่6 25%
            {
                panggoki = ((panggoki - 1000000) * 0.25) + 115000;
            }
            else if (panggoki > 2000000 && panggoki <= 5000000)//ขั้นที่7 30%
            {
                panggoki = ((panggoki - 2000000) * 0.3) + 365000;
            }
            else if (panggoki > 5000000) //ขั้นที่8 35%
            {
                panggoki = ((panggoki - 5000000) * 0.35) + 1265000; 
            }
            textBox2.Text = panggoki.ToString();
        }

        //ครอบครัว
        private void moneyyears_ValueChanged(object sender, EventArgs e)
        {
            sum1 = 0;
            M = double.Parse(moneyyears.Text) * 12; //รายได้ต่อเดือน
            int A = int.Parse(textBox32.Text) * 30000; //บุตรที่เกิดก่อนปี61
            int B = int.Parse(textBox31.Text); //บุตรที่เกิดหลังปี61
            int C = Convert.ToInt32(numericUpDown1.Value) * 30000; //จำนวนที่อุปการะบิดามารดา
            int D = int.Parse(textBox30.Text) * 60000; //จำนวนอุปการะผู้พิการ
            int E = Convert.ToInt32(numericUpDown2.Value); //ฝากครรภ์และคลอดบุตร
            if (M * 0.5 > 100000)
            {
                sum1 += 100000;
            }
            else
            {
                sum1 += M * 0.05;
            }
            if (status1.Text == "สมรส(คู่สมรสไม่มีรายได้)")
            {
                sum1 += 120000;
            }
            else
            {
                sum1 += 60000;
            }
            if (B > 0) //บุตร
            {
                if (A == 0)
                {
                    sum1 += ((B - 1) * 60000) + 30000;
                }
                else
                {
                    sum1 += 60000;
                }
            }
            else
            {
                sum1 += 0;
            }


            sum1 = sum1 + A + C + D + E;
        }
        //ประกัน
        double X; //เลี้ยงชีพ
        double Y; //กองทุน
        double Z; //บำนาญ
        double LTF;
        double RMF;
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            double A; //ประกันสังคม
            double B; //เบี้ยประกันชีวิต
            double C; //เบี้ยปะกันสุขภาพ
            double sum; //เก็บค่า ชีวิต + สุขภาพ
            double D; // บิดามารดา
            double E; //สมรส

            double H; //กอช

            sum2 = 0;
            if (int.Parse(textBox22.Text) > 9000)  // ประกังสังคม
            {
                A = 9000;
            }
            else
            {
                A = int.Parse(textBox22.Text);
            }
            if (int.Parse(textBox21.Text) > 100000) //ประกันชีวิต
            {
                B = 100000;
            }
            else
            {
                B = int.Parse(textBox21.Text);
            }
            if (int.Parse(textBox20.Text) > 15000)//ประกันสุขภาพ
            {
                C = 15000;
            }
            else
            {
                C = int.Parse(textBox20.Text);
            }
            if (B + C > 100000) // สุขภาพ + ชีวิต
            {
                sum = 100000;
            }
            else
            {
                sum = B + C;
            }
            if (int.Parse(textBox9.Text) > 15000) //บิดามารดา
            {
                D = 15000;
            }
            else
            {
                D = int.Parse(textBox9.Text);
            }
            if (int.Parse(textBox6.Text) > 10000) //สมรส
            {
                E = 10000;
            }
            else
            {
                E = int.Parse(textBox6.Text);
            }
            if (int.Parse(textBox7.Text) > 500000) //เลี้ยงชีพ
            {
                X = 500000;
            }
            else if (int.Parse(textBox7.Text) > M * 0.15)
            {
                X = M * 0.15;
            }
            if (int.Parse(textBox8.Text) > 500000) //กบข
            {
                Y = 500000;
            }
            else if (int.Parse(textBox8.Text) > M * 0.15)
            {
                Y = M * 0.15;

            }
            if (int.Parse(textBox5.Text) > 13200) //กอช
            {
                H = 13200;
            }
            else
            {
                H = int.Parse(textBox5.Text);
            }
            if (int.Parse(textBox8.Text) > 200000) //บำนาญ
            {
                Z = 200000;
            }
            else if (int.Parse(textBox8.Text) > M * 0.15)
            {
                Z = M * 0.15;
            }
            if (int.Parse(textBox8.Text) > 500000) //LTF
            {
                LTF = 500000;
            }
            else if (int.Parse(textBox8.Text) > M * 0.15)
            {
                LTF = M * 0.15;

            }
            if (int.Parse(textBox8.Text) > 500000) //RMF
            {
                RMF = 500000;
            }
            else if (int.Parse(textBox8.Text) > M * 0.15)
            {
                RMF = M * 0.15;

            }
            sum2 = A + B + C + sum + D + E + X + Y + H + Z + LTF + RMF;
        }
            //คำนวณอสังหา
        double Home;
        double Home58;
        double Home62;
        private void textBox35_TextChanged(object sender, EventArgs e)
        
        {
            sum3 = 0;
            Home = double.Parse(textBox35.Text);
            if (Home >= 100000) Home = 100000; 
            if (double.Parse(textBox34.Text) <= 3000000)//58
            {
                Home58 = double.Parse(textBox34.Text) * 0.04;
                if (Home58 >= 120000) Home58 = 120000;
            }
            if (double.Parse(textBox33.Text) <= 5000000)//62
            {
                if (double.Parse(textBox33.Text) <= 200000)
                    Home62 = double.Parse(textBox33.Text);
                else
                    Home62 = 200000;
            }
            sum3 = Home + Home58 + Home62;
        }
    }
}

