using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Utilitarios.SACC
{
    class Fuentes
    {
        public void aplicarFuentes(ControlCollection controls)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Fonts\Roboto-Regular.ttf");
            foreach (Control c in controls)
            {
                c.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            }
        }
    }
}
