using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Servis_Manager : I_Servis_Service
    {
        I_Servis_Dal _servisDal;
        public Servis_Manager(I_Servis_Dal servisDal)
        {
            _servisDal = servisDal;
        }
        public void TAdd(Servis t)
        {
            _servisDal.Insert(t);
        }

        public void TDelete(Servis t)
        {
            _servisDal.Delete(t);
        }

        public Servis TGetById(int id)
        {
            return _servisDal.GetByID(id);
        }

        public List<Servis> TGetList()
        {
            return _servisDal.GetList();
        }

        public void TUpdate(Servis t)
        {
            _servisDal.Update(t);
        }
    }
}
