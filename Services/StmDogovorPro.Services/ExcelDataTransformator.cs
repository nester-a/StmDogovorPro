using StmDogovorPro.Domain;
using StmDogovorPro.Domain.Base;
using StmDogovorPro.Domain.ExcelBase;
using StmDogovorPro.Services.Base;

namespace StmDogovorPro.Services
{
    public class ExcelDataTransformator : ITableDataTransformator<IExcelItem>
    {
        public IExcelItem Transform(string data)
        {
            var valuesArray = data.Split(';');
            if (valuesArray.Length != 21) throw new ArgumentException("Строка из таблицы неизвестного формата");

            IExcelItem excelItem = new ExcelItem();
            for (int i = 0; i < valuesArray.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(valuesArray[i])) valuesArray[i] = "0";
            }
            excelItem.Name = valuesArray[0];
            excelItem.CostWithTaxes = decimal.Parse(valuesArray[1]);
            excelItem.SaleCost = decimal.Parse(valuesArray[2]);
            excelItem.AnnualVolume = new AnnualVolume();
            excelItem.AnnualVolume.TD = double.Parse(valuesArray[3]);
            excelItem.AnnualVolume.FK = double.Parse(valuesArray[4]);
            excelItem.AnnualVolume.NAS = double.Parse(valuesArray[5]);
            excelItem.AnnualVolume.SGA = double.Parse(valuesArray[6]);
            excelItem.AnnualVolume.HF = double.Parse(valuesArray[7]);
            excelItem.AnnualVolume.Total = double.Parse(valuesArray[8]);
            excelItem.FirstBatch = new FirstBatch();
            excelItem.FirstBatch.TD = double.Parse(valuesArray[9]);
            excelItem.FirstBatch.FK = double.Parse(valuesArray[10]);
            excelItem.FirstBatch.NAS = double.Parse(valuesArray[11]);
            excelItem.FirstBatch.SGA = double.Parse(valuesArray[12]);
            excelItem.FirstBatch.HF = double.Parse(valuesArray[13]);
            excelItem.FirstBatch.Total = double.Parse(valuesArray[14]);
            excelItem.RC = new RCElement();
            excelItem.RC.TD = double.Parse(valuesArray[15]);
            excelItem.RC.FK = double.Parse(valuesArray[16]);
            excelItem.RC.NAS = double.Parse(valuesArray[17]);
            excelItem.RC.SGA = double.Parse(valuesArray[18]);
            excelItem.RC.HF = double.Parse(valuesArray[19]);

            return excelItem;
        }
    }
}
