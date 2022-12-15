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
    public class Hakkimda_Manager : I_Hakkimda_Service
    {
        I_Hakkimda_Dal _hakkimdaDal;

        public Hakkimda_Manager(I_Hakkimda_Dal hakkimdaDal)
        {
            _hakkimdaDal = hakkimdaDal;
        }
        public void TAdd(Hakkimda t)
        {
            _hakkimdaDal.Insert(t);
        }

        public void TDelete(Hakkimda t)
        {
            _hakkimdaDal.Delete(t);
        }

        public Hakkimda TGetById(int id)
        {
            return _hakkimdaDal.GetByID(id);
        }

        public List<Hakkimda> TGetList()
        {
            return _hakkimdaDal.GetList();
        }

        public void TUpdate(Hakkimda t)
        {
            _hakkimdaDal.Update(t);
        }
    }
}
