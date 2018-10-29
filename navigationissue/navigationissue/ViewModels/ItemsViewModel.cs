using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using navigationissue.Models;
using navigationissue.Views;

namespace navigationissue.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {

        public ItemsViewModel()
        {
            Title = "Browse";
        }
    }
}