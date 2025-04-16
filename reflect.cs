using System.Reflection;

class Reflection
{
    // static void Main(string[] args)
    // {
    //     //Assembly
    //     //主要是用来加载其他程序集
    //     //程序集，是一个可执行文件或一个dll文件
    //     //三种加载程序集的函数
    //     //一般用来加载在同一文件下的其他程序集
    //     // Assembly assembly = Assembly.Load("Test.dll");
    //     //用来加载在不同文件下的其他程序集(绝对路径)
    //     // Assembly assembly = Assembly.LoadFile(@"D:\project\LeetCode\bin\Debug\net8.0\LeetCode.dll");
    //     //用来加载在不同文件下的其他程序集(相对路径)
    //     Assembly assembly = Assembly.LoadFrom("./bin/Debug/net8.0/Animal.dll");
    //     //获得dll中可加载的类型 (Type)，包括类、接口、结构体、枚举和委托等。
    //     Type[] types = assembly.GetTypes();
    //     foreach (Type t in types)
    //     {
    //         System.Console.WriteLine(t);
    //     }
    //     Type animalType = types[1];
    //     //获得类中的所有公共成员（私有的不显示）
    //     MemberInfo[] members = animalType.GetMembers();
    //     foreach (MemberInfo member in members)
    //     {
    //         System.Console.WriteLine(member);
    //     }
    //     //实例化
    //     Object animalObj = Activator.CreateInstance(animalType);

    //     //查看/修改字段值
    //     FieldInfo fieldName = animalType.GetField("name");
    //     FieldInfo fieldCategory = animalType.GetField("category");
    //     fieldName.SetValue(animalObj, "Tom");
    //     fieldCategory.SetValue(animalObj, "dog");

    //     //调用方法
    //     MethodInfo methodEat = animalType.GetMethod("Eat");
    //     MethodInfo methodSpeak = animalType.GetMethod("Speak");
    //     methodEat.Invoke(animalObj, null);
    //     methodSpeak.Invoke(animalObj, null);
    // }
}