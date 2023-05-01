using PetagogetdheDepartamenti.data.Base;
namespace PetagogetdheDepartamenti.data.Models

{
    public class Petagog : BaseClass
    {

        public string Emer { get; set; }
        public string Mbiemer { get; set; }

        public DateTime DEP { get; set; }

        public string Lenda { get; set; }

        public int DepartamentId { get; set; }

    }
}
