using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automa_calc_args
{
    public partial class Form1 : Form
    {
        private const int S0=0;
        private const int S1=1;
        private const int S2=2;
        private const int S3=3;
        int state = S0;
        private char cp;

        //creiamo un unico buffer per gli operandi

        private double[] buffer = new double[3];




        public Form1()
        {
            InitializeComponent();
        }

        private void automa(String fam, char operators) {

            switch(fam)
            {
                case "DGT":
                    switch (state)
                    {
                        case S0:
                        case S2:
                            txtDsp.Text += operators;
                            break;
                        case S1:
                        case S3:
                            txtDsp.Text = operators.ToString();
                            state = (state + 1) % 4;
                            break;
                    }

                    break;
               
                case "OP":
                    
                    switch (state)
                    {
                        case S0:
                            //primo numero inserito
                            this.memoryWrite(0);
                            state = S1;
                            break;
                        case S2:
                            this.memoryWrite(1);
                            this.compute();//esegue il calcolo
                            txtDsp.Text = buffer[2].ToString();
                            buffer[0] = buffer[2];
                            buffer[2] = 0;
                            state = S1;
                            break;
                        case S3:
                            buffer[0] = buffer[2];
                            buffer[2] = 0;//premuto un operando dopo il primo numero
                            state = S1;
                            break;
                            
                    }
                    cp = operators;

                    break;

            }


        }

        //elimina l'ultimo carattere dello schermo
        private void del_Click(object sender, EventArgs e)
        {
            String term = txtDsp.Text;
            int inL = term.Length;
            if (inL < 2)
            {
                term = "";
            }
            else
            {
                //crea una substringa con len=len-1
                term = term.Substring(0, inL - 1);
            }
            txtDsp.Text = term;
        }

        //riceve l'input dei bottoni
        private void btnDGT_Click(object sender, EventArgs e)
        {
            //conversione forzata a tipo Button
            Button btn = (Button)sender;
            char cifra = Convert.ToChar(btn.Text);
            //distinguiamo le classi di in attraverso i tag
            String tag = btn.Tag.ToString();
            this.automa(tag, cifra);

        }
        //gestisce le radici quadrate 'implementare radice cubica'
        private void rootClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tag = Convert.ToInt32(btn.Tag);
            double rootBuf = double.Parse(txtDsp.Text);
            //sfruttiamo un tag
            if (tag == 2 && rootBuf>=0)//C.E. per la radice quadrata(sennò non viene svolta);
            {
                txtDsp.Text = Math.Sqrt(rootBuf).ToString();
            }
            else
            {

            }
            this.update();
        }

        //gestisce i logaritmi
        private void button5_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            String tagr = btn.Tag.ToString();
            double logBuf = double.Parse(txtDsp.Text);
            //stesso sistema di tag per un'unica gestione 
            if (logBuf > 0)
            {
                if (tagr == "e")
                {
                    txtDsp.Text = Math.Log(logBuf).ToString();
                }
                else
                {
                    txtDsp.Text = Math.Log10(logBuf).ToString();
                }
            }
            this.update();
            
        }
        //puuutente veramente (Abatantuono)
        private void pow_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tagp = Convert.ToInt32(btn.Tag);
            double powBuf = double.Parse(txtDsp.Text);
            if (tagp == 2 )
            {
                txtDsp.Text = (powBuf*powBuf).ToString();
                //inutile implementare una nuova istanza di math
            }
            else
            {
                txtDsp.Text = (powBuf * powBuf * powBuf).ToString();
            }
            this.update();
        }
        //moltiplica per -1 il numero su display
        //cambio segno
        private void sign_Click(object sender, EventArgs e)
        {
            txtDsp.Text = (double.Parse(txtDsp.Text) * (-1)).ToString();
            this.update();
        } 

        //"I want to break free" cit.
        private void clean_Click(object sender, EventArgs e)
        {
            this.cleanScreen();
            state = S0;
            this.resetBuffer(0);
        }

        //un po di funzioni piuttosto inutili
        private void cleanScreen()
        {
            txtDsp.Text = "";

            //penso sia chiaro :)
           
        }

        private void resetBuffer(double value)
        {
            buffer[0] = value;
            buffer[1] = value;
            buffer[2] = value;
        }

        //giusto per farlo sembrare C
        //qui si puo fare un bof se disattivo la randomizzazione degli indirizzi
        private void memoryWrite(int bufInd)
        {
            buffer[bufInd] = double.Parse(txtDsp.Text);
        }

        private void comma_Click(object sender, EventArgs e)
        {
            Button com = (Button)sender;

            if (!txtDsp.Text.Contains(','))
                //aggiunge una virgola solo se non ne è presente un'altra
            {
                txtDsp.Text += ',';
            }
        }

        private void compute()
        {
            switch (cp)
            {
                //esegue l'operazione sula base dell'operatore che trova
                case '+':
                    buffer[2] = buffer[0] + buffer[1];
                    break;
                case '-':
                    buffer[2] = buffer[0] - buffer[1];
                    break;
                case '*':
                    buffer[2] = buffer[0] * buffer[1];
                    break;
                case '/':
                    if (buffer[1] != 0)
                    {
                        buffer[2] = buffer[0] / buffer[1];
                    }
                    //C.E. per la divisione come al solito
                    else
                    {
                        MessageBox.Show("Zero division not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buffer[2] = 0;
                    }
                    break;

            }

        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (state == S2)
            {
                this.memoryWrite(1);
                this.compute();
                txtDsp.Text = buffer[2].ToString();
                //stampa e va in S3
                state = S3;
            }
        }
        //fa un update di bufferzero anche se si aspetta una cifra 
        private void update()
        {
            if (state == S1)
            {
                this.memoryWrite(0);
            }
        }
    }
}
