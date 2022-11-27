using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDemo_MertSOLAK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Classroom> listOfClassrooms = new List<Classroom>();
        Classroom selectedClassroom = new Classroom();
        int index;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillClasDepartment();
            FillClasLetter();
            FillInstructorDepartment();
        }

        public void FillClasDepartment()
        {
            var names = Enum.GetNames(typeof(ClassDepartments));
            names.ToList().ForEach(n => comboBoxBolum.Items.Add(n));
        }

        public void FillClasLetter()
        {
            var names = Enum.GetNames(typeof(Letters));
            names.ToList().ForEach(n => comboBoxSube.Items.Add(n));
        }

        public void FillInstructorDepartment()
        {
            var names = Enum.GetNames(typeof(InstructorDepartments));
            names.ToList().ForEach(n => comboBoxEgitmenBrans.Items.Add(n));
        }

        private void buttonSinifOlustur_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            if (Int32.TryParse(textBoxSinifNo.Text, out sayi))
            {
                if (textBoxSinifNo.Text != "" && comboBoxBolum.SelectedItem != null && comboBoxSube.SelectedItem != null && int.Parse(textBoxSinifNo.Text) <= 12 && int.Parse(textBoxSinifNo.Text) >= 9)
                {
                    Classroom classroom = new Classroom()
                    {
                        ClassNo = int.Parse(textBoxSinifNo.Text),
                        Letter = comboBoxSube.SelectedItem.ToString(),
                        Department = comboBoxBolum.SelectedItem.ToString()
                    };
                    listOfClassrooms.Add(classroom);
                    FillListView();
                }
            }
            else MessageBox.Show("Tekrar Deneyiniz.");
        }

        private void buttonEgitmenAta_Click(object sender, EventArgs e)
        {
            if (textBoxEgitmenAd.Text != "" && textBoxEgitmenSoyad.Text != "" && comboBoxEgitmenBrans.SelectedItem != null)
            {
                Instructor ınstructor = new Instructor()
                {
                    Name = textBoxEgitmenAd.Text,
                    LastName = textBoxEgitmenSoyad.Text,
                    Department = comboBoxEgitmenBrans.SelectedItem.ToString(),
                    Classroom = selectedClassroom
                };
                selectedClassroom.SetMainInstructor(ınstructor);
                listOfClassrooms.RemoveRange(index, 1);
                listOfClassrooms.Add(selectedClassroom);
                FillListView();
                EgitmenBtnAcmak(false);
            }
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (textBoxOgrenciAd.Text != "" && textBoxOgrenciSoyad.Text != "" && textBoxOgrenciAdres.Text != "")
            {
                Student student = new Student()
                {
                    Name = textBoxOgrenciAdres.Text,
                    LastName = textBoxOgrenciAdres.Text,
                    Adress = textBoxOgrenciAdres.Text,
                    Classroom = selectedClassroom
                };
                selectedClassroom.AddStudent(student);
                listOfClassrooms.RemoveRange(index, 1);
                listOfClassrooms.Add(selectedClassroom);
                FillListBox();
                FillListView();
                EgitmenBtnAcmak(false);
            }
        }

        public void FillListView()
        {
            listView1.Items.Clear();
            foreach (var item in listOfClassrooms)
            {
                string[] row = { item.ClassName, item.StudentCount.ToString(), item.MasterInstructor is null ? "Atanan Eğitmen Yok" : item.MasterInstructor.ToString() };
                var satir = new ListViewItem(row);
                satir.Tag = item;
                listView1.Items.Add(satir);
            }
        }

        public void FillListBox()
        {
            listBoxOgrenciler.Items.Clear();
            foreach (var item in selectedClassroom.GetStudent().ToList())
            {
                listBoxOgrenciler.Items.Add(item.ToString());
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            selectedClassroom = listView1.SelectedItems[0].Tag as Classroom;
            index = listOfClassrooms.FindIndex(a => a.ClassName == selectedClassroom.ClassName);
            FillListBox();
            EgitmenBtnAcmak(true);
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            EgitmenBtnAcmak(false);
        }

        public void EgitmenBtnAcmak(bool boolDeger)
        {
            groupBox1.Enabled = !boolDeger;
            groupBox2.Enabled = boolDeger;
            groupBox3.Enabled = boolDeger;
            buttonIptal.Enabled = boolDeger;
        }
    }
}
