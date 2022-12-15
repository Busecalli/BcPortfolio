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
    public class Tecrube_Manager : I_Tecrube_Service
    {
        I_Tecrube_Dal _tecrubeDal;
        public Tecrube_Manager(I_Tecrube_Dal tecrubeDal)
        {
            _tecrubeDal = tecrubeDal;
        }
        public void TAdd(Tecrube t)
        {
            _tecrubeDal.Insert(t);
        }

        public void TDelete(Tecrube t)
        {
            _tecrubeDal.Delete(t);
        }

        public Tecrube TGetById(int id)
        {
            return _tecrubeDal.GetByID(id);
        }

        public List<Tecrube> TGetList()
        {
            return _tecrubeDal.GetList();
        }

        public void TUpdate(Tecrube t)
        {
            _tecrubeDal.Update(t);
        }
    }
}
