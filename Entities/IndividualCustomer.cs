namespace Bartu_Workbench.Entities;

public class IndividualCustomer:BaseCustomer
{
    
    public string FirstName { get; set; }
    
    public  string LastName { get; set; }
    
    public string NationalIdentity { get; set; }
    
}

// id, customernumber gibi ortak parametreleri basecustomer olarak ayrı class içine alacağım.

// inheritance kavramı--> ortak iki parametresi olan coorporate ve individual customer classının ikisinin de müşteri olduğunu ve basecustomerdan referans alabileceğini gösterir.