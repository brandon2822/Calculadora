using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication2
{
    public partial class Form1 : System.Web.UI.Page
    {
        float resultado;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        //Listbox
        private void Listb()
        {
            if (ListBox1.Text == "Suma")
            {
                resultado = float.Parse(txtNum7.Text) + float.Parse(txtNum8.Text);
            }
            else if (ListBox1.Text == "Resta")
            {
                resultado = float.Parse(txtNum7.Text) - float.Parse(txtNum8.Text);
            }
            else if (ListBox1.Text == "Multiplicacion")
            {
                resultado = float.Parse(txtNum7.Text) * float.Parse(txtNum8.Text);
            }
            else if (ListBox1.Text == "Division")
            {
                resultado = float.Parse(txtNum7.Text) / float.Parse(txtNum8.Text);
            }
            else
            {
                resultado = 0;
                MessageBox.Show("Debe seleccionar una opcion");
                Clear(txtNum7, txtNum8);
            }

            lResultado4.Text = resultado.ToString();
            Clear(txtNum7, txtNum8);
        }

        //Radio
        private void Operacion()
        {
            if (Suma.Checked)
            {
                 resultado = float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text);
            }
            else if (Resta.Checked)
            {
                 resultado = float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text);
            }
            else if (Multiplicacion.Checked)
            {
                 resultado = float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text);
            }
            else if (Division.Checked) 
            {
                 resultado = float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
            lResultado.Text = resultado.ToString();
            Clear(txtNum1, txtNum2);


        }


        //Drop Down list
        private void DropList()
        {
            if(DropDownList1.Text == "Suma")
            {
                resultado = float.Parse(txtNum3.Text) + float.Parse(txtNum4.Text);
            } else if (DropDownList1.Text == "Resta")
            {
                resultado = float.Parse(txtNum3.Text) - float.Parse(txtNum4.Text);
            }
            else if(DropDownList1.Text == "Multiplicacion")
            {
                resultado = float.Parse(txtNum3.Text) * float.Parse(txtNum4.Text);
            }
            else if(DropDownList1.Text == "Division")
            {
                resultado = float.Parse(txtNum3.Text) / float.Parse(txtNum4.Text);
            }
            
            lResultado2.Text = resultado.ToString();
            Clear(txtNum3, txtNum4);
        }

        //Checkbox
        private void CheckboxOption()
        {
            int checkBox_checked = 0;
            if (CheckBox1.Checked) checkBox_checked++;
            if (CheckBox2.Checked) checkBox_checked++;
            if (CheckBox3.Checked) checkBox_checked++;
            if (CheckBox4.Checked) checkBox_checked++;

            if (checkBox_checked > 1)
            {
                MessageBox.Show("Seleccione solo una opcion");
                CheckBox1.Checked = false;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
            }
            else
            {
                if (CheckBox1.Checked)
                {
                    resultado = float.Parse(txtNum5.Text) + float.Parse(txtNum6.Text);
                }
                else if (CheckBox2.Checked)
                {
                    resultado = float.Parse(txtNum5.Text) - float.Parse(txtNum6.Text);
                }
                else if (CheckBox3.Checked)
                {
                    resultado = float.Parse(txtNum5.Text) * float.Parse(txtNum6.Text);
                }
                else if (CheckBox4.Checked)
                {
                    resultado = float.Parse(txtNum5.Text) / float.Parse(txtNum6.Text);
                }
            }
                lResultado3.Text = resultado.ToString();
                Clear(txtNum5, txtNum6);
        }

        //Limpiar Textbox
        private void Clear(TextBox txt1, TextBox txt2)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
        }

        protected void btnOperacion_Click(object sender, EventArgs e)
        {

            Operacion();
            
            
        }

        protected void btnOperacion2_Click(object sender, EventArgs e)
        {
            DropList();
        }

        protected void btnOperacion3_Click(object sender, EventArgs e)
        {
            CheckboxOption();
        }

        protected void btnOperacion4_Click(object sender, EventArgs e)
        {
            Listb();
        }
    }
}