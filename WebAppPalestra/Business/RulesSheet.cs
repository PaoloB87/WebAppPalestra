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

        enum AppoSheet {

            sheet1,
            sheet2,
            sheet3,
            sheet4

        }

        public Enum FindSheet(SheetModel sheetModel)
        {

            if (sheetModel.Age < 18 && sheetModel.Weight < 60 && sheetModel.Height < 150)
            {

                AppoSheet = { sheet1 = "",sheet1 = "",sheet1 = "",sheet1 = ""};


            } else if (sheetModel.Age >= 18 && sheetModel.Age < 50 && sheetModel.Weight < 60 && sheetModel.Height >= 150 && sheetModel.Height < 180) {


            }
            else if (sheetModel.Age >= 50 && sheetModel.Weight > 80 && sheetModel.Height >= 150 && sheetModel.Height < 180)
            {


            }
            else { 
            
            }

            return appoSheet;

        }
    }
}
