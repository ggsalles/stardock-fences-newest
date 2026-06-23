using System.Windows.Forms;
using WEDLC.Forms;

namespace WEDLC.Banco
{
    public static class InputBoxClass
    {
        public static string Show(string prompt, string title = "Entrada", string defaultValue = "")
        {
            using (var form = new InputBoxForm(prompt, title, defaultValue))
            {
                return form.ShowDialog() == DialogResult.OK
                    ? form.InputValue
                    : null;
            }
        }
    }
}