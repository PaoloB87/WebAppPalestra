﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPalestra.Factory
{
    public class Sheet3 : ISheetFactory
    {
        public string _Sheet;

        public string Sheet
        {

            get => _Sheet;
            set => _Sheet = "Scheda3";
        }
    }
}
