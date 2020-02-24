using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ShoppingList2
{
    public class ShoppingListData : INotifyPropertyChanged
    {
        List<string> items = new List<string>();
        public IEnumerable<string> Items => items.ToArray();

        public event PropertyChangedEventHandler PropertyChanged; 

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        
        
    }
}
