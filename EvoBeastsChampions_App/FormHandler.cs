using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoBeastsChampions_App
{
    internal class FormHandler
    {
        public FormHandler() 
        { 
        
        }

        public void OpenForm<T>() where T : Form, new()
        {
            T newForm = new T();
            newForm.Show();
        }

        public void HideForm<T>() where T : Form
        {
            T form = FormExists<T>();

            if (form != null)
            {
                form.Hide();
            }
        }

        private T FormExists<T>() where T : Form
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault();
        }
    }
}