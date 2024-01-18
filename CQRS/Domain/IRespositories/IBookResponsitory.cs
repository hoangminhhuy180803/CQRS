using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRespositories
{
    public interface IBookResponsitory 
    {
        public void Add(Books books);
        public void Update(Books book);
        public bool CheckExist(int id);
        public void Delete(int id);
        public Books Get(int id);
        public bool UpdateBooks(int bookId , int quantity);
    }
}
