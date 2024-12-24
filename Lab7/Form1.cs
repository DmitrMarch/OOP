namespace Lab7
{
    public partial class Form1 : Form
    {
        private static int _selectedRowIndx = -1;
        private static String _pathToFile = "";

        public Form1()
        {
            InitializeComponent();

            Student st = new("amogus", "", "", "", "", "");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string fullname = FullnameField.Text;
            string record_book = RecordBookField.Text;
            string department = DepartmentField.Text;
            string specification = SpecificationField.Text;
            string group = GroupField.Text;
            string date_of_admission = DateOfAdmissionField.Text;

            if (fullname == "" || record_book == "" || department == "" ||
                specification == "" || group == "" || date_of_admission == "")
            {
                MessageBox.Show("Заполните все пустые поля");
                return;
            }

            DataGridView students = this.StudentsTbl;
            int row_indx = students.Rows.Add();
            var cells = students.Rows[row_indx].Cells;

            cells["Fullname"].Value = fullname;
            cells["RecordBook"].Value = record_book;
            cells["Department"].Value = department;
            cells["Specification"].Value = specification;
            cells["Group"].Value = group;
            cells["DateOfAdmission"].Value = date_of_admission;

            students.ClearSelection();
            students.Rows[row_indx].Selected = true;
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndx == -1)
            {
                MessageBox.Show("Сначала выберите строку");
                return;
            }

            string fullname = FullnameField.Text;
            string record_book = RecordBookField.Text;
            string department = DepartmentField.Text;
            string specification = SpecificationField.Text;
            string group = GroupField.Text;
            string date_of_admission = DateOfAdmissionField.Text;

            if (fullname == "" || record_book == "" || department == "" ||
                specification == "" || group == "" || date_of_admission == "")
            {
                MessageBox.Show("Заполните все пустые поля");
                return;
            }

            var cells = StudentsTbl.Rows[_selectedRowIndx].Cells;

            cells["Fullname"].Value = fullname;
            cells["RecordBook"].Value = record_book;
            cells["Department"].Value = department;
            cells["Specification"].Value = specification;
            cells["Group"].Value = group;
            cells["DateOfAdmission"].Value = date_of_admission;

            DataGridView students = this.StudentsTbl;
            students.ClearSelection();
            students.Rows[_selectedRowIndx].Selected = true;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DataGridView students = this.StudentsTbl;

            foreach (DataGridViewRow row in students.SelectedRows)
            {
                students.Rows.RemoveAt(row.Index);
            }
        }

        private void StudentsTbl_SelectionChanged(object sender, EventArgs e)
        {
            var rows = StudentsTbl.SelectedRows;

            if (rows.Count == 0) 
            { 
                return; 
            }

            var cell = rows[0].Cells[0];

            _selectedRowIndx = cell.RowIndex;

            var cells = cell.OwningRow.Cells;

            string fullname = (string)cells["Fullname"].Value;
            string record_book = (string)cells["RecordBook"].Value;
            string department = (string)cells["Department"].Value;
            string specification = (string)cells["Specification"].Value;
            string group = (string)cells["Group"].Value;
            string date_of_admission = (string)cells["DateOfAdmission"].Value;

            FullnameField.Text = (string)cells["Fullname"].Value;
            RecordBookField.Text = (string)cells["RecordBook"].Value;
            DepartmentField.Text = (string)cells["Department"].Value;
            SpecificationField.Text = (string)cells["Specification"].Value;
            GroupField.Text = (string)cells["Group"].Value;
            DateOfAdmissionField.Text = (string)cells["DateOfAdmission"].Value;
        }
    }
}
