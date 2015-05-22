using System;
using ReactiveUI.Fody.Helpers;
using ReactiveUI;

namespace ReactiveUpdateBug
{
    public class ReactiveListViewModel : ReactiveObject
    {
        public ReactiveList<ProductViewModel> Products { set; get; }

        public ReactiveListViewModel()
        {
            Products = new ReactiveList<ProductViewModel>();
            Products.Add(new ProductViewModel() { Name = "A", Category = "1"});
            Products.Add(new ProductViewModel() { Name = "B", Category = "2"});
            Products.Add(new ProductViewModel() { Name = "C", Category = "3"});
            Products.Add(new ProductViewModel() { Name = "D", Category = "4"});
            Products.Add(new ProductViewModel() { Name = "E", Category = "5"});
            Products.Add(new ProductViewModel() { Name = "F", Category = "6"});
            Products.Add(new ProductViewModel() { Name = "G", Category = "7"});
            Products.Add(new ProductViewModel() { Name = "H", Category = "8"});
            Products.Add(new ProductViewModel() { Name = "I", Category = "9"});
            Products.Add(new ProductViewModel() { Name = "J", Category = "10"});
            Products.Add(new ProductViewModel() { Name = "K", Category = "11"});
            Products.Add(new ProductViewModel() { Name = "L", Category = "12"});
            Products.Add(new ProductViewModel() { Name = "M", Category = "13"});
            Products.Add(new ProductViewModel() { Name = "N", Category = "14"});
            Products.Add(new ProductViewModel() { Name = "O", Category = "15"});
            Products.Add(new ProductViewModel() { Name = "P", Category = "16"});
            Products.Add(new ProductViewModel() { Name = "Q", Category = "17"});
        }
    }
}

