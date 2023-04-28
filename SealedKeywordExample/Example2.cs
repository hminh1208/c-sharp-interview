namespace CSharpInterviewQuestions.SealedKeywordExample2
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
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }

        public sealed override string GetInfo()
        {
            return $"{StudentId} {FirstName} {LastName}";
        }
    }

    public class PrimaryStudent : Student
    {
        public override string GetInfo()
        {
            return $"{StudentId} {FirstName} {LastName}";
        }
    }
}