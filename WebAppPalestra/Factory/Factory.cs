using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Models;
using WebAppPalestra.Factory;
using WebAppPalestra.Business;

namespace WebAppPalestra.Factory
{
    public class Factory : IFactory
    {

        ASheet appoSheet;

        public ASheet FindSheet(SheetType sheet)
        {

            switch (sheet)
            {
                case SheetType.sheet1:
                    appoSheet = new Sheet1();
                    break;
                case SheetType.sheet2:
                    appoSheet = new Sheet2();
                    break;
                case SheetType.sheet3:
                    appoSheet = new Sheet3();
                    break;
                default:
                    appoSheet = new Sheet4();
                    break;
            }

            return appoSheet;
        }

    }
}
