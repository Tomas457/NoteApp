using System.Data;

namespace NoteApp
{
    public partial class Notes : Form
    {
        DataTable table;
        public Notes()
        {
            InitializeComponent();

            newBut.FlatAppearance.MouseOverBackColor = Color.Gray;
            newBut.FlatAppearance.MouseDownBackColor = Color.White;

            readBut.FlatAppearance.MouseOverBackColor = Color.Gray;
            readBut.FlatAppearance.MouseDownBackColor = Color.White;

            saveBut.FlatAppearance.MouseOverBackColor = Color.Gray;
            saveBut.FlatAppearance.MouseDownBackColor = Color.White;

            deleteBut.FlatAppearance.MouseOverBackColor = Color.Gray;
            deleteBut.FlatAppearance.MouseDownBackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messege", typeof(String));

            dataGridView2.DataSource = table;

            dataGridView2.Columns["Messege"].Visible = false;
            dataGridView2.Columns["Title"].Width = 262;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
        }

        private void newBut_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessege.Clear();
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessege.Text);

            txtTitle.Clear();
            txtMessege.Clear();
        }

        private void readBut_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            if (index >= 0)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessege.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}