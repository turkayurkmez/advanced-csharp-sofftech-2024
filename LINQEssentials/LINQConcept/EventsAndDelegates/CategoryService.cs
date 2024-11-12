using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{

    public class CategoryCreatedEventArgs: EventArgs
    {
        public Category Category { get; set; }
        public DateTime When { get; set; }
        public string User { get; set; }
    }
    public class CategoryService
    {
        //nasıl yakalanacak?
        //public delegate void CategoryCreatedEventHandler(object sender, CategoryCreatedEventArgs e);
       // public Action<object sender, CategoryCreatedEventArgs e> CategoryCreatedEventHandler;
        //ne yakalanacak?
        public event EventHandler<CategoryCreatedEventArgs> CategoryCreated;

        public void CreateNewCategory(Category category)
        {
            //db'de işlem yapıldı....
            if (CategoryCreated != null)
            {
                CategoryCreatedEventArgs e = new CategoryCreatedEventArgs { Category= category, User="turkay", When=DateTime.Now };
                CategoryCreated(this, e);
            }
        }
    }
}
