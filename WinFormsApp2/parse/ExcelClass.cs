using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp2.parse
{
    public class ExcelClass
    {
        private static Excel.Application? xlApp;
        private static Excel._Worksheet? workSheet;
        private static Excel.Workbook? workbook;
        private object _missingObj = System.Reflection.Missing.Value;


        private static Dictionary<string, string> dictCellsSingleMI = new Dictionary<string, string>()
        {
            {"mitypeNumber", "B" },
            {"mitypeType", "C" },
            {"mitypeTitle", "D" },
            {"manufactureNum", "E" },
            {"inventoryNum", "F" },
            {"manufactureYear", "G" },
            {"modification", "H" },
            {"organization", "S" },
            {"miOwner", "T" },
            {"vrfDate", "U" },
            {"validDate", "V" },
            {"vriType", "W" },
            {"docTitle", "X" },
            {"certNum", "Y" },
            {"noticeNum ", "Z" },
            {"structure", "AA" },
            {"briefIndicator", "AB" },
            {"briefCharacteristics", "AC" },
            {"ranges", "AD" },
            {"values", "AE" },
            {"channels", "AF" },
            {"blocks", "AG" },
            {"additional_info", "AH" },
            {"status", "AI" }
        };

        private static Dictionary<string, string> dictCellsEtaMI = new Dictionary<string, string>()
        {
            {"regNumber", "I" },
            {"mitypeNumber", "J" },
            {"mitypeTitle", "K" },
            {"mitypeType", "L" },
            {"modification", "M" },
            {"manufactureNum", "N" },
            {"manufactureYear", "O" },
            {"rankCode", "P" },
            {"rankTitle", "Q" },
            {"schemaTitle", "R" },
            {"organization", "S" },
            {"miOwner", "T" },
            {"vrfDate", "U" },
            {"validDate", "V" },
            {"vriType", "W" },
            {"docTitle", "X" },
            {"certNum", "Y" },
            {"noticeNum ", "Z" },
            {"structure", "AA" },
            {"briefIndicator", "AB" },
            {"briefCharacteristics", "AC" },
            {"ranges", "AD" },
            {"values", "AE" },
            {"channels", "AF" },
            {"blocks", "AG" },
            {"additional_info", "AH" },
            {"status", "AI" }
        };

        public ExcelClass() {
            System.IO.File.Delete(Path.Combine(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "data.xlsx"));

            xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            //xlApp.Workbooks.Open(Path.Combine(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "data.xlsx"));
            workbook = xlApp.Workbooks.Add();

            workSheet = (Excel.Worksheet)xlApp.ActiveSheet;
            //xlApp.Visible = true;
            workSheet.EnableSelection = XlEnableSelection.xlNoSelection;

            SetHeader();
            SetArgs();
        }

        public static void SetHeader()
        {
            //Сведение о единичном СИ
            SetStyleHeader("Сведения о единичном СИ", "B1", "H1");
            SetBorder(workSheet.get_Range("B1", "H2"));

            //СИ, применяемое в качестве эталона
            SetStyleHeader("СИ, применяемое в качестве эталона", "I1", "R1");
            SetBorder(workSheet.get_Range("I1", "R2"));

            //Сведения о поверке
            SetStyleHeader("Сведения о поверке", "S1", "Z1");
            SetBorder(workSheet.get_Range("S1", "Z2"));

            //Доп. сведения
            SetStyleHeader("Дополнительные сведения", "AA1", "AH1");
            SetBorder(workSheet.get_Range("AA1", "AH2"));

            //Сведения о публикации
            SetStyleHeader("Сведения о публикации", "AI1", "AI1");
            SetBorder(workSheet.get_Range("AI1", "AI2"));

        }

        public static void SetStyleHeader(string text, string rangeA, string rangeB)
        {
            Excel.Range header_range;

            header_range = workSheet.get_Range(rangeA, rangeB);
            header_range.Merge(Type.Missing);
            header_range.Value2 = text;
            header_range.HorizontalAlignment = Constants.xlCenter;
            header_range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Pink);
        }

        public static void SetArgs()
        {
            workSheet.Cells[2, "A"] = "Идентификатор версии элемента";

            //Сведение о единичном СИ
            workSheet.Cells[2, "B"] = "Номер в Госреестре утверженного типа СИ"; //"mitypeNumber";
            workSheet.Cells[2, "C"] = "Тип СИ"; //"mitypeType";
            workSheet.Cells[2, "D"] = "Наименование типа СИ"; //"mitypeTitle";
            workSheet.Cells[2, "E"] = "Заводской/серийный номер СИ"; //"manufactureNum";
            workSheet.Cells[2, "F"] = "Инвентарный номер/буквенно-цифровое обозначение СИ"; // "inventoryNum";
            workSheet.Cells[2, "G"] = "Год выпуска СИ"; // "manufactureYear";
            workSheet.Cells[2, "H"] = "Модификация СИ"; // "modification";

            //СИ, применяемое в качестве эталона
            workSheet.Cells[2, "I"] = "Регистрационный номер СИ в перечне";
            workSheet.Cells[2, "J"] = "Номер в реестре утверженного типа СИ";
            workSheet.Cells[2, "K"] = "Наименование утвержденного типа СИ";
            workSheet.Cells[2, "L"] = "Тип СИ";
            workSheet.Cells[2, "M"] = "Модификация СИ";
            workSheet.Cells[2, "N"] = "Заводской номер СИ";
            workSheet.Cells[2, "O"] = "Год выпуска СИ";
            workSheet.Cells[2, "P"] = "Код разряда эталона в ГПС, которому соответствует СИ";
            workSheet.Cells[2, "Q"] = "Наименование разряда эталона в ГПС, которому соответствует СИ";
            workSheet.Cells[2, "R"] = "Наименование поверочной схемы или методики поверки";

            //Сведения о поверке
            workSheet.Cells[2, "S"] = "Наименование организации поверителя";//"organization";
            workSheet.Cells[2, "T"] = "ЮЛ (ФЛ), передавшее СИ (партию СИ) на проверку";// "miOwner";
            workSheet.Cells[2, "U"] = "Дата поверки СИ";//"vrfDate";
            workSheet.Cells[2, "V"] = "Поверка действительна до";//"validDate";
            workSheet.Cells[2, "W"] = "Тип поверки";//"vriType";
            workSheet.Cells[2, "X"] = "Наименование документа, на основании которого выполнена поверка";//"docTitle";
            workSheet.Cells[2, "Y"] = "Номер свидетельства/выписки";//"certNum";
            workSheet.Cells[2, "Z"] = "Номер извещения/выписки";//"noticeNum";

            //Доп. сведения
            workSheet.Cells[2, "AA"] = "Состав СИ, представленного на поверку";//"structure";
            workSheet.Cells[2, "AB"] = "Признак сокращенной поверки";//"briefIndicator";
            workSheet.Cells[2, "AC"] = "Краткая характеристика объёма поверки";//"briefCharacteristics";
            workSheet.Cells[2, "AD"] = "Диапазоны (поддиапазоны), на которых поверено СИ";//"ranges";
            workSheet.Cells[2, "AE"] = "Отдельные величины, для которых поверено СИ";//"values";
            workSheet.Cells[2, "AF"] = "Измерительные каналы СИ, прошедшие поверку";//"channels";
            workSheet.Cells[2, "AG"] = "Отдельные автономные блоки из состава СИ, прошедшие поверку";//"blocks";
            workSheet.Cells[2, "AH"] = "Прочие сведения";//"additional_info";

            //Сведения о публикации
            workSheet.Cells[2, "AI"] = "Статус записи";//"status";

        }

        public void SetRow(bool etaMI, ref Dictionary<string, string> value, int i, string vri_id)
        {
            workSheet.get_Range("A" + i.ToString(), "Y" + i.ToString()).NumberFormat = "@";
            SetBorder(workSheet.get_Range("A" + i.ToString(), "A" + i.ToString()));
            SetBorder(workSheet.get_Range("B" + i.ToString(), "H" + i.ToString()));
            SetBorder(workSheet.get_Range("I" + i.ToString(), "R" + i.ToString()));
            SetBorder(workSheet.get_Range("S" + i.ToString(), "Z" + i.ToString()));
            SetBorder(workSheet.get_Range("AA" + i.ToString(), "AH" + i.ToString()));
            SetBorder(workSheet.get_Range("AI" + i.ToString(), "AI" + i.ToString()));

            workSheet.Cells[i, "A"] = vri_id;

            foreach (var item in value)
            {
                if(dictCellsEtaMI.ContainsKey(item.Key) || dictCellsSingleMI.ContainsKey(item.Key))
                {
                    var tempItem = item.Value;
                    if (item.Key == "briefIndicator")
                    {
                        //MessageBox.Show(item.Value);
                        if (item.Value == "True")
                        {
                            tempItem = "Да";
                        }
                        else
                        {
                            tempItem = "Нет";
                        }
                    }

                    if (item.Key == "vriType")
                    {
                        if (item.Value == "1")
                        {
                            tempItem = "Первичная";
                        }
                        else
                        {
                            tempItem = "Периодическая";
                        }
                    }

                    if (etaMI)
                    {
                        workSheet.Cells[i, dictCellsEtaMI[item.Key]] = tempItem;
                    }
                    else
                    {
                        workSheet.Cells[i, dictCellsSingleMI[item.Key]] = tempItem;
                    }
                }   
            }
        }

        public static void SetBorder(Excel.Range range)
        {
            
            var BorderIndex = Excel.XlBordersIndex.xlEdgeLeft; 
            
            range.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            range.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[BorderIndex].ColorIndex = 0;

            BorderIndex = Excel.XlBordersIndex.xlEdgeRight;

            range.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            range.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[BorderIndex].ColorIndex = 0;
        }

        public void Save()
        {
            workbook.SaveAs(Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "data.xlsx"));
        }

        public void Quit()
        {
            if (xlApp != null)
            {
                //workbook.Close(false, _missingObj, _missingObj);
                xlApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                xlApp = null;
                workbook = null;
                workSheet = null;

                System.GC.Collect();
            }
        }

        public void Hide(bool boxTick)
        {
            xlApp.Visible = boxTick;
        }

        public void Counter(int i, string str)
        {
            workSheet.Cells[i, "A"] = str;
        }

        //public void Test(int i, string vri_id)
        //{
        //    workSheet.Cells[i, "A"] = vri_id;
        //}
    }
}
