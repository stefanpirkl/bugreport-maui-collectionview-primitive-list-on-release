using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewBinding
{
    internal class MainPageViewModel : BindableObject
    {
        private IList<string> _items = new List<string> { "first value", "second value", "third value" };

        public IList<string> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(nameof(Items)); }
        }
    }
}
