using System;
using ReactiveUI;
using Xamarin.Forms;
using System.Windows.Input;
using ReactiveUI.Fody.Helpers;

namespace ReactiveUpdateBug
{
    public class ProductViewModel : ReactiveObject
    {
        [Reactive]
        public string Name { set; get; }

        [Reactive]
        public string Category { set; get; }
        
        public ProductViewModel() 
        {
        }
    }
}

