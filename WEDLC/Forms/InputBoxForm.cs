using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEDLC.Forms
{
    public partial class InputBoxForm : Form
    {
        private Label lblPrompt;
        private TextBox txtInput;
        private Button btnOK;
        private Button btnCancel;

        public string InputValue => txtInput.Text;

        public InputBoxForm(string prompt, string title = "Entrada", string defaultValue = "")
        {
            Text = title;
            Width = 400;
            Height = 180;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;

            lblPrompt = new Label
            {
                Text = prompt,
                Left = 10,
                Top = 20,
                Width = 360
            };

            txtInput = new TextBox
            {
                Left = 10,
                Top = 50,
                Width = 360,
                Text = defaultValue
            };

            btnOK = new Button
            {
                Text = "OK",
                Left = 210,
                Top = 90,
                Width = 75,
                DialogResult = DialogResult.OK
            };

            btnCancel = new Button
            {
                Text = "Cancelar",
                Left = 295,
                Top = 90,
                Width = 75,
                DialogResult = DialogResult.Cancel
            };

            AcceptButton = btnOK;
            CancelButton = btnCancel;

            Controls.AddRange(new Control[] { lblPrompt, txtInput, btnOK, btnCancel });
        }
    }
}
