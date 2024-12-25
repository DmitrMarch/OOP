namespace Lab7
{
    public partial class Form1 : Form
    {
        private static int _selectedRowIndx = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string fullname = fullnameField.Text;
            string record_book = recordBookField.Text;
            string department = departmentField.Text;
            string specification = specificationField.Text;
            string group = groupField.Text;
            string date_of_admission = dateOfAdmissionField.Text;

            if (fullname == "" || record_book == "" || department == "" ||
                specification == "" || group == "" || date_of_admission == "")
            {
                MessageBox.Show("Заполните все пустые поля");
                return;
            }

            if (record_book.ma)

            DataGridView students = this.studentsTbl;
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

        private void modBtn_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndx == -1)
            {
                MessageBox.Show("Сначала выберите строку");
                return;
            }

            string fullname = fullnameField.Text;
            string record_book = recordBookField.Text;
            string department = departmentField.Text;
            string specification = specificationField.Text;
            string group = groupField.Text;
            string date_of_admission = dateOfAdmissionField.Text;

            if (fullname == "" || record_book == "" || department == "" ||
                specification == "" || group == "" || date_of_admission == "")
            {
                MessageBox.Show("Заполните все пустые поля");
                return;
            }

            DataGridView students = this.studentsTbl;
            var cells = students.Rows[_selectedRowIndx].Cells;

            cells["Fullname"].Value = fullname;
            cells["RecordBook"].Value = record_book;
            cells["Department"].Value = department;
            cells["Specification"].Value = specification;
            cells["Group"].Value = group;
            cells["DateOfAdmission"].Value = date_of_admission;

            students.ClearSelection();
            students.Rows[_selectedRowIndx].Selected = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataGridView students = this.studentsTbl;

            foreach (DataGridViewRow row in students.SelectedRows)
            {
                students.Rows.RemoveAt(row.Index);
            }
        }

        private void studentsTbl_SelectionChanged(object sender, 
            EventArgs e)
        {
            var rows = studentsTbl.SelectedRows;

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
            string date_of_admission = (string)cells
                ["DateOfAdmission"].Value;

            fullnameField.Text = (string)cells["Fullname"].Value;
            recordBookField.Text = (string)cells["RecordBook"].Value;
            departmentField.Text = (string)cells["Department"].Value;
            specificationField.Text = (string)cells["Specification"].Value;
            groupField.Text = (string)cells["Group"].Value;
            dateOfAdmissionField.Text = (string)cells
                ["DateOfAdmission"].Value;
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            string file_type = fileTypeField.Text;
            string file_type_lower = file_type.ToLower();
            OpenFileDialog file_dialog = new();

            file_dialog.Title = $"Выберите {file_type} файл";
            file_dialog.Filter = $"{file_type} " +
                $"(*.{file_type_lower})|*.{file_type_lower}";

            DialogResult dr = file_dialog.ShowDialog();

            if (dr != DialogResult.OK)
            {
                return;
            }

            string path_to_file = file_dialog.FileName;
            List<Student> students_list = [];

            if (file_type == "JSON")
            {
                students_list = JsonIO.readJSONArray(path_to_file);
            }

            else
            {
                students_list = XmlIO.readXml(path_to_file);
            }

            fromStudentsListToTable(students_list);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string file_type = fileTypeField.Text;
            string file_type_lower = file_type.ToLower();
            SaveFileDialog file_dialog = new();

            file_dialog.Title = $"Выберите {file_type} файл";
            file_dialog.Filter = $"{file_type} " +
                $"(*.{file_type_lower})|*.{file_type_lower}";
            file_dialog.DefaultExt = file_type_lower;

            DialogResult dr = file_dialog.ShowDialog();

            if (dr != DialogResult.OK)
            {
                return;
            }

            string path_to_file = file_dialog.FileName;
            List<Student> students_list = fromTableToStudentsList();

            if (file_type == "JSON")
            {
                JsonIO.writeJSONArray(path_to_file, students_list);
            }

            else
            {
                XmlIO.writeXml(path_to_file, students_list);
            }
        }

        private void fromStudentsListToTable(List<Student> students_list)
        {
            DataGridView students = studentsTbl;
            students.Rows.Clear();

            foreach (Student student in students_list)
            {
                int row_indx = students.Rows.Add();
                var cells = students.Rows[row_indx].Cells;

                cells["Fullname"].Value = student.Fullname;
                cells["RecordBook"].Value = student.RecordBook;
                cells["Department"].Value = student.Department;
                cells["Specification"].Value = student.Specification;
                cells["Group"].Value = student.Group;
                cells["DateOfAdmission"].Value = student.DateOfAdmission;
            }
        }

        private List<Student> fromTableToStudentsList()
        {
            List<Student> students_list = new();
            DataGridView students = studentsTbl;

            foreach (DataGridViewRow row in students.Rows)
            {
                var cells = row.Cells;

                students_list.Add(new Student(
                    (string)cells["Fullname"].Value,
                    (string)cells["RecordBook"].Value,
                    (string)cells["Department"].Value,
                    (string)cells["Specification"].Value,
                    (string)cells["Group"].Value,
                    (string)cells["DateOfAdmission"].Value));
            }

            return students_list;
        }
    }
}
