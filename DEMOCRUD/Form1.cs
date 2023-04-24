namespace DEMOCRUD
{
    public partial class Form1 : Form
    {
        frmAgenda AgendaForm;
        frmCEP CEPForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (AgendaForm == null)
            {
                AgendaForm = new frmAgenda();
                AgendaForm.MdiParent = this;
                AgendaForm.WindowState = FormWindowState.Maximized;
                AgendaForm.Show();


            }
           else  { 
                AgendaForm.Activate();
            }
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CEPForm == null)
            {
                CEPForm = new frmCEP();
                CEPForm.MdiParent = this;
                CEPForm.WindowState = FormWindowState.Maximized;
                CEPForm.Show();


            }
            else
            {
                CEPForm.Activate();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Sobreform = new frmSobre();
            Sobreform.ShowDialog();
        }
    }
}