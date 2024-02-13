using Bartu_Workbench.DataAccess.Abstracts;
using Bartu_Workbench.DataAccess.Concretes;

namespace Bartu_Workbench.Operation_Methods;
using Bartu_Workbench.Entities; 

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }


    public List<Course> GetAll()  // bu bir method  // ne veriyorsak onu belirtiyoruz Course[] --> course arrayi yani datası veriyoruz.
    {
        // business rules
        
        // business rules çalıştırdıktan sonra, db katmanına gidip bu tüm kurallardan geçti bize verileri(kursları) ver diyeceğiz.

        

        return _courseDal.GetAll();

    }
}