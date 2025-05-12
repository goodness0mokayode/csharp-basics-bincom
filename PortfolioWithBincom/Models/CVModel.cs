public class CVModel
{
    public string Name { get; set; };
    public string Email { get; set; };
    public string Summary { get; set; };
    public List<string> Skills { get; set; };
    public List<EducationModel> Education { get; set; };
    public List<ExperienceModel> TechnicalExp { get; set; };
    public List<ExperienceModel> NonTechnicalExp { get; set; };
}

public class ExperienceModel
{
    public string JobTitle { get; set; };
    public string Duration { get; set; };
    public string CompanyName { get; set; };
    public string Description { get; set; };

}

public class EducationModel
{
    public string SchoolName { get; set; };
    public string SchoolSummary { get; set; };
    public string DurationStudied { get; set; };
}