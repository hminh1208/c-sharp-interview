namespace CSharpInterviewQuestions.SealedKeywordExample1
{
    /*
     * Ví dụ 1: mình định nghĩa 2 class là Person và Student. 
     * Class Person sẽ được khai báo bằng từ khoá sealed và Student sẽ kế thừa từ Person. 
     * Khi biên dịch, trình biên dịch sẽ báo lỗi, vì không thể kế thừa từ sealed class Person
     */
    public sealed class Person
    {
        public string FirstName { get; set; }

        public string LasyName { get; set; }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
    }
}