﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HouseApp
{
    /// <summary>
    /// Логика взаимодействия для ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        public ResultsWindow(List<HouseModel> houses)
        {
            InitializeComponent();
        }
    }
}
