﻿using ProjeTakipOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTakipOtomasyonu
{
    public partial class ScoreReportForm : Form
    {
        public ScoreReportForm()
        {
            InitializeComponent();
        }

        public void OpenGrid(List<ScoreViewModel> scores)
        {
            grdViewScoreReport.DataSource = scores;
            
            this.ShowDialog();
        }
    }
}
