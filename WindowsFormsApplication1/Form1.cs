using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const int sizeArray = 1000;
        int[] arrayR = new int[sizeArray];
        Random r = new Random();
        int temp;
        int verifications;
        int ticks = 1;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sizeArray; i++)
            {
                arrayR[i] = r.Next(10000);
                chart1.Series["Series1"].Points.AddY(arrayR[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayR.Length; i++)
            {
                chart1.Series["Series1"].Points.Clear();
                for (int a = 0; a < sizeArray; a++)
                {
                    chart1.Series["Series1"].Points.AddY(arrayR[a]);
                }
                for (int z = i + 1; z < arrayR.Length; z++)
                {
                    if (arrayR[i] > arrayR[z])
                    {
                        temp = arrayR[i];
                        arrayR[i] = arrayR[z];
                        arrayR[z] = temp;
                    }
                    verifications++;
                }
                ticks ++;
                chart2.Series["Series2"].Points.AddXY(ticks, verifications);
            }
            
            
        }

        
    
    }
}
