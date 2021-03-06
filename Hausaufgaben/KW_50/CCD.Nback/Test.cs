﻿#region Header
// ============================================================================================
//   Projekt:   CCD5-2016/12/14
//  
//   (C) Copyright 2008-2016 CP Corporate Planning AG
//   http://www.corporate-planning.com
//  
//   Alle Rechte vorbehalten. All rights reserved.
// ============================================================================================
#endregion

using System;
using CCD.Nback.ViewModels;

namespace CCD.Nback
{
    public class Test
    {
        private int index = -1;
        public Test(char[] reizfolge, Parameter parameter)
        {
            this.Parameter = parameter;
            ReizFolge = reizfolge;
            ReaktionsFolge = new Reaktion[reizfolge.Length];
            StartDate = DateTime.Now;
        }

        public DateTime StartDate { get; }

        public Parameter Parameter { get; }

        public Reaktion[] ReaktionsFolge { get; set; }

        public char[] ReizFolge { get; set; }

        public int Index
        {
            get { return index; }
        }

        public Reiz Next()
        {
            index++;
            if (index >= ReizFolge.Length) return null;
            return new Reiz
            {
                Buchstabe = ReizFolge[index],
                Index = index,
                Total = ReizFolge.Length
            };
        }

        public void Add(Reaktion reaktion)
        {
            ReaktionsFolge[index] = reaktion;
        }
    }
}