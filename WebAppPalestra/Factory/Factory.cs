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

        public ASheet FindSheet(SheetType sheet)
        {
            switch (sheet)
            {
                case SheetType.sheet1:
                    return new Sheet1();
                case SheetType.sheet2:
                    return new Sheet2();
                case SheetType.sheet3:
                    return new Sheet3();
                default:
                    return new Sheet4();
            }
        }

    }
}
