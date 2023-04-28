namespace CSharpInterviewQuestions.SealedKeywordExample3
{
    /*
     * Ví dụ 2:  mình định nghĩa 3 class Person và Student và PrimaryStudent. 
     * Class Person sẽ được khai báo method GetInfo(). 
     * Student sẽ kế thừa lớp Person và override lại method GetInfo() kèm với từ khoá sealed. 
     * PrimaryStudent kế thừa class Student và override lại method GetInfo(). 
     * Lúc này IDE biên dịch sẽ báo lỗi vì không thể override method GetInfo() ở class PrimaryStudent
     */

    public class Person
    {
        public virtual string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual string GetInfo() 
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Student : Person
    {
        private string _firstName;

        public sealed override string FirstName 
        { 
            get => _firstName; set => _firstName = "_" + value;
        }
    }

    public class PrimaryStudent : Student
    {
        private string _firstName;

        public override string FirstName
        {
            get => _firstName; set => _firstName = "+" + value;
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}