﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    public class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite...");
            Console.WriteLine("Limite Ok!");
        }
    }
}
