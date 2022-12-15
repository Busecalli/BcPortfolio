using EntityLayer.Concrete;
using EntityLayer.Tables;

namespace BcPortfolio.Models
{
    public class HomeModel
    {
        public static Admin Admin { get; set; }
        public static Hakkimda Hakkimda { get; set; }
        public static Servis Servis { get; set; }
        public static Tecrube Tecrube { get; set; }
        public static Yetenek Yetenek { get; set; }
        public static Yorum Yorum { get; set; }
        public IEnumerable<Servis> Servisler { get; set; }
        public IEnumerable<Tecrube> Tecrubeler { get; set; }
        public IEnumerable<Yetenek> Yetenekler { get; set; }
        public IEnumerable<Yorum> Yorumlar { get; set; }
    }
}
