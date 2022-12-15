using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorum
    {
        public int Id { get; set; }
        public string YorumcuAdSoyad { get; set; }
        public string YorumcuMeslek { get; set; }
        public string YorumcuGorsel { get; set; }
        public string YorumcuAciklama { get; set; }
    }
}
