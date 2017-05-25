using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Sklad3.UI
{
    class FormHolder<T> where T : XtraForm, new()
    {
        private T _form;

        public void Show()
        {
            if (_form != null && _form.Created)
            {
                _form.Show();
                _form.Activate();
                _form.WindowState = FormWindowState.Normal;
            }
            else
            {
                _form = new T();
                _form.Show(MainForm.Inst);
            }
        }
    }
}
