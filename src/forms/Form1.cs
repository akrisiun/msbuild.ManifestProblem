using System;
using System.Windows.Forms;

namespace forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
}

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Output?.Invoke(this);
        }

        public Action<Form1> Output { get; set; }
    }
}
