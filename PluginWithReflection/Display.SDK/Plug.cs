﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public class Plug
    {

      
        


        //1. Menüye ekleyeceksiniz. -> İsim
        public string Name { get; set; }

        //2. Referans ekleyeceksiniz -> Tam adres
        public string Path { get; set; }

        //3. Instance alıp kullanacaksınız -> FullName
        public string FullName { get; set; }
    }
}
