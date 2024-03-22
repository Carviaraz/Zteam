namespace Zteam.Models
{
    public class BuyDtl
    {
        public string BuyId { get; set; } = null!;

        public string PdId { get; set; } = null!;

        public double? BdtlQty { get; set; }

        public double? BdtlPrice { get; set; }

        public double? BdtlMoney { get; set; }
    }
}
