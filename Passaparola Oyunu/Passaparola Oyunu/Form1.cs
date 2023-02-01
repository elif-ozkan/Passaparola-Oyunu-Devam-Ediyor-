using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
             int soruno = 0, dogru = 0, yanlış = 0;
        }
        int soruno = 0, dogru = 0, yanlış = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Tuşlara görev ataması yaptığımız zaman kullanırız
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();

                        }
                        break;
                        case 2:
                        if(textBox1.Text=="bursa")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor= Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label3.Text= dogru.ToString();  
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;
                    case 7:
                        if(textBox1.Text == "güneş")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;
                }

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = "Ülkemizdeki güney kısmındaki kıyı bölgesi hangisidir?";
                button4.BackColor = Color.Yellow;

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Ülkemizdeki yeşilliği ile meşhur Marmara ili hangisidir?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü hangisidir?";
                button6.BackColor = Color.Yellow;
            }
            if(soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz hangisidir?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin eş anlamlısı nedir?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın yazılı emirlerine ne ad verilir?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağına ne ad verilir?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiklerinde bakıştıkları nesne?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz hangisidir?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersin ilinin diğer ismi nedir?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk adı?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali?";
                button16.BackColor = Color.Yellow;
            }
            if(soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı nedir?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi sözünün eş anlamlısı nedir?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların fazla sevmediği pirinç,havuç gibi sebzelerle yapılan yemek?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                button21.BackColor= Color.Yellow;
            }
            if(soruno == 19){
                richTextBox1.Text = "İngilizcede yılan kelimesinin karşılığı nedir?";
                button22.BackColor = Color.Yellow;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiye'nin megastarı kimdir?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı nedir?";
                button24.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile meşhur ilimiz hangisidir?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı nedir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege Bölgesinde en çok ağacı olan bitki hangisidir?";
                button3.BackColor = Color.Yellow;
            }


        }
    }
}
