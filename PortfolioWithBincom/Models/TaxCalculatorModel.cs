using System.ComponentModel.DataAnnotations;

public class TaxCalculatorModel
{
    public decimal? TaxOwed { get; set; }
    [Required]
    [Display(Name = "Gross Income (£)")]
    [Range(0, double.MaxValue, ErrorMessage = "Income must be a positive number.")]
    public decimal GrossIncome { get; set; }
}