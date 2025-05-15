public class TaxCalculatorModel
{
    public decimal GrossIncome { get; set; }
    public decimal TaxOwed {  get; set; }
    [Required(ErrorMessage="Please select a region.")]
    public string Region { get; set; }
    public string Summary { get; set; }

}