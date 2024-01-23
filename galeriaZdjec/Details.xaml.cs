﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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
using System.Xml.Linq;
using static galeriaZdjec.MainWindow;

namespace galeriaZdjec
{
    /// <summary>
    /// Logika interakcji dla klasy Details.xaml
    /// </summary>
    public partial class Details : Window
    {        
        Photo photo;
        public Details(Photo photo1)
        {
            InitializeComponent();
            photo = photo1; 
            Zdjecie.Source = new BitmapImage(new Uri(photo.Image, UriKind.Relative));
        }
    }
}
