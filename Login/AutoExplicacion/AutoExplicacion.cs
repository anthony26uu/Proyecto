using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoExplicacion
{
    public class AutoExplicacion : TextBox
    {
        public string texto;

        [Category("Texto Vacio")]
        public string TextoVacio
        {
            get { return texto; }
            set { texto = value; }
        }
        private Color colortextoV;

        private Color ColortextoV
        {
            get { return colortextoV; }
            set { colortextoV = value; }
        }
        bool bndTextoV = false;

        public AutoExplicacion()
        {
            colortextoV = Color.Gray;
            TextoVacio = "<Descripcion>";
        }

        private void Verificar()

        {
            if (this.TextoVacio.Length > 0)
           
                bndTextoV = false;

           
            else
            
                bndTextoV = true;
                this.SetStyle(ControlStyles.UserPaint, bndTextoV);// Accede al evento\
                this.Refresh();//Actualizar el texbox
            
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Verificar();
        }
        protected override void OnTextAlignChanged(System.EventArgs e)
        {
            base.OnTextAlignChanged(e);
            Verificar();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (bndTextoV)
           
                e.Graphics.DrawString(TextoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(colortextoV), new Point(0, 0));

           
            else
            
                e.Graphics.DrawString(this.texto, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
                base.OnPaint(e);
            
        }

        private void InitializeComponent()
        {

        }
    }
}
