using Bartu_Workbench.Entities;

namespace Bartu_Workbench.DataAccess.Abstracts;

public interface ICourseDal  // burada operasyonlarımızın imzası bulunur.  // beni implemente eden sınıf bu ikisini içermek zorunda.
{
    List<Course> GetAll();

    void Add(Course course);
}