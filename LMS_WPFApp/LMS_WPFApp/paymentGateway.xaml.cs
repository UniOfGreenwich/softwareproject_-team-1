<<<<<<< HEAD
﻿using System.Windows;
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
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
//using System.Windows.Forms;
>>>>>>> d5f169f (added payment window UI start)

namespace LMS_WPFApp
{
    public partial class paymentGateway : Window
    {
<<<<<<< HEAD
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelPayFeesButton_Click(object sender, RoutedEventArgs e)
=======
        public paymentGateway()
        {
            InitializeComponent();
            DataTable.
            ComboBox cb=new ComboBox();
            cb.DataContext = db;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
>>>>>>> d5f169f (added payment window UI start)
        {

        }
    }
}
