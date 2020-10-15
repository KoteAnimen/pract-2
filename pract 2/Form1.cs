using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libmass;
using lib1;

namespace pract_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteCounts_Click(object sender, EventArgs e)// событие создания таблицы
        {
            LibMass.InstantRandomTable(ref Table, (int)amountNumbers.Value, (int)rangeNumbers.Value);
        }

        private void Exit_Click(object sender, EventArgs e)// событие закрытия программы
        {
            this.Close();
        }

        private void AboutUs_Click(object sender, EventArgs e)// событие, в котором мы получаем сведения о программе
        {
            MessageBox.Show("Филяк ИСП-31 Вариант 1. Ввести n целых чисел. Найти сумму чисел > 5. Результат вывести на экран. ");
        }

        private void CleanTable_Click(object sender, EventArgs e)// событие очистки таблицы
        {
            LibMass.ClearTable(ref Table);
            
        }

        private void OpenFile_Click(object sender, EventArgs e)// событие открытия таблицы из файла
        {
            LibMass.OpenDialogToOpen(ref Table, openFileDialog1);
        }

        private void SaveFile_Click(object sender, EventArgs e)// событие сохранения таблицы в файл
        {
            LibMass.OpenDialogToSave(ref Table, saveFileDialog1);
        }

        private void GetAnswer_Click(object sender, EventArgs e)// событие рассчета по заданию.
        {
            Lib_1.CalculateMyTask(Table, out int summ);
            answer.Text = summ.ToString();
        }
    }
}
