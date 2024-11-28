using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    public partial class ConditionsForms : Form
    {
        Loan loan;
        List<Devolution> devolutions;
        DataGridView dataGridView;
        public ConditionsForms(Loan loan, List<Devolution> devolutions, DataGridView dataGrid)
        {
            InitializeComponent();
            this.loan = loan;
            this.devolutions = devolutions;
            this.dataGridView = dataGrid;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            ReturnCondition returnCondition = ReturnCondition.Intacto;
            decimal fineAmount = 0m;
            if (RbtnBuen.Checked)
            {
                returnCondition = ReturnCondition.Intacto;
                fineAmount = 0;
            }
            else if (RbtnRegular.Checked)
            {
                returnCondition = ReturnCondition.Regular;
                fineAmount = 20;
            }
            else if (RbtnDañado.Checked)
            {
                Fine fine = new FineforDamage(loan, 0, "Daño en el libro");
                fineAmount = fine.CalculateFine();
                returnCondition = ReturnCondition.Dañado;
            }

            Devolution devolution = new Devolution(loan.Loan_Code, loan.Book.Title, loan.Student_name.Name, DateTime.Now, returnCondition, fineAmount);

            devolutions.Add(devolution);

            

            MessageBox.Show("Devolución registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
