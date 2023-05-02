using PetagogetdheDepartamenti.data.Base;
namespace PetagogetdheDepartamenti.data.Models
{
    public class Departament:BaseClass
    {
        public int Numri { get; set; }
        public string EmriD { get; set; }

        public string Godina { get; set; }
        public List<Petagog> Petagoget { get; set; }

    }
}
