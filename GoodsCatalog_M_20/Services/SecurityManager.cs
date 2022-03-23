﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GoodsCatalog_M_20.Services
{
    public class SecurityManager
    {
        public static string GetHash(string input) 
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();

           for (int i = 0; i < data.Length; i++) 
            { 
                sBuilder.Append(data[i].ToString("x2")); 
            } 
            return sBuilder.ToString(); }
    }
}