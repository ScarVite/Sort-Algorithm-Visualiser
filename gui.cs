using System.Windows.Forms;

namespace Sort_Algorithm_Visualiser
{
    public partial class gui : Form
    {
        public gui()
        {
            InitializeComponent(); 
        }

        private void gui_Load(object sender, System.EventArgs e)
        {
            main.init();
        }
    }
}
