using System.Reflection;
using System.Xml.Linq;
using TaskReflection;

/*
User clasi yaradin{
private id,
private name,
private surname
private static age

void GetFullName() methodu name+fullname consola yazdirir
static void ChangeAge(int age) methodu age deyerini deyisir
}
Reflection ilə edin

obyekt instance - sını yaradın.
Propertilərin dəyərini set edin daha sonra consola yazdırın.
methodları call edin*/

Type userType = typeof(User);
User user = (User)Activator.CreateInstance(userType);


FieldInfo fieldId=userType.GetField("Id",BindingFlags.NonPublic|BindingFlags.Instance);
fieldId.SetValue(user,2929 );
FieldInfo fieldName=userType.GetField("Name",BindingFlags.NonPublic|BindingFlags.Instance); 
fieldName.SetValue(user, "Shukran");
FieldInfo fieldSurname=userType.GetField("Surname",BindingFlags.NonPublic|BindingFlags.Instance);
fieldSurname.SetValue(user, "Slymnf");
FieldInfo fieldAge=userType.GetField("Age",BindingFlags.NonPublic|BindingFlags.Static);
fieldAge.SetValue(null, 20);


Console.WriteLine("ID: " + fieldId.GetValue(user));
Console.WriteLine("Name: " + fieldName.GetValue(user));
Console.WriteLine("Surname: " + fieldSurname.GetValue(user));
Console.WriteLine("Age: " + fieldAge.GetValue(null));


MethodInfo getFullNameMethod = userType.GetMethod("GetFullName", BindingFlags.Public | BindingFlags.Instance);
getFullNameMethod.Invoke(user, null);

MethodInfo changeAgeMethod = userType.GetMethod("ChangeAge", BindingFlags.Public | BindingFlags.Static);
changeAgeMethod.Invoke(null,  [ 30 ]);