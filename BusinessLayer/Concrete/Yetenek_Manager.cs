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
    public class Yetenek_Manager : I_Yetenek_Service
    {
        I_Yetenek_Dal _yetenekDal;
        public Yetenek_Manager(I_Yetenek_Dal yetenekDal)
        {
            _yetenekDal = yetenekDal;
        }
        public void TAdd(Yetenek t)
        {
            _yetenekDal.Insert(t);
        }

        public void TDelete(Yetenek t)
        {
            _yetenekDal.Delete(t);
        }

        public Yetenek TGetById(int id)
        {
            return _yetenekDal.GetByID(id);
        }

        public List<Yetenek> TGetList()
        {
            return _yetenekDal.GetList();
        }

        public void TUpdate(Yetenek t)
        {
            _yetenekDal.Update(t);
        }
    }
}
