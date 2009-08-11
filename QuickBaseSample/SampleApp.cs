﻿/*
 * QuickBaseSampleApp.cs    11 August 2009, 17:38
 * 
 * Copyright 2009 John Sands (Australia) Ltd. All rights reserved.
 * Use is subject to license terms.
 * 
 * Author: Brett Ryan
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace JohnSands.QuickBase.Sample {

    public static class SampleApp {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SampleForm());
        }

    }

}
