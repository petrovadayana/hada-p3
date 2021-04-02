using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace hada_p3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void button0_Click(object sender, EventArgs e)    // leer
        {

            string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);

            ENUsuario usuario = new ENUsuario();

            usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);

            usuario.readUsuario();
        }

        protected void button1_Click(object sender, EventArgs e)    // leer primero
        {
            /*string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);*/

            ENUsuario usuario = new ENUsuario();

           /* usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);*/

            usuario.readFirstUsuario();

        }

        protected void button2_Click(object sender, EventArgs e)    // leer anterior
        {
            string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);

            ENUsuario usuario = new ENUsuario();

            usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);

            usuario.readPrevUsuario();
        }

        protected void button3_Click(object sender, EventArgs e)    // leer siguiente
        {
            string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);

            ENUsuario usuario = new ENUsuario();

            usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);           

            usuario.readNextUsuario();
        }

        protected void button4_Click(object sender, EventArgs e) // crear usuario
        {
            string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);

            ENUsuario usuario = new ENUsuario();

            usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);

            usuario.createUsuario();
        }

        protected void button5_Click(object sender, EventArgs e)    // actualizar usuario
        {
            string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);

            ENUsuario usuario = new ENUsuario();

            usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);

            usuario.updateUsuario();
        }

        protected void button6_Click(object sender, EventArgs e)    // borrar usuario
        {
            string recuadroNIF = TextBox0.Text;
            string recuadroNOM = TextBox1.Text;
            int recuadroEDAD = Int32.Parse(TextBox2.Text);

            ENUsuario usuario = new ENUsuario();

            usuario.setNif(recuadroNIF);
            usuario.setNombre(recuadroNOM);
            usuario.setEdad(recuadroEDAD);

            usuario.deleteUsuario();
        }
    }
}