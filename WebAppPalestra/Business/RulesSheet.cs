using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Factory;
using WebAppPalestra.Models;

namespace WebAppPalestra.Business
{
    public class RulesSheet
    {

        public SheetType FindSheet(SheetModel sheetModel)
        {
            if (sheetModel.Age < 18 && sheetModel.Weight < 60 && sheetModel.Height < 150)
            {
                return SheetType.sheet1;
            }
            else if (sheetModel.Age >= 18 && sheetModel.Age < 50 && sheetModel.Weight < 60 && sheetModel.Height >= 150 && sheetModel.Height < 180)
            {
                return SheetType.sheet2;
            }
            else if (sheetModel.Age >= 50 && sheetModel.Weight > 80 && sheetModel.Height >= 150 && sheetModel.Height < 180)
            {
                return SheetType.sheet3;
            }
            else
            {
                return SheetType.sheet4;
            }
        }
    }
}
