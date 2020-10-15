using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace libmass
{
    public class LibMass
    {
        public static void InstantRandomTable(ref DataGridView dgw, int amountNumbers, int maxNumber)// функция заполнения таблицы рандомными значениями
        {
            dgw.ColumnCount = amountNumbers;// присваеваем количество столбцов
            dgw.RowCount = 1;// присваеваем количество строк
            Random rnd = new Random();
            for (int i = 0; i < dgw.ColumnCount; i++)// заполняем таблицу рандомными значениями
            {
                dgw[i, 0].Value = rnd.Next(maxNumber);
            }

        }
        public static void OpenDialogToOpen(ref DataGridView dgw, OpenFileDialog ofd1)// функция открытия файла с сохраненной таблицей
        {
            if (ofd1.ShowDialog() == DialogResult.OK)// если диалог открыт
            {
                StreamReader read = new StreamReader(ofd1.FileName);// создаем объект, содержащий имя файла
                dgw.ColumnCount = Convert.ToInt32(read.ReadLine());// считываем количество столбцов из файла и присваиваем текущей таблице
                for (int i = 0; i < dgw.ColumnCount; i++)
                {
                    dgw[i, 0].Value = Convert.ToInt32(read.ReadLine());// считываем и присваеваем значения таблицы из файла
                }
                read.Close();// закрываем поток
            }

        }

        public static void OpenDialogToSave(ref DataGridView dgw, SaveFileDialog sfd1)// функция сохранения таблицы
        {
            if (sfd1.ShowDialog() == DialogResult.OK)// если диалог открыт
            {
                StreamWriter file = new StreamWriter(sfd1.FileName);// создаем объект, в котором мы будем записывать значения таблицы
                file.WriteLine(dgw.ColumnCount);// записываем в файл количество столбцов таблицы
                for (int i = 0; i < dgw.ColumnCount; i++)
                {
                    file.WriteLine(dgw[i, 0].Value);// записываем значения из таблицы в файл
                }
                file.Close();// закрываем поток 
            }
        }

        public static void ClearTable(ref DataGridView dgw)// функция очистки таблицы от значений
        {
            for (int i = 0; i < dgw.ColumnCount; i++)
            {
                dgw[i, 0].Value = " ";
            }
        }
    }
}
