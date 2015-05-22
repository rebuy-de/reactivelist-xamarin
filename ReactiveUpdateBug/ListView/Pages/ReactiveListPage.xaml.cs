using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReactiveUpdateBug
{
    public partial class ReactiveListPage : ContentPage
    {
        public ReactiveListPage()
        {
            InitializeComponent();
        }
            
        private void itemSelected(object parameters, SelectedItemChangedEventArgs e) 
        {
            ((ReactiveListViewModel) BindingContext).Products.Remove((ProductViewModel) e.SelectedItem);
        }
    }
}

