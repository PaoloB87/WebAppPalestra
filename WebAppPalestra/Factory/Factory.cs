using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Models;
using WebAppPalestra.Factory;

namespace WebAppPalestra.Factory
{
    public class Factory:IFactory
    {

        ASheet appoSheet;

        public ASheet FindSheet(SheetModel sheetModel) {

            if (sheetModel.Age < 18) {

                appoSheet = new Sheet1();


            }

            return appoSheet;

        }

    }
}
