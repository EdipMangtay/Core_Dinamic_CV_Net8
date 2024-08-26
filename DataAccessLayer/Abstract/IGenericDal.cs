using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T p); // burada T tipinde bir parametre alacak ve bu parametreyi p olarak adlandıracak
        void Update(T p); // burada T tipinde bir parametre alacak ve bu parametreyi p olarak adlandıracak
        void Delete(T p);
        List<T> GetList();
        T GetById(int id);
    }
}
