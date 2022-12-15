using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete 
{
    public class Yorum_Manager : I_Yorum_Service
    {
        I_Yorum_Dal _yorumDal;
        public Yorum_Manager(I_Yorum_Dal yorumDal)
        {
            _yorumDal = yorumDal;
        }
        public void TAdd(Yorum t)
        {
            _yorumDal.Insert(t);
        }

        public void TDelete(Yorum t)
        {
            _yorumDal.Delete(t);
        }

        public Yorum TGetById(int id)
        {
            return _yorumDal.GetByID(id);
        }

        public List<Yorum> TGetList()
        {
            return _yorumDal.GetList();
        }

        public void TUpdate(Yorum t)
        {
            _yorumDal.Update(t);
        }
    }
}
