using System;
using System.Windows.Forms;

namespace Лабораторна_робота_12
{
    public partial class Form1 : Form
    {
        private CustomTimer customTimer;
        private Button button;
        private Label label;
        private bool isLabelVisible = true;

        public Form1()
        {
            InitializeComponent();
            ComponentLoader();
        }
        private void ComponentLoader()
        {
            button = new Button
            {
                Text = "Click Me",
                Location = new System.Drawing.Point(50, 50)
            };
            button.Click += Button_Click;
            this.Controls.Add(button);

            label = new System.Windows.Forms.Label
            {
                Text = "Hello, World!",
                Location = new System.Drawing.Point(50, 100)
            };
            this.Controls.Add(label);

            customTimer = new CustomTimer
            {
                Interval = 3000, // In ms;
                _komponent = label
            };
            customTimer.OnVisibles += CustomTimer_OnVisibles;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (isLabelVisible)
            {
                customTimer.Start();
            }
            else
            {
                customTimer.Start();
            }
        }

        private void CustomTimer_OnVisibles(object sender, EventArgs e)
        {
            isLabelVisible = !isLabelVisible;
            customTimer.Stop();
        }
    }
}
