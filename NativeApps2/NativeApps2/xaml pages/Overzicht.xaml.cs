﻿using NativeApps2.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NativeApps2.xaml_pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Overzicht : Page
    {
        public Overzicht()
        {
            this.InitializeComponent();

            //Test-fase
            List<Onderneming> ondernemingen = new List<Onderneming>();
            ondernemingen.Add(new Onderneming("Apple inc", "Technologie", "California", "Ma-Vrij 08u00-17u30"));
            ondernemingen.Add(new Onderneming("Ikea", "Meubels", "Sweden", "Ma-Vrij 08u00-17u30 zat-zon 08u-21u00"));


            //Lijst als datacontext (of itemsource) van listview
            //myLV.ItemsSource = spelers; of
            myLV.DataContext = ondernemingen;
        }
    }
}
