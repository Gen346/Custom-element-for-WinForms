using System;
using System.Windows.Forms;

namespace Лабораторна_робота_12
{
    public class CustomTimer : Timer
    {
        public Control _komponent { get; set; }

        public event EventHandler OnVisibles;

        public CustomTimer()
        {
            this.Tick += new EventHandler(OnTick);
        }

        private void OnTick(object sender, EventArgs e)
        {
            Visibles();
        }

        public void Visibles()
        {
            if (_komponent != null)
            {
                _komponent.Visible = !_komponent.Visible;
                OnVisibles?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
