using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPalestra.Business;
using WebAppPalestra.Models;

namespace WebAppPalestra.Factory
{
    public interface IFactory
    {

        public ASheet FindSheet(SheetType sheet);

    }
}
