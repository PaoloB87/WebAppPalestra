using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Models;

namespace WebAppPalestra.Factory
{
    public interface IFactory
    {

        public ASheet FindSheet(SheetModel sheetModel);

    }
}
